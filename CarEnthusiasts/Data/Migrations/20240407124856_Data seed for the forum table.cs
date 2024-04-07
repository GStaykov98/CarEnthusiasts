using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarEnthusiasts.Data.Migrations
{
    public partial class Dataseedfortheforumtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForumTopics",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "FollowerCounter", "LikeCounter", "Text", "Title", "TopicType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 7, 15, 48, 56, 402, DateTimeKind.Local).AddTicks(2121), "5ac561d9-127e-4017-8e82-19372d14c26a", 0, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur in est massa. Praesent id erat quam. Etiam ornare enim non dui venenatis bibendum. Suspendisse iaculis tempus leo, in condimentum urna pulvinar ac. Suspendisse eu nisl nec augue ornare eleifend. Nam vulputate tincidunt elit, non egestas ante laoreet nec. Cras ultricies urna semper purus auctor, eget vulputate erat dapibus. Aliquam a blandit mi. Morbi vitae suscipit augue. Aliquam non scelerisque leo, at laoreet purus. Donec mi mauris, ullamcorper sit amet nunc et, molestie mollis purus. Curabitur convallis tristique tellus, quis porttitor ipsum dictum eget.\r\n\r\nNam imperdiet eu ipsum et aliquam. Suspendisse eleifend congue consectetur. Suspendisse potenti. Nunc nec condimentum ligula. Morbi metus nulla, viverra eget laoreet at, tempor id diam. Nunc nibh justo, tristique vitae luctus in, sodales vel justo. Ut gravida vel ante et egestas. Fusce feugiat diam non aliquet fringilla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.\r\n\r\nAliquam semper rhoncus rhoncus. Praesent pellentesque arcu eros, in ornare velit bibendum sit amet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Suspendisse potenti. Sed quis ante enim. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam accumsan ac libero quis tristique. Maecenas rhoncus finibus odio a finibus.", "BMW 5 Series E39 common problems", 1 },
                    { 2, new DateTime(2024, 4, 2, 15, 48, 56, 402, DateTimeKind.Local).AddTicks(2124), "5ac561d9-127e-4017-8e82-19372d14c26a", 0, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur in est massa. Praesent id erat quam. Etiam ornare enim non dui venenatis bibendum. Suspendisse iaculis tempus leo, in condimentum urna pulvinar ac. Suspendisse eu nisl nec augue ornare eleifend. Nam vulputate tincidunt elit, non egestas ante laoreet nec. Cras ultricies urna semper purus auctor, eget vulputate erat dapibus. Aliquam a blandit mi. Morbi vitae suscipit augue. Aliquam non scelerisque leo, at laoreet purus. Donec mi mauris, ullamcorper sit amet nunc et, molestie mollis purus. Curabitur convallis tristique tellus, quis porttitor ipsum dictum eget.\r\n\r\nNam imperdiet eu ipsum et aliquam. Suspendisse eleifend congue consectetur. Suspendisse potenti. Nunc nec condimentum ligula. Morbi metus nulla, viverra eget laoreet at, tempor id diam. Nunc nibh justo, tristique vitae luctus in, sodales vel justo. Ut gravida vel ante et egestas. Fusce feugiat diam non aliquet fringilla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.\r\n\r\nAliquam semper rhoncus rhoncus. Praesent pellentesque arcu eros, in ornare velit bibendum sit amet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Suspendisse potenti. Sed quis ante enim. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam accumsan ac libero quis tristique. Maecenas rhoncus finibus odio a finibus.", "General talk about cars", 0 },
                    { 3, new DateTime(2024, 4, 7, 15, 48, 56, 402, DateTimeKind.Local).AddTicks(2126), "5ac561d9-127e-4017-8e82-19372d14c26a", 0, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur in est massa. Praesent id erat quam. Etiam ornare enim non dui venenatis bibendum. Suspendisse iaculis tempus leo, in condimentum urna pulvinar ac. Suspendisse eu nisl nec augue ornare eleifend. Nam vulputate tincidunt elit, non egestas ante laoreet nec. Cras ultricies urna semper purus auctor, eget vulputate erat dapibus. Aliquam a blandit mi. Morbi vitae suscipit augue. Aliquam non scelerisque leo, at laoreet purus. Donec mi mauris, ullamcorper sit amet nunc et, molestie mollis purus. Curabitur convallis tristique tellus, quis porttitor ipsum dictum eget.\r\n\r\nNam imperdiet eu ipsum et aliquam. Suspendisse eleifend congue consectetur. Suspendisse potenti. Nunc nec condimentum ligula. Morbi metus nulla, viverra eget laoreet at, tempor id diam. Nunc nibh justo, tristique vitae luctus in, sodales vel justo. Ut gravida vel ante et egestas. Fusce feugiat diam non aliquet fringilla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.\r\n\r\nAliquam semper rhoncus rhoncus. Praesent pellentesque arcu eros, in ornare velit bibendum sit amet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Suspendisse potenti. Sed quis ante enim. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam accumsan ac libero quis tristique. Maecenas rhoncus finibus odio a finibus.", "BMW 7 Series E65 car meet", 3 },
                    { 4, new DateTime(2024, 4, 4, 15, 48, 56, 402, DateTimeKind.Local).AddTicks(2128), "5ac561d9-127e-4017-8e82-19372d14c26a", 0, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur in est massa. Praesent id erat quam. Etiam ornare enim non dui venenatis bibendum. Suspendisse iaculis tempus leo, in condimentum urna pulvinar ac. Suspendisse eu nisl nec augue ornare eleifend. Nam vulputate tincidunt elit, non egestas ante laoreet nec. Cras ultricies urna semper purus auctor, eget vulputate erat dapibus. Aliquam a blandit mi. Morbi vitae suscipit augue. Aliquam non scelerisque leo, at laoreet purus. Donec mi mauris, ullamcorper sit amet nunc et, molestie mollis purus. Curabitur convallis tristique tellus, quis porttitor ipsum dictum eget.\r\n\r\nNam imperdiet eu ipsum et aliquam. Suspendisse eleifend congue consectetur. Suspendisse potenti. Nunc nec condimentum ligula. Morbi metus nulla, viverra eget laoreet at, tempor id diam. Nunc nibh justo, tristique vitae luctus in, sodales vel justo. Ut gravida vel ante et egestas. Fusce feugiat diam non aliquet fringilla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.\r\n\r\nAliquam semper rhoncus rhoncus. Praesent pellentesque arcu eros, in ornare velit bibendum sit amet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Suspendisse potenti. Sed quis ante enim. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam accumsan ac libero quis tristique. Maecenas rhoncus finibus odio a finibus.", "I have a question about the engine of the new S-Class", 2 }
                });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 7, 15, 48, 56, 402, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 6, 15, 48, 56, 402, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 5, 15, 48, 56, 402, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 7, 15, 48, 56, 402, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 5, 15, 48, 56, 402, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 15, 48, 56, 402, DateTimeKind.Local).AddTicks(2106));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
