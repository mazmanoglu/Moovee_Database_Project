using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Moovee_2.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Length = table.Column<int>(nullable: false),
                    DateRelease = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    MainActress = table.Column<string>(maxLength: 50, nullable: true),
                    ImdbUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "TvShows",
                columns: table => new
                {
                    TvShowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Length = table.Column<int>(nullable: false),
                    DateRelease = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    MainActress = table.Column<string>(maxLength: 50, nullable: true),
                    ImdbUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShows", x => x.TvShowId);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DateRelease", "Description", "Genre", "ImageUrl", "ImdbUrl", "Length", "MainActress", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", "Romance", "Titanic.jpg", "https://www.imdb.com/title/tt0120338/", 125, "Kate Winslet", "Titanic" },
                    { 2, new DateTime(2009, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", "Action", "InBasterds.jpg", "https://www.imdb.com/title/tt0361748/", 105, "Diane Kruger", "Inglorious Basterds" },
                    { 3, new DateTime(2013, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", "Sci-Fi", "StarTrek.jpg", "https://www.imdb.com/title/tt1408101/", 135, "Zoe Saldana", "Star Trek - Into Darkness" },
                    { 4, new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", "Action-Drama", "topgun.jpg", "https://www.imdb.com/title/tt0092099/", 110, "Kelly McGills", "Top Gun" }
                });

            migrationBuilder.InsertData(
                table: "TvShows",
                columns: new[] { "TvShowId", "DateRelease", "Description", "Genre", "ImageUrl", "ImdbUrl", "Length", "MainActress", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A", "Action / Fantasy", "Titanic.jpg", "https://www.imdb.com/title/tt0120338/", 140, "Emily", "Game of Thrones" },
                    { 3, new DateTime(2013, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "After", "Science", "StarTrek.jpg", "https://www.imdb.com/title/tt1408101/", 135, "so its", "Breaking Bad" },
                    { 4, new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "As students.", "Sci-Fi / Fantasy", "topgun.jpg", "https://www.imdb.com/title/tt0092099/", 110, "----", "Lord of the Rings - Rings Power" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "TvShows");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
