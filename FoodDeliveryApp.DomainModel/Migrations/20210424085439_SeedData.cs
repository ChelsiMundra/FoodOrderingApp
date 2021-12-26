using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDeliveryApp.DomainModel.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Follows",
                columns: new[] { "Id", "FollowerId" ,"FollowedById" },
                values: new object[] { 1,2, 2});

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "DeletedAt", "Email_Id", "IsDeletedBy", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { 1, "Ajmer", new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sheetal301@gmail.com", null, "Sheetal", "1233", "User" },
                    { 2, "Jaipur", new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jay01@gmail.com", null, "Jay", "1245", "User" },
                    { 3, "Udaipur", new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mak01@gmail.com", null, "Mayank", "1255", "Restaurant Owner" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "CloseTime", "ContactNumber", "CostForTwo", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "Location", "OpenTime", "Rating", "RestaurantName" },
                values: new object[] { 1, new DateTime(2021, 4, 24, 9, 22, 33, 0, DateTimeKind.Unspecified), "9872312455", 540, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "Ajmer", new DateTime(2021, 4, 24, 2, 25, 33, 0, DateTimeKind.Unspecified), 3f, "Pizza Hut" });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "RestaurantId", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Menu1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "RestaurantId", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 100f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedAt", "IsComment", "IsDeleted", "Likes", "Rating", "RestaurantId", "Review_Content", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, 1, 4f, 1, "Good", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "IsDeleted", "MenuId", "UpdatedAt" },
                values: new object[] { 1, "Dessert", new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "DishName", "Image", "IsDeleted", "Price", "UpdatedAt" },
                values: new object[] { 1, 1, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ice Cream", "Chocolate Ice Cream", null, false, 100f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "DishId", "OrderId", "Price", "Quantity", "Status" },
                values: new object[] { 1, 1, 1, 100f, 1, "Delivered" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
