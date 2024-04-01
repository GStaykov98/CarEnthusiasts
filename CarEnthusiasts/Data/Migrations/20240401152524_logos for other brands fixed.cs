using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class logosforotherbrandsfixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/e/ea/BMW_logo_%28white_%2B_grey_background_square%29.svg");

            migrationBuilder.UpdateData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/e/e6/Mercedes-Benz_logo_2.svg");

            migrationBuilder.UpdateData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/4/44/Porsche_hood_emblem.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.m.wikipedia.org%2Fwiki%2FFile%3ABMW.svg&psig=AOvVaw0Xw_LM_e8pZUjufNUN4ZEC&ust=1712070180303000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCOC78cikoYUDFQAAAAAdAAAAABAE");

            migrationBuilder.UpdateData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://commons.wikimedia.org/wiki/File:Mercedes_Benz_Logo_11.jpg");

            migrationBuilder.UpdateData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://commons.wikimedia.org/wiki/File:Porsche_hood_emblem.png");
        }
    }
}
