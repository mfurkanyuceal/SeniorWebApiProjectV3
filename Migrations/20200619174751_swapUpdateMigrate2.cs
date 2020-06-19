using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeniorWebAPIProjectV3.Migrations
{
    public partial class swapUpdateMigrate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "SwapTime",
                table: "Swaps",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<long>(
                name: "SwapRate",
                table: "Swaps",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "SendTime",
                table: "Swaps",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "AcceptTime",
                table: "Swaps",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SwapTime",
                table: "Swaps",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<int>(
                name: "SwapRate",
                table: "Swaps",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SendTime",
                table: "Swaps",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AcceptTime",
                table: "Swaps",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset));
        }
    }
}
