using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class Seedfortuningpartscategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 14, 9, 13, 137, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 14, 9, 13, 137, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 14, 9, 13, 137, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 14, 9, 13, 137, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 14, 9, 13, 137, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 12, 14, 9, 13, 137, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 14, 9, 13, 137, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 14, 9, 13, 137, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 14, 9, 13, 137, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 9, 14, 9, 13, 137, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.InsertData(
                table: "TuningPartCategories",
                columns: new[] { "Id", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "https://ic.carid.com/braum/seats/brr1x-whbs_0.jpg", "Sport seats" },
                    { 2, "https://evilspeed.eu/cdn/shop/products/Sport-Line-Competition-Steering-Wheel---Black-Suede-Black-Spokes-300mm_5587e715-5391-43c3-96eb-eb3f6a60d290.jpg?v=1666288910", "Sport steering wheels" },
                    { 3, "https://image.made-in-china.com/2f0j00WFCleYPIYrpz/High-Quality-M4-Style-Body-Kit-for-BMW-4-Series-F32-F33-F36-420I-428I-Front-Bumper-Rear-Bumper-Side-Skirts-Wing-Spoiler.webp", "Body kits" },
                    { 4, "https://www.turbozentrum.de/media/image/product/173750/lg/turbo-garrett-g40-900.jpg", "Turbo kits" },
                    { 5, "https://m.media-amazon.com/images/I/5151jRy7evL.jpg", "Spoilers" },
                    { 6, "https://realtruck.com/production/fuel-black-red-reaction-wheels-01/6b053c7ab45cb34b2fd8df96b85ab902.jpg", "Rims" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
