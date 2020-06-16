using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SeniorWebAPIProjectV3.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true)
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
                    Id = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false),
                    ProfilePhotoUrl = table.Column<string>(nullable: true),
                    UserFancies = table.Column<List<string>>(nullable: true),
                    UserAbilities = table.Column<List<string>>(nullable: true),
                    AddressId = table.Column<int>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
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
