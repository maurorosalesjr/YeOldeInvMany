using Microsoft.EntityFrameworkCore.Migrations;

namespace YeOldeInv.Migrations
{
    public partial class Profit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AquiredBy",
                table: "Items",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstProfit",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SellingPrice",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AquiredBy",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "EstProfit",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SellingPrice",
                table: "Items");
        }
    }
}
