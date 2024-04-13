using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingApplication.Persistence.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelReservations_HotelRooms_HotelRoomID",
                table: "HotelReservations");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "HotelRooms",
                newName: "HotelRoomID");

            migrationBuilder.RenameColumn(
                name: "HotelRoomID",
                table: "HotelReservations",
                newName: "HotelRoomId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelReservations_HotelRoomID",
                table: "HotelReservations",
                newName: "IX_HotelReservations_HotelRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReservations_HotelRooms_HotelRoomId",
                table: "HotelReservations",
                column: "HotelRoomId",
                principalTable: "HotelRooms",
                principalColumn: "HotelRoomID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelReservations_HotelRooms_HotelRoomId",
                table: "HotelReservations");

            migrationBuilder.RenameColumn(
                name: "HotelRoomID",
                table: "HotelRooms",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "HotelRoomId",
                table: "HotelReservations",
                newName: "HotelRoomID");

            migrationBuilder.RenameIndex(
                name: "IX_HotelReservations_HotelRoomId",
                table: "HotelReservations",
                newName: "IX_HotelReservations_HotelRoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReservations_HotelRooms_HotelRoomID",
                table: "HotelReservations",
                column: "HotelRoomID",
                principalTable: "HotelRooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
