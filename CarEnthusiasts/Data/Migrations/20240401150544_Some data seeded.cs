using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class Somedataseeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 1, "https://commons.wikimedia.org/wiki/File:Logo_audi.jpg", "Audi" },
                    { 2, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.m.wikipedia.org%2Fwiki%2FFile%3ABMW.svg&psig=AOvVaw0Xw_LM_e8pZUjufNUN4ZEC&ust=1712070180303000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCOC78cikoYUDFQAAAAAdAAAAABAE", "BMW" },
                    { 3, "https://commons.wikimedia.org/wiki/File:Mercedes_Benz_Logo_11.jpg", "Mercedes-Benz" },
                    { 4, "https://commons.wikimedia.org/wiki/File:Porsche_hood_emblem.png", "Porsche" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
