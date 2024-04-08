using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_CarRental.Migrations
{
    /// <inheritdoc />
    public partial class ImplementandoCategoryEmReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Reservations",
                newName: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CategoryId",
                table: "Reservations",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Categories_CategoryId",
                table: "Reservations",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Categories_CategoryId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_CategoryId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Reservations",
                newName: "VehicleId");
        }
    }
}
