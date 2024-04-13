using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class Forumtopiclikesrelationshipadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForumTopicsLikes",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ForumTopicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTopicsLikes", x => new { x.UserId, x.ForumTopicId });
                    table.ForeignKey(
                        name: "FK_ForumTopicsLikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ForumTopicsLikes_ForumTopics_ForumTopicId",
                        column: x => x.ForumTopicId,
                        principalTable: "ForumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 19, 33, 42, 160, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 19, 33, 42, 160, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 19, 33, 42, 160, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 19, 33, 42, 160, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 19, 33, 42, 160, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 12, 19, 33, 42, 160, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 19, 33, 42, 160, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 19, 33, 42, 160, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 19, 33, 42, 160, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 9, 19, 33, 42, 160, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopicsLikes_ForumTopicId",
                table: "ForumTopicsLikes",
                column: "ForumTopicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
