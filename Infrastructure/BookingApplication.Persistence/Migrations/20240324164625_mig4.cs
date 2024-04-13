using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingApplication.Persistence.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightProcess_Customer_CustomerId",
                table: "FlightProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightProcess_Flights_FlightId",
                table: "FlightProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightReservation_Flights_FlightID",
                table: "FlightReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightReservation",
                table: "FlightReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightProcess",
                table: "FlightProcess");

            migrationBuilder.RenameTable(
                name: "FlightReservation",
                newName: "FlightReservations");

            migrationBuilder.RenameTable(
                name: "FlightProcess",
                newName: "FlightProcesses");

            migrationBuilder.RenameIndex(
                name: "IX_FlightReservation_FlightID",
                table: "FlightReservations",
                newName: "IX_FlightReservations_FlightID");

            migrationBuilder.RenameIndex(
                name: "IX_FlightProcess_FlightId",
                table: "FlightProcesses",
                newName: "IX_FlightProcesses_FlightId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightProcess_CustomerId",
                table: "FlightProcesses",
                newName: "IX_FlightProcesses_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightReservations",
                table: "FlightReservations",
                column: "FlightReservationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightProcesses",
                table: "FlightProcesses",
                column: "FlightProcessID");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightProcesses_Customer_CustomerId",
                table: "FlightProcesses",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightProcesses_Flights_FlightId",
                table: "FlightProcesses",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightReservations_Flights_FlightID",
                table: "FlightReservations",
                column: "FlightID",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightProcesses_Customer_CustomerId",
                table: "FlightProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightProcesses_Flights_FlightId",
                table: "FlightProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightReservations_Flights_FlightID",
                table: "FlightReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightReservations",
                table: "FlightReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightProcesses",
                table: "FlightProcesses");

            migrationBuilder.RenameTable(
                name: "FlightReservations",
                newName: "FlightReservation");

            migrationBuilder.RenameTable(
                name: "FlightProcesses",
                newName: "FlightProcess");

            migrationBuilder.RenameIndex(
                name: "IX_FlightReservations_FlightID",
                table: "FlightReservation",
                newName: "IX_FlightReservation_FlightID");

            migrationBuilder.RenameIndex(
                name: "IX_FlightProcesses_FlightId",
                table: "FlightProcess",
                newName: "IX_FlightProcess_FlightId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightProcesses_CustomerId",
                table: "FlightProcess",
                newName: "IX_FlightProcess_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightReservation",
                table: "FlightReservation",
                column: "FlightReservationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightProcess",
                table: "FlightProcess",
                column: "FlightProcessID");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightProcess_Customer_CustomerId",
                table: "FlightProcess",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightProcess_Flights_FlightId",
                table: "FlightProcess",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightReservation_Flights_FlightID",
                table: "FlightReservation",
                column: "FlightID",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
