using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class Moredataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DriveWheel",
                table: "CarModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "CarModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "CarModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weigth",
                table: "CarModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "CarModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CarEngine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    Torque = table.Column<int>(type: "int", nullable: false),
                    Displacement = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aspiration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopSpeed = table.Column<int>(type: "int", nullable: false),
                    Acceleration = table.Column<double>(type: "float", nullable: false),
                    Gearbox = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarEngine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarEngine_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarEngine",
                columns: new[] { "Id", "Acceleration", "Aspiration", "CarModelId", "Displacement", "Gearbox", "HorsePower", "TopSpeed", "Torque", "Type" },
                values: new object[,]
                {
                    { 1, 5.2999999999999998, "Naturally aspirated", 1, 4941, "6 gears manual gearbox", 400, 250, 500, "V8" },
                    { 2, 7.7999999999999998, "Turbocharger", 1, 2926, "6 gears manual gearbox", 193, 230, 410, "I6" },
                    { 3, 3.7999999999999998, "Twin-power turbo", 2, 4395, "8 gears automatic gearbox", 530, 250, 750, "I6" },
                    { 4, 7.7999999999999998, "Twin-power turbo", 2, 1998, "8 gears automatic gearbox", 184, 235, 290, "I4" },
                    { 5, 7.2000000000000002, "Turbocharger", 3, 1984, "6 gears manual gearbox", 190, 240, 320, "I4" },
                    { 6, 5.2999999999999998, "Turbocharger", 3, 2967, "8 gears automatic gearbox", 272, 250, 600, "V6" },
                    { 7, 7.7000000000000002, "Naturally aspirated", 4, 2773, "8 gears automatic gearbox", 204, 240, 280, "V6" },
                    { 8, 5.5, "Supercharger", 4, 2995, "7 gears automatic gearbox", 310, 250, 440, "V6" },
                    { 9, 7.2000000000000002, "Naturally aspirated", 5, 3498, "7 gears automatic gearbox", 272, 250, 350, "V6" },
                    { 10, 4.2999999999999998, "BiTurbo", 5, 5461, "7 gears automatic gearbox", 525, 250, 700, "V8" },
                    { 11, 6.5, "Turbocharger", 6, 2987, "9 gears automatic gearbox", 258, 250, 620, "V6" },
                    { 12, 4.2999999999999998, "BiTurbo", 6, 5461, "7 gears automatic gearbox", 525, 250, 700, "V8" },
                    { 13, 3.2000000000000002, "Naturally aspirated", 7, 3996, "7 gears automatic gearbox", 520, 312, 470, "V6" },
                    { 14, 2.7999999999999998, "Naturally aspirated", 8, 800, "2 gears automatic gearbox", 761, 260, 1050, "Electric" }
                });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DriveWheel", "Height", "Length", "Weigth", "Width" },
                values: new object[] { "Rear wheel drive", 1435, 4775, 1610, 1800 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DriveWheel", "Height", "Length", "Weigth", "Width" },
                values: new object[] { "Rear wheel drive", 1466, 4936, 1540, 1868 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DriveWheel", "Height", "Length", "Weigth", "Width" },
                values: new object[] { "All wheel drive", 1427, 4726, 1510, 1842 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DriveWheel", "Height", "Length", "Weigth", "Width" },
                values: new object[] { "Front wheel drive", 1468, 4915, 1625, 1874 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DriveWheel", "Height", "Length", "Weigth", "Width" },
                values: new object[] { "Rear wheel drive", 1470, 4868, 1730, 1854 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DriveWheel", "Height", "Length", "Weigth", "Width" },
                values: new object[] { "All wheel drive", 1496, 5116, 1975, 1899 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DriveWheel", "Height", "Length", "Weigth", "Width" },
                values: new object[] { "Rear wheel drive", 1297, 4557, 1430, 1880 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DriveWheel", "Height", "Length", "Weigth", "Width" },
                values: new object[] { "All wheel drive", 1381, 4963, 2305, 1966 });

            migrationBuilder.CreateIndex(
                name: "IX_CarEngine_CarModelId",
                table: "CarEngine",
                column: "CarModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
