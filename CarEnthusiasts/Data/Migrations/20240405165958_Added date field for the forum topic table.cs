using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class Addeddatefieldfortheforumtopictable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ForumTopic_ForumTopicId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumTopic_AspNetUsers_CreatorId",
                table: "ForumTopic");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumTopicFollower_AspNetUsers_FollowerId",
                table: "ForumTopicFollower");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumTopicFollower_ForumTopic_ForumTopicId",
                table: "ForumTopicFollower");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ForumTopicFollower",
                table: "ForumTopicFollower");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ForumTopic",
                table: "ForumTopic");

            migrationBuilder.RenameTable(
                name: "ForumTopicFollower",
                newName: "ForumTopicsFollowers");

            migrationBuilder.RenameTable(
                name: "ForumTopic",
                newName: "ForumTopics");

            migrationBuilder.RenameIndex(
                name: "IX_ForumTopicFollower_ForumTopicId",
                table: "ForumTopicsFollowers",
                newName: "IX_ForumTopicsFollowers_ForumTopicId");

            migrationBuilder.RenameIndex(
                name: "IX_ForumTopic_CreatorId",
                table: "ForumTopics",
                newName: "IX_ForumTopics_CreatorId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "ForumTopics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForumTopicsFollowers",
                table: "ForumTopicsFollowers",
                columns: new[] { "FollowerId", "ForumTopicId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForumTopics",
                table: "ForumTopics",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 5, 19, 59, 57, 896, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 4, 19, 59, 57, 896, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 19, 59, 57, 896, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 5, 19, 59, 57, 896, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 19, 59, 57, 896, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 1, 19, 59, 57, 896, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ForumTopics_ForumTopicId",
                table: "Comments",
                column: "ForumTopicId",
                principalTable: "ForumTopics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumTopics_AspNetUsers_CreatorId",
                table: "ForumTopics",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumTopicsFollowers_AspNetUsers_FollowerId",
                table: "ForumTopicsFollowers",
                column: "FollowerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumTopicsFollowers_ForumTopics_ForumTopicId",
                table: "ForumTopicsFollowers",
                column: "ForumTopicId",
                principalTable: "ForumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
