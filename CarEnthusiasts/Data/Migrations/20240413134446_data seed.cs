using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TuningPartsCarModels",
                table: "TuningPartsCarModels");

            migrationBuilder.DropIndex(
                name: "IX_TuningPartsCarModels_CarModelId",
                table: "TuningPartsCarModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TuningPartsCarModels",
                table: "TuningPartsCarModels",
                columns: new[] { "CarModelId", "TuningPartId" });

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 16, 44, 46, 170, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 16, 44, 46, 170, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 16, 44, 46, 170, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 16, 44, 46, 170, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 16, 44, 46, 170, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 12, 16, 44, 46, 170, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 16, 44, 46, 170, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 16, 44, 46, 170, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 16, 44, 46, 170, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 9, 16, 44, 46, 170, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.InsertData(
                table: "TuningPartsCarModels",
                columns: new[] { "CarModelId", "TuningPartId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 5 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 11 },
                    { 1, 12 },
                    { 2, 5 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 11 },
                    { 3, 12 },
                    { 4, 5 },
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 12 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "TuningPartsCarModels",
                columns: new[] { "CarModelId", "TuningPartId" },
                values: new object[,]
                {
                    { 5, 7 },
                    { 5, 8 },
                    { 5, 9 },
                    { 5, 11 },
                    { 5, 12 },
                    { 6, 5 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 10 },
                    { 6, 11 },
                    { 6, 12 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 4 },
                    { 7, 6 },
                    { 7, 9 },
                    { 7, 11 },
                    { 7, 12 },
                    { 8, 3 },
                    { 8, 4 },
                    { 8, 10 },
                    { 8, 11 },
                    { 8, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TuningPartsCarModels_TuningPartId",
                table: "TuningPartsCarModels",
                column: "TuningPartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
