using Microsoft.EntityFrameworkCore.Migrations;

namespace MyHotel.Data.Migrations
{
    public partial class SeedRoomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Facilities", "Price", "RoomNumber", "Status" },
                values: new object[,]
                {
                    { 1, 2, "bathroom", 50, 101, "available" },
                    { 2, 2, "bathroom", 50, 102, "available" },
                    { 3, 1, "clean bathroom", 100, 103, "unavailable" },
                    { 4, 1, "big TV", 125, 104, "available" },
                    { 5, 2, "WIFI", 150, 105, "unavailable" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
