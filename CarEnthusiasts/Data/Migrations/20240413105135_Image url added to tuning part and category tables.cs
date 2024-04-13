using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class Imageurladdedtotuningpartandcategorytables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "TuningParts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "TuningPartCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 13, 51, 34, 585, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 13, 51, 34, 585, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 13, 51, 34, 585, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 13, 51, 34, 585, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 13, 51, 34, 585, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 12, 13, 51, 34, 585, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 13, 51, 34, 585, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 13, 51, 34, 585, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 13, 51, 34, 585, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 9, 13, 51, 34, 585, DateTimeKind.Local).AddTicks(2129));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
