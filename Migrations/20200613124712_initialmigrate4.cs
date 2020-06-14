using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeniorWebAPIProjectV3.Migrations
{
    public partial class initialmigrate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "birthDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "acceptTime",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "sendTime",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "swapTime",
                table: "Swaps");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "birthDate",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "acceptTime",
                table: "Swaps",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "sendTime",
                table: "Swaps",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "swapTime",
                table: "Swaps",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
