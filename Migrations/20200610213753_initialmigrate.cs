using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SeniorWebAPIProjectV3.Migrations
{
    public partial class initialmigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    latitude = table.Column<double>(nullable: false),
                    longitude = table.Column<double>(nullable: false),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Swaps",
                columns: table => new
                {
                    swapID = table.Column<string>(nullable: false),
                    senderUserID = table.Column<string>(nullable: true),
                    senderUserPhotoUrl = table.Column<string>(nullable: true),
                    senderUserName = table.Column<string>(nullable: true),
                    receiverUserID = table.Column<string>(nullable: true),
                    receiverUserPhotoUrl = table.Column<string>(nullable: true),
                    receiverUserName = table.Column<string>(nullable: true),
                    sendTime = table.Column<DateTime>(nullable: false),
                    acceptTime = table.Column<DateTime>(nullable: false),
                    swapTime = table.Column<DateTime>(nullable: false),
                    isAccepted = table.Column<bool>(nullable: false),
                    isContinue = table.Column<bool>(nullable: false),
                    isDone = table.Column<bool>(nullable: false),
                    swapRate = table.Column<int>(nullable: false),
                    swapAddressAddressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Swaps", x => x.swapID);
                    table.ForeignKey(
                        name: "FK_Swaps_Address_swapAddressAddressId",
                        column: x => x.swapAddressAddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userID = table.Column<string>(nullable: false),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    birthDate = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    isAdmin = table.Column<bool>(nullable: false),
                    profilePhotoURL = table.Column<string>(nullable: true),
                    userFancies = table.Column<List<string>>(nullable: true),
                    userAbilities = table.Column<List<string>>(nullable: true),
                    AddressId = table.Column<int>(nullable: true),
                    userName = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userID);
                    table.ForeignKey(
                        name: "FK_Users_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Swaps_swapAddressAddressId",
                table: "Swaps",
                column: "swapAddressAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressId",
                table: "Users",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Swaps");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
