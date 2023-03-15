using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Moovee_2.Data.Migrations
{
    public partial class updatemovie6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "DateRelease", "Description", "ImageUrl", "ImdbUrl" },
                values: new object[] { new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Set in the '30s, it follows three friends who witness a murder, become suspects themselves, and uncover one of the most outrageous plots in American history.", "amsterdam.jpg", "https://www.imdb.com/title/tt10304142/" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "DateRelease", "Description", "ImageUrl", "ImdbUrl" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "The movie.", "godfather.jpg", "https://www.imdb.com/title/tt0068646/" });
        }
    }
}
