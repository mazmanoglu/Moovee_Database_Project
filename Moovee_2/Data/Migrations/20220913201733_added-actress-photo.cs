using Microsoft.EntityFrameworkCore.Migrations;

namespace Moovee_2.Data.Migrations
{
    public partial class addedactressphoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActressImage",
                table: "Movies",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "ActressImage",
                value: "katewinslet.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActressImage",
                table: "Movies");
        }
    }
}
