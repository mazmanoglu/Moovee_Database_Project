using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Moovee_2.Data.Migrations
{
    public partial class newmovie6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DateRelease", "Description", "Genre", "ImageUrl", "ImdbUrl", "Length", "MainActress", "Title" },
                values: new object[] { 6, new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "The movie.", "Drama / History", "godfather.jpg", "https://www.imdb.com/title/tt0068646/", 100, "Margot Robbie", "Amsterdam" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);
        }
    }
}
