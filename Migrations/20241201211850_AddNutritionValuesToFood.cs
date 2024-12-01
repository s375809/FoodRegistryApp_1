using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRegistryApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddNutritionValuesToFood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Carbohydrates",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fat",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Protein",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sugar",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Carbohydrates",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Fat",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Protein",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Sugar",
                table: "Foods");
        }
    }
}
