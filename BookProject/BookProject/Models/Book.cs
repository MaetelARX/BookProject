using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;

namespace BookProject.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? BookName { get; set; }
        public double Price { get; set; }
        public string? Image {  get; set; }
        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
        public List<CartDetail> CartDetail { get; set; }
    }
}
