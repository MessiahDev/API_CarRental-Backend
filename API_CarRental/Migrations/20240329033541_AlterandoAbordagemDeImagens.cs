using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_CarRental.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoAbordagemDeImagens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Vehicles",
                newName: "Imagens");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Imagens",
                table: "Vehicles",
                newName: "Image");
        }
    }
}
