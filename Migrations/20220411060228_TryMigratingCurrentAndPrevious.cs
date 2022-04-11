using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab1DataAnnotations.Migrations
{
    public partial class TryMigratingCurrentAndPrevious : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentClientId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreviousClientId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentRoomId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreviousRoomId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CurrentRoomId",
                table: "Clients",
                column: "CurrentRoomId",
                unique: true,
                filter: "[CurrentRoomId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_PreviousRoomId",
                table: "Clients",
                column: "PreviousRoomId",
                unique: true,
                filter: "[PreviousRoomId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Rooms_CurrentRoomId",
                table: "Clients",
                column: "CurrentRoomId",
                principalTable: "Rooms",
                principalColumn: "RoomNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Rooms_PreviousRoomId",
                table: "Clients",
                column: "PreviousRoomId",
                principalTable: "Rooms",
                principalColumn: "RoomNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Rooms_CurrentRoomId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Rooms_PreviousRoomId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_CurrentRoomId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_PreviousRoomId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CurrentClientId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "PreviousClientId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CurrentRoomId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "PreviousRoomId",
                table: "Clients");
        }
    }
}
