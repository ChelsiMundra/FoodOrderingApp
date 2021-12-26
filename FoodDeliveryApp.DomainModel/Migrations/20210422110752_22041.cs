using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDeliveryApp.DomainModel.Migrations
{
    public partial class _22041 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Follows_Categories_CategoryId",
                table: "Follows");

            migrationBuilder.DropIndex(
                name: "IX_Follows_CategoryId",
                table: "Follows");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Follows");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Follows",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Follows_CategoryId",
                table: "Follows",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Follows_Categories_CategoryId",
                table: "Follows",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
