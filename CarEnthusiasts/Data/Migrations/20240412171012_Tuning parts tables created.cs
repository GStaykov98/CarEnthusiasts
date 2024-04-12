using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class Tuningpartstablescreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TuningPartCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuningPartCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TuningParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuningParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TuningParts_TuningPartCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TuningPartCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TuningPartsCarModels",
                columns: table => new
                {
                    CarModelId = table.Column<int>(type: "int", nullable: false),
                    TuningPartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuningPartsCarModels", x => new { x.TuningPartId, x.CarModelId });
                    table.ForeignKey(
                        name: "FK_TuningPartsCarModels_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TuningPartsCarModels_TuningParts_TuningPartId",
                        column: x => x.TuningPartId,
                        principalTable: "TuningParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 12, 20, 10, 11, 607, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 7, 20, 10, 11, 607, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 12, 20, 10, 11, 607, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 9, 20, 10, 11, 607, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 12, 20, 10, 11, 607, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 20, 10, 11, 607, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 20, 10, 11, 607, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 12, 20, 10, 11, 607, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 20, 10, 11, 607, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 20, 10, 11, 607, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.CreateIndex(
                name: "IX_TuningParts_CategoryId",
                table: "TuningParts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TuningPartsCarModels_CarModelId",
                table: "TuningPartsCarModels",
                column: "CarModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
