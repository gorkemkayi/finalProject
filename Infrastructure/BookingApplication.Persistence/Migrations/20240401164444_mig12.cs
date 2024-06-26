﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingApplication.Persistence.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RoomImage",
                table: "HotelRooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomImage",
                table: "HotelRooms");
        }
    }
}
