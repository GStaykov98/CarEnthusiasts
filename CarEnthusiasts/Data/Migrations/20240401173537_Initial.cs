using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductionStartYear = table.Column<int>(type: "int", nullable: false),
                    ProductionEndYear = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarModels_CarBrands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "CarBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "https://upload.wikimedia.org/wikipedia/commons/a/ae/Logo_audi.jpg", "Audi" },
                    { 2, "https://upload.wikimedia.org/wikipedia/commons/e/ea/BMW_logo_%28white_%2B_grey_background_square%29.svg", "BMW" },
                    { 3, "https://upload.wikimedia.org/wikipedia/commons/e/e6/Mercedes-Benz_logo_2.svg", "Mercedes-Benz" },
                    { 4, "https://upload.wikimedia.org/wikipedia/commons/4/44/Porsche_hood_emblem.png", "Porsche" }
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "BrandId", "ImageUrl", "Name", "ProductionEndYear", "ProductionStartYear" },
                values: new object[,]
                {
                    { 1, 2, "https://upload.wikimedia.org/wikipedia/commons/9/9e/BMW_M5_E39_%28Blue%29.jpg", "5 Series (E39)", 2003, 1996 },
                    { 2, 2, "https://upload.wikimedia.org/wikipedia/commons/a/a7/BMW_5_SERIES_%28G30%29_HONG_KONG.jpg", "5 Series (G30)", 2023, 2017 },
                    { 3, 1, "https://upload.wikimedia.org/wikipedia/commons/8/80/AUDI_A4L_%28B9%29_China_%2812%29.jpg", "A4 (B9)", 2024, 2015 },
                    { 4, 1, "https://upload.wikimedia.org/wikipedia/commons/e/e4/AUDI_A6L_C7_China_%2832%29.jpg", "A6 (C7)", 2018, 2011 },
                    { 5, 3, "https://upload.wikimedia.org/wikipedia/commons/a/ae/MERCEDES-BENZ_E-CLASS_SEDAN_%28W212%29_China.jpg", "E-Class (W212)", 2016, 2009 },
                    { 6, 3, "https://upload.wikimedia.org/wikipedia/commons/5/50/MERCEDES-BENZ_S-CLASS_%28W222%29_China_%2823%29.jpg", "S-Class (W222)", 2020, 2013 },
                    { 7, 4, "https://upload.wikimedia.org/wikipedia/commons/6/67/2016_Porsche_911_GT3_RS_Grey_FOS22.jpg", "911 GT3 RS", 2020, 2011 },
                    { 8, 4, "https://upload.wikimedia.org/wikipedia/commons/e/e2/PORSCHE_TAYCAN_China_%289%29.jpg", "Taycan", 2024, 2020 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_BrandId",
                table: "CarModels",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "CarBrands");
        }
    }
}
