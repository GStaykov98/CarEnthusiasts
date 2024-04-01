using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class anotherurlforaudilogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "CarModels",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "CarBrands",
                newName: "ImageUrl");

            migrationBuilder.UpdateData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/a/ae/Logo_audi.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "CarModels",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "CarBrands",
                newName: "ImageURL");

            migrationBuilder.UpdateData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://commons.wikimedia.org/wiki/File:Logo_audi.jpg");
        }
    }
}
