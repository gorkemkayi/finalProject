using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingApplication.Persistence.Migrations
{
    public partial class mig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HotelID",
                table: "HotelReservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservations_HotelID",
                table: "HotelReservations",
                column: "HotelID");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReservations_Hotels_HotelID",
                table: "HotelReservations",
                column: "HotelID",
                principalTable: "Hotels",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelReservations_Hotels_HotelID",
                table: "HotelReservations");

            migrationBuilder.DropIndex(
                name: "IX_HotelReservations_HotelID",
                table: "HotelReservations");

            migrationBuilder.DropColumn(
                name: "HotelID",
                table: "HotelReservations");
        }
    }
}
