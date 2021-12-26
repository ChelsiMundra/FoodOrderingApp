using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDeliveryApp.DomainModel.Migrations
{
    public partial class DishCrud_initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2021, 4, 29, 9, 22, 33, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 29, 2, 25, 33, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2021, 4, 28, 9, 22, 33, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 28, 2, 25, 33, 0, DateTimeKind.Unspecified) });
        }
    }
}
