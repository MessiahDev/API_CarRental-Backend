using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_CarRental.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagens",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "Group");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Vehicles",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Group",
                table: "Categories",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Imagens",
                table: "Vehicles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
