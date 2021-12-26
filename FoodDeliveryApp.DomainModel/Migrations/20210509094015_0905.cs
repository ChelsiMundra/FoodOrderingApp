using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDeliveryApp.DomainModel.Migrations
{
    public partial class _0905 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Users_DeletedBy",
                table: "Restaurants");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Restaurants",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2021, 5, 9, 9, 22, 33, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 9, 2, 25, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Users_DeletedBy",
                table: "Restaurants",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Users_DeletedBy",
                table: "Restaurants");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Restaurants",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2021, 4, 29, 9, 22, 33, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 29, 2, 25, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Users_DeletedBy",
                table: "Restaurants",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
