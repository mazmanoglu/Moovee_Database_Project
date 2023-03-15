using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Moovee_2.Data.Migrations
{
    public partial class added_new_movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DateRelease", "Description", "Genre", "ImageUrl", "ImdbUrl", "Length", "MainActress", "Title" },
                values: new object[] { 5, new DateTime(1972, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.", "Crime / Drama", "godfather.jpg", "https://www.imdb.com/title/tt0068646/", 175, "Simonetta Stefanelli", "The Godfather" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "TvShowId",
                keyValue: 1,
                columns: new[] { "DateRelease", "Description", "ImageUrl", "ImdbUrl", "MainActress" },
                values: new object[] { new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.", "gameofthrones.jpg", "https://www.imdb.com/title/tt0944947/", "Emilia Clarke" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "TvShowId",
                keyValue: 3,
                columns: new[] { "DateRelease", "Description", "ImageUrl", "ImdbUrl", "Length", "MainActress" },
                values: new object[] { new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.", "breakingbad.jpg", "https://www.imdb.com/title/tt0903747/", 62, "Anna Gunn" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "TvShowId",
                keyValue: 4,
                columns: new[] { "DateRelease", "Description", "ImageUrl", "ImdbUrl", "Length", "MainActress" },
                values: new object[] { new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Epic drama set thousands of years before the events of J.R.R. Tolkien's 'The Hobbit' and 'The Lord of the Rings' follows an ensemble cast of characters, both familiar and new, as they confront the long-feared re-emergence of evil to Middle-earth.", "ringsofpower.jpg", "https://www.imdb.com/title/tt7631058/", 10, "Morfydd Clark" });

            migrationBuilder.InsertData(
                table: "TvShows",
                columns: new[] { "TvShowId", "DateRelease", "Description", "Genre", "ImageUrl", "ImdbUrl", "Length", "MainActress", "Title" },
                values: new object[,]
                {
                    { 5, new DateTime(2001, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The story of Easy Company of the U.S. Army 101st Airborne Division and their mission in World War II Europe, from Operation Overlord to V-J Day.", "Drama / History / War", "bandofbrothers.jpg", "https://www.imdb.com/title/tt0185906/", 10, "----", "Band of Brothers" },
                    { 6, new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.", "Drama / History / Thriller", "chernobyl.jpg", "https://www.imdb.com/title/tt7366338/", 5, "Jessie Buckley", "Chernobyl" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TvShows",
                keyColumn: "TvShowId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TvShows",
                keyColumn: "TvShowId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "TvShowId",
                keyValue: 1,
                columns: new[] { "DateRelease", "Description", "ImageUrl", "ImdbUrl", "MainActress" },
                values: new object[] { new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A", "Titanic.jpg", "https://www.imdb.com/title/tt0120338/", "Emily" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "TvShowId",
                keyValue: 3,
                columns: new[] { "DateRelease", "Description", "ImageUrl", "ImdbUrl", "Length", "MainActress" },
                values: new object[] { new DateTime(2013, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "After", "StarTrek.jpg", "https://www.imdb.com/title/tt1408101/", 135, "so its" });

            migrationBuilder.UpdateData(
                table: "TvShows",
                keyColumn: "TvShowId",
                keyValue: 4,
                columns: new[] { "DateRelease", "Description", "ImageUrl", "ImdbUrl", "Length", "MainActress" },
                values: new object[] { new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "As students.", "topgun.jpg", "https://www.imdb.com/title/tt0092099/", 110, "----" });
        }
    }
}
