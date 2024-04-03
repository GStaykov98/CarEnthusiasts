using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class Nameaddedfortheenginemodelandseededdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CarEngine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "CarEngine",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "M5");

            migrationBuilder.UpdateData(
                table: "CarEngine",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "530D");

            migrationBuilder.UpdateData(
                table: "CarEngine",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "M550i");

            migrationBuilder.UpdateData(
                table: "CarEngine",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "520i");

            migrationBuilder.UpdateData(
                table: "CarEngine",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "2.0 TFSI Ultra");

            migrationBuilder.UpdateData(
                table: "CarEngine",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "3.0 TDI");

            migrationBuilder.UpdateData(
                table: "CarEngine",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "3.0 TDI");

            migrationBuilder.UpdateData(
                table: "CarEngine",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "3.0 TFSI");

            migrationBuilder.UpdateData(
                table: "CarEngine",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "E 350");

            migrationBuilder.UpdateData(
                table: "CarEngine",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "AMG E 63 V8 BiTurbo");

            migrationBuilder.UpdateData(
                table: "CarEngine",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "S 350d");

            migrationBuilder.UpdateData(
                table: "CarEngine",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "AMG S 63 V8 BiTurbo");

            migrationBuilder.UpdateData(
                table: "CarEngine",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "GT3 RS 4.0");

            migrationBuilder.UpdateData(
                table: "CarEngine",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Turbo S 93.4 kWh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
