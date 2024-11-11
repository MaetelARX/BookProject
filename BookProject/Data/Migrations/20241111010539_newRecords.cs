using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class newRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorName", "BookName", "GenreId", "Image", "Price" },
                values: new object[,]
                {
                    { 10, "Иван Вазов", "Под Игото", 5, "/images/books/resized_under_the_yoke.jpg", 21.989999999999998 },
                    { 11, "Джордж Р. Р. Мартин", "Песен за огън и лед", 6, "/images/books/resized_song_of_ice_and_water.jpg", 39.990000000000002 },
                    { 12, "Кентаро Миура", "Берсерк", 6, "/images/books/resized_berserk.jpg", 109.98999999999999 },
                    { 13, "Такехико Иноуе", "Вагабонд", 5, "/images/books/resized_vagabond.png", 59.990000000000002 },
                    { 14, "Макото Юкимура", "Винланд Сага", 1, "/images/books/resized_vinland_saga.jpg", 19.989999999999998 },
                    { 15, "Ребека Яроз", "Железен Пламък", 1, "/images/books/resized_iron_flame.jpg", 33.0 },
                    { 16, "Стивън Кинг", "То", 2, "/images/books/resized_it.jpg", 19.989999999999998 },
                    { 17, "Робърт Грийн", "33-те стратегии за войната", 1, "/images/books/resized_33_strategies_of_war.jpg", 33.0 },
                    { 18, "Фьодор Достоевски", "Идиот", 5, "/images/books/resized_idiot.jpg", 59.990000000000002 },
                    { 19, "Фьодор Достоевски", "Престъпление и наказание", 5, "/images/books/resized_crime_and_punishment.jpg", 30.0 },
                    { 20, "Алескандър Пушкин", "Евгений Онегин", 5, "/images/books/resized_eugene_onegin.jpg", 50.0 },
                    { 21, "Виктор Юго", "Клетниците", 5, "/images/books/resized_the_wretch.jpg", 30.0 },
                    { 22, "Христо Ботев", "Борба", 7, "/images/books/resized_struggle.jpg", 25.0 },
                    { 23, "Христо Ботев", "До моето първо либе", 7, "/images/books/resized_to_my_first_love.jpg", 21.989999999999998 },
                    { 24, "Димитър Димов", "Тютюн", 1, "/images/books/resized_tobacco.jpg", 40.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);
        }
    }
}
