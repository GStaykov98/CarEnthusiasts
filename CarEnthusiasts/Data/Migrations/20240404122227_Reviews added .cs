using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class Reviewsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Review_ReviewId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Reviews_ReviewId",
                table: "Comments",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Reviews_ReviewId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Review_ReviewId",
                table: "Comments",
                column: "ReviewId",
                principalTable: "Review",
                principalColumn: "Id");
        }
    }
}
