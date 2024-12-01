using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRegistryApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddNutritionValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Carbohydrates",
                table: "Foods",
                newName: "Fiber");

            migrationBuilder.AddColumn<int>(
                name: "Carbs",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Carbs",
                table: "Foods");

            migrationBuilder.RenameColumn(
                name: "Fiber",
                table: "Foods",
                newName: "Carbohydrates");
        }
    }
}
