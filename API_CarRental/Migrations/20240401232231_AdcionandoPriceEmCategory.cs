using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_CarRental.Migrations
{
    /// <inheritdoc />
    public partial class AdcionandoPriceEmCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Categories",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Categories",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Categories");
        }
    }
}
