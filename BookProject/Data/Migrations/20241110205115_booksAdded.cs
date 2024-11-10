using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class booksAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorName", "BookName", "GenreId", "Image", "Price" },
                values: new object[,]
                {
                    { 1, "Лев Толстой", "Война и Мир", 3, "/images/books/resized_war_and_peace.jpeg", 20.5 },
                    { 2, "Лев Толстой", "Ана Каренина", 3, "/images/books/resized_anna_karenina.jpg", 18.0 },
                    { 3, "Николо Макиавели", "Владетелят", 1, "/images/books/resized_the_prince.jpg", 15.0 },
                    { 4, "Иван Вазов", "Нова земя", 3, "/images/books/resized_new_earth.jpg", 12.5 },
                    { 5, "Платон", "Държавата", 4, "/images/books/resized_the_republic.jpg", 14.0 },
                    { 6, "Йохан Волфганг Гьоте", "Фауст", 3, "/images/books/resized_faust.jpg", 16.0 },
                    { 7, "Фридрих Ницше", "Воля за власт", 4, "/images/books/resized_will_to_power.jpg", 17.5 },
                    { 8, "Пол Кенеди", "Защо светът е такъв какъвто е", 4, "/images/books/resized_why_world_is.jpg", 22.0 },
                    { 9, "Робърт Грийн", "48-те закона на властта", 1, "/images/books/resized_48_laws_of_power.jpg", 19.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
