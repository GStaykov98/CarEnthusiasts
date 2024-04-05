using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class ForumTopictableandmanytomanyrelationshiptablesadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ForumId",
                table: "Comments",
                newName: "ForumTopicId");

            migrationBuilder.CreateTable(
                name: "ForumTopic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LikeCounter = table.Column<int>(type: "int", nullable: false),
                    FollowerCounter = table.Column<int>(type: "int", nullable: false),
                    TopicType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTopic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumTopic_AspNetUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForumTopicFollower",
                columns: table => new
                {
                    FollowerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ForumTopicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTopicFollower", x => new { x.FollowerId, x.ForumTopicId });
                    table.ForeignKey(
                        name: "FK_ForumTopicFollower_AspNetUsers_FollowerId",
                        column: x => x.FollowerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ForumTopicFollower_ForumTopic_ForumTopicId",
                        column: x => x.ForumTopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 5, 19, 17, 18, 12, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 4, 19, 17, 18, 12, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 19, 17, 18, 12, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 5, 19, 17, 18, 12, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 19, 17, 18, 12, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 1, 19, 17, 18, 12, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ForumTopicId",
                table: "Comments",
                column: "ForumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_CreatorId",
                table: "ForumTopic",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopicFollower_ForumTopicId",
                table: "ForumTopicFollower",
                column: "ForumTopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ForumTopic_ForumTopicId",
                table: "Comments",
                column: "ForumTopicId",
                principalTable: "ForumTopic",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
