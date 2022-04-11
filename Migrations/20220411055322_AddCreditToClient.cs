using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab1DataAnnotations.Migrations
{
    public partial class AddCreditToClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreditExpiryDate",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreditHolderName",
                table: "Clients",
                type: "VARCHAR(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "CreditIsValid",
                table: "Clients",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreditExpiryDate",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CreditHolderName",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CreditIsValid",
                table: "Clients");
        }
    }
}
