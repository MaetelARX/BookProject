using BookProject.Repositories.Interfaces;
using BookProject.Utilities;
using BookProject.Utilities.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookProject.Controllers
{
    [Authorize(Roles = nameof(Roles.Admin))]
    public class BookController : Controller
    {
		private readonly IBookRepository _bookRepo;
		private readonly IGenreRepository _genreRepo;
		private readonly IFileService _fileService;
		private readonly IWebHostEnvironment _environment;
		public BookController(IBookRepository bookRepo, IGenreRepository genreRepo, IFileService fileService, IWebHostEnvironment environment)
		{
			_bookRepo = bookRepo;
			_genreRepo = genreRepo;
			_fileService = fileService;
			_environment = environment;
		}

		public async Task<IActionResult> Index()
        {
            var books = await _bookRepo.GetBooks();
            return View(books);
        }

        [HttpGet]
        public async Task<IActionResult> AddBook()
        {
            var genreSelectList = (await _genreRepo.GetGenres()).Select(genre => new
             SelectListItem
            {
                Text = genre.GenreName,
                Value = genre.Id.ToString()
            });
            BookDTO bookToAdd = new()
            {
                GenreList = genreSelectList
            };
            return View(bookToAdd);
        }

		[HttpPost]
		public async Task<IActionResult> AddBook(BookDTO bookToAdd)
		{
			var genreSelectList = (await _genreRepo.GetGenres()).Select
				(genre => new SelectListItem
				{
					Text = genre.GenreName,
					Value = genre.Id.ToString()
				});
			bookToAdd.GenreList = genreSelectList;

			if (!ModelState.IsValid)
			{
				return View(bookToAdd);
			}

			try
			{
				if (bookToAdd.ImageFile != null)
				{
					if (bookToAdd.ImageFile.Length > 1 * 1024 * 1024)
					{
						throw new InvalidOperationException("Image file can't exceed 1 MB");
					}
					string[] allowedExtensions = { ".jpeg", ".jpg", ".png", ".jfif" };
					string imageName = await _fileService.SaveFile(bookToAdd.ImageFile, allowedExtensions);

					string originalFileName = Path.GetFileNameWithoutExtension(bookToAdd.ImageFile.FileName);
					string extension = Path.GetExtension(bookToAdd.ImageFile.FileName);
					bookToAdd.Image = Path.Combine("images/books", $"resized_{originalFileName}{extension}").Replace("\\", "/");
				}

				Book book = new()
				{
					Id = bookToAdd.Id,
					BookName = bookToAdd.BookName,
					AuthorName = bookToAdd.AuthorName,
					Image = bookToAdd.Image,
					GenreId = bookToAdd.GenreId,
					Price = bookToAdd.Price
				};

				await _bookRepo.AddBook(book);
				TempData["successMessage"] = "Book is added successfully";
				return RedirectToAction(nameof(AddBook));
			}
			catch (InvalidOperationException ex)
			{
				TempData["errorMessage"] = ex.Message;
			    return View(bookToAdd);
			}
			catch (FileNotFoundException ex)
			{
				TempData["errorMessage"] = ex.Message;
				return View(bookToAdd);
			}
			catch (Exception ex)
			{
				TempData["errorMessage"] = "Error on saving data";
				return View(bookToAdd);
			}
		}



		[HttpGet]
        public async Task<IActionResult> UpdateBook(int id)
        {
            var book = await _bookRepo.GetBookById(id);
            if (book == null)
            {
                TempData["errorMessage"] = $"Book with the id: {id} is not found";
                return RedirectToAction(nameof(Index));
            }
            var genreSelectLsit = (await _genreRepo.GetGenres()).Select(genre =>
            new SelectListItem
            {
                Text = genre.GenreName,
                Value = genre.Id.ToString(),
                Selected = genre.Id == book.GenreId
            });
            BookDTO bookToUpdate = new()
            {
                GenreList = genreSelectLsit,
                BookName = book.BookName,
                AuthorName = book.AuthorName,
                GenreId = book.GenreId,
                Price = book.Price,
                Image = book.Image
            };
            return View(bookToUpdate);
        }

		[HttpPost]
		public async Task<IActionResult> UpdateBook(BookDTO bookToUpdate)
		{
			var genreSelectList = (await _genreRepo.GetGenres()).Select(genre =>
				new SelectListItem
				{
					Text = genre.GenreName,
					Value = genre.Id.ToString(),
					Selected = genre.Id == bookToUpdate.GenreId
				});
			bookToUpdate.GenreList = genreSelectList;

			if (!ModelState.IsValid)
			{
				return View(bookToUpdate);
			}

			try
			{
				string oldImage = "";
				if (bookToUpdate.ImageFile != null)
				{
					if (bookToUpdate.ImageFile.Length > 1 * 1024 * 1024)
					{
						throw new InvalidOperationException("Image file can't exceed 1 MB");
					}

					string[] allowedExtensions = { ".jpeg", ".jpg", ".png", ".jfif" };
					string extension = Path.GetExtension(bookToUpdate.ImageFile.FileName);
					if (!allowedExtensions.Contains(extension))
					{
						throw new InvalidOperationException($"Only {string.Join(", ", allowedExtensions)} files allowed");
					}
					string tempFilePath = Path.Combine(_environment.WebRootPath, "temp", $"{Guid.NewGuid()}{extension}");
					Directory.CreateDirectory(Path.GetDirectoryName(tempFilePath)); // Ensure the temp directory exists
					using (var stream = new FileStream(tempFilePath, FileMode.Create))
					{
						await bookToUpdate.ImageFile.CopyToAsync(stream);
					}
					string finalFileName = $"{Guid.NewGuid()}{extension}";
					string finalPath = Path.Combine(_environment.WebRootPath, "images/books", finalFileName);
					ImageResizer.ResizeImage(tempFilePath, finalPath, 300, 450);

					System.IO.File.Delete(tempFilePath);

					oldImage = bookToUpdate.Image;
					bookToUpdate.Image = $"images/books/{finalFileName}";
				}

				Book book = new()
				{
					Id = bookToUpdate.Id,
					BookName = bookToUpdate.BookName,
					AuthorName = bookToUpdate.AuthorName,
					GenreId = bookToUpdate.GenreId,
					Price = bookToUpdate.Price,
					Image = bookToUpdate.Image
				};

				await _bookRepo.UpdateBook(book);

				if (!string.IsNullOrWhiteSpace(oldImage))
				{
					_fileService.DeleteFile(oldImage);
				}

				TempData["successMessage"] = "Book is updated successfully";
				return RedirectToAction(nameof(Index));
			}
			catch (InvalidOperationException ex)
			{
				TempData["errorMessage"] = ex.Message;
				return View(bookToUpdate);
			}
			catch (FileNotFoundException ex)
			{
				TempData["errorMessage"] = ex.Message;
				return View(bookToUpdate);
			}
			catch (Exception ex)
			{
				TempData["errorMessage"] = "Error on saving data";
				return View(bookToUpdate);
			}
		}

		public async Task<IActionResult> DeleteBook(int id)
        {
            try
            {
                var book = await _bookRepo.GetBookById(id);
                if (book == null)
                {
                    TempData["errorMessage"] = $"Book with the id: {id} is not found";
                }
                else
                {
                    await _bookRepo.DeleteBook(book);
                    if (!string.IsNullOrWhiteSpace(book.Image))
                    {
                        _fileService.DeleteFile(book.Image);
                    }
                }
            }
			catch (InvalidOperationException ex)
			{
				TempData["errorMessage"] = ex.Message;
			}
			catch (FileNotFoundException ex)
			{
				TempData["errorMessage"] = ex.Message;
			}
			catch (Exception ex)
			{
				TempData["errorMessage"] = "Error on deleting the data";
			}
			return RedirectToAction(nameof(Index));
		}
	}
}
