using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class ChangeIdToGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookCategory",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategory", x => new { x.BookId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_BookCategory_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Bio", "Name" },
                values: new object[,]
                {
                    { new Guid("652685b1-9506-49f0-bc32-96706fc35b19"), "Ancient Greek philosopher, founder of the Academy in Athens, known for works like 'Republic'.", "Plato" },
                    { new Guid("7f0c8abf-ac90-4ea2-95ca-5d95fd885e7d"), "Italian Renaissance diplomat, philosopher, and writer, best known for 'Il Principe'.", "Niccolò Machiavelli" },
                    { new Guid("89ef728b-e992-4900-94aa-fefe045ebdb8"), "German writer and statesman, known for 'Faust'.", "Johann Wolfgang von Goethe" },
                    { new Guid("f1020500-e210-4cde-8e4b-fddd613a06a0"), "Russian writer, author of 'War and Peace' and 'Anna Karenina'.", "Leo Tolstoy" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { new Guid("3cd6294c-3843-46d8-9cdc-9c5bb7d8e3c1"), "Classic Literature" },
                    { new Guid("b30fe510-ddd3-4f3d-8b15-9ba21dfd7723"), "Philosophy" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "Address", "Name" },
                values: new object[,]
                {
                    { new Guid("991b8954-2122-4235-b73f-74fe03f25ad6"), "New York, USA", "Random House" },
                    { new Guid("a027489f-a54c-4ada-8e3e-890141ba528c"), "Cambridge, UK", "Cambridge University Press" },
                    { new Guid("a0747560-c3fd-40c3-b270-91a40ef006c6"), "London, UK", "Penguin Classics" },
                    { new Guid("bf011832-ad9d-4864-b855-55daffc45af3"), "Oxford, UK", "Oxford University Press" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "ISBN", "PublishedDate", "PublisherId", "Title" },
                values: new object[,]
                {
                    { new Guid("3b941931-5d34-4cd6-af85-91a16004a0fd"), new Guid("89ef728b-e992-4900-94aa-fefe045ebdb8"), "9780140449013", new DateTime(1808, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a0747560-c3fd-40c3-b270-91a40ef006c6"), "Faust" },
                    { new Guid("4d0f9ec9-b2d1-4a10-8866-9bdf1b711e86"), new Guid("652685b1-9506-49f0-bc32-96706fc35b19"), "9780521484435", new DateTime(380, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a027489f-a54c-4ada-8e3e-890141ba528c"), "Republic" },
                    { new Guid("61b5f98a-34ce-4810-a2d7-d282dad7ee30"), new Guid("f1020500-e210-4cde-8e4b-fddd613a06a0"), "9780143035008", new DateTime(1877, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a0747560-c3fd-40c3-b270-91a40ef006c6"), "Anna Karenina" },
                    { new Guid("7d1d91e8-c035-4c10-bfb6-26d38c3d16a9"), new Guid("f1020500-e210-4cde-8e4b-fddd613a06a0"), "9780307266934", new DateTime(1869, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("991b8954-2122-4235-b73f-74fe03f25ad6"), "War and Peace" },
                    { new Guid("fbb2e64e-aa90-4d48-8821-1c5e0de05da1"), new Guid("7f0c8abf-ac90-4ea2-95ca-5d95fd885e7d"), "9780199535699", new DateTime(1532, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf011832-ad9d-4864-b855-55daffc45af3"), "Il Principe" }
                });

            migrationBuilder.InsertData(
                table: "BookCategory",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("3b941931-5d34-4cd6-af85-91a16004a0fd"), new Guid("3cd6294c-3843-46d8-9cdc-9c5bb7d8e3c1") },
                    { new Guid("4d0f9ec9-b2d1-4a10-8866-9bdf1b711e86"), new Guid("b30fe510-ddd3-4f3d-8b15-9ba21dfd7723") },
                    { new Guid("61b5f98a-34ce-4810-a2d7-d282dad7ee30"), new Guid("3cd6294c-3843-46d8-9cdc-9c5bb7d8e3c1") },
                    { new Guid("7d1d91e8-c035-4c10-bfb6-26d38c3d16a9"), new Guid("3cd6294c-3843-46d8-9cdc-9c5bb7d8e3c1") },
                    { new Guid("fbb2e64e-aa90-4d48-8821-1c5e0de05da1"), new Guid("b30fe510-ddd3-4f3d-8b15-9ba21dfd7723") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "BookId", "Content", "Rating", "ReviewerName" },
                values: new object[,]
                {
                    { new Guid("262b671c-6d84-453b-af28-af9a65924790"), new Guid("4d0f9ec9-b2d1-4a10-8866-9bdf1b711e86"), "Plato's 'Republic' is a cornerstone of Western philosophy.", 5, "Sophia Demetriou" },
                    { new Guid("5b8dbe3f-5032-4ed6-8b25-7442a2347a03"), new Guid("3b941931-5d34-4cd6-af85-91a16004a0fd"), "Goethe's 'Faust' explores profound existential themes.", 5, "Hans Müller" },
                    { new Guid("7d229e91-73d4-44cc-b058-23fb7a192097"), new Guid("fbb2e64e-aa90-4d48-8821-1c5e0de05da1"), "Machiavelli's 'Il Principe' is still relevant today in political philosophy.", 4, "Lorenzo Rossi" },
                    { new Guid("c29b3117-2b73-4ef7-ab4e-83acfddf0f25"), new Guid("61b5f98a-34ce-4810-a2d7-d282dad7ee30"), "Tolstoy's 'Anna Karenina' is a beautiful tragedy.", 5, "Maria Petrova" },
                    { new Guid("f15e4c38-f5d9-41bf-b9b4-38ef1eaa9516"), new Guid("7d1d91e8-c035-4c10-bfb6-26d38c3d16a9"), "A monumental work, Tolstoy's 'War and Peace' is unparalleled.", 5, "Alexander Ivanov" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCategory_CategoryId",
                table: "BookCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_ISBN",
                table: "Books",
                column: "ISBN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategory");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
