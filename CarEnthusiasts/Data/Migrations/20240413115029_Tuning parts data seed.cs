using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class Tuningpartsdataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 14, 50, 28, 994, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 14, 50, 28, 994, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 14, 50, 28, 994, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "ForumTopics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 14, 50, 28, 994, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 14, 50, 28, 994, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 12, 14, 50, 28, 994, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 14, 50, 28, 994, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 14, 50, 28, 994, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 14, 50, 28, 994, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 9, 14, 50, 28, 994, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.InsertData(
                table: "TuningParts",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa.", "https://m.media-amazon.com/images/I/71x5FmPr53L.jpg", "2 Pieces Universal Racing Seats,With Dual Lock Sliders", 249.99000000000001, 5 },
                    { 2, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa.", "https://www.outcastgarage.com/cdn/shop/products/BRR1R-BKRP_1_1800x1800.jpg?v=1540248523", "BRAUM Racing Elite-R Series Racing Seats", 135.5, 2 },
                    { 3, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa.", "https://cdn.autostyle.co.za/wp-content/uploads/2022/06/28183552/X1-022CA.jpg", "Type-R Sports Steering Wheel (Black & Carbon Fibre Design)", 59.850000000000001, 10 },
                    { 4, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa.", "https://www.kmpdrivetrain.com/wp-content/uploads/2020/04/4SW-01-600x600.png", "KMP E-sport racing wheel", 74.290000000000006, 3 },
                    { 5, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa.", "https://www.motortrend.com/uploads/2021/10/rocket-bunny-gr86-complete-aero-kit-copy.png", "Rocket bunny kit", 849.99000000000001, 7 },
                    { 6, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa.", "https://i.ytimg.com/vi/LkHUeJROh7M/maxresdefault.jpg", "Porsche 911 GT3 wide body kit", 1250.0, 6 },
                    { 7, 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa.", "https://titanmotorsports.com/cdn/shop/products/FRB586PortTopMountKit-1.jpg?v=1655318711", "Single turbo universal kit", 1249.99, 8 },
                    { 8, 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa.", "https://cdn.shopify.com/s/files/1/0055/2098/2086/products/TurboKitMain_1000x.jpg?v=1651772131", "Twin turbo universal kit", 1789.0, 6 },
                    { 9, 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa.", "https://i5.walmartimages.com/asr/8d2e309d-a02c-4ce8-8792-e21ff8193728.65fff7edfb470d3f39bdcd0968ed110f.jpeg?odnHeight=612&odnWidth=612&odnBg=FFFFFF", "Tbest Rear Spoiler", 283.0, 23 },
                    { 10, 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa.", "https://www.swapshopracing.com/contents/media/l_carb-a690-nrg-05-.jpg", "NRG Universal 69\" Black Real Carbon Fiber Spoiler", 129.0, 54 },
                    { 11, 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa.", "https://cdn4.wheelbasealloys.com/product-images/product-219413_108741_600.jpg", "Vossen CVT Graphite 20\" Alloy Wheels", 449.23000000000002, 23 },
                    { 12, 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa.", "https://audiocityusa.com/shop/images/P/0-forgiato-forged-wheels-forgiato-blocco-gloss-black-with-mango-orange-accents-rims-audiocityusa-01-04.jpg", "21\" Forgiato Wheels Blocco Gloss Black", 549.88999999999999, 43 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
