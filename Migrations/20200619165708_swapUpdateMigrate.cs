using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeniorWebAPIProjectV3.Migrations
{
    public partial class swapUpdateMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Swaps_Address_swapAddressAddressId",
                table: "Swaps");

            migrationBuilder.RenameColumn(
                name: "swapRate",
                table: "Swaps",
                newName: "SwapRate");

            migrationBuilder.RenameColumn(
                name: "swapAddressAddressId",
                table: "Swaps",
                newName: "SwapAddressAddressId");

            migrationBuilder.RenameColumn(
                name: "senderUserPhotoUrl",
                table: "Swaps",
                newName: "SenderUserPhotoUrl");

            migrationBuilder.RenameColumn(
                name: "senderUserName",
                table: "Swaps",
                newName: "SenderUserName");

            migrationBuilder.RenameColumn(
                name: "senderUserID",
                table: "Swaps",
                newName: "SenderUserId");

            migrationBuilder.RenameColumn(
                name: "receiverUserPhotoUrl",
                table: "Swaps",
                newName: "ReceiverUserPhotoUrl");

            migrationBuilder.RenameColumn(
                name: "receiverUserName",
                table: "Swaps",
                newName: "ReceiverUserName");

            migrationBuilder.RenameColumn(
                name: "receiverUserID",
                table: "Swaps",
                newName: "ReceiverUserId");

            migrationBuilder.RenameColumn(
                name: "isDone",
                table: "Swaps",
                newName: "IsDone");

            migrationBuilder.RenameColumn(
                name: "isContinue",
                table: "Swaps",
                newName: "IsContinue");

            migrationBuilder.RenameColumn(
                name: "isAccepted",
                table: "Swaps",
                newName: "IsAccepted");

            migrationBuilder.RenameColumn(
                name: "swapID",
                table: "Swaps",
                newName: "SwapId");

            migrationBuilder.RenameIndex(
                name: "IX_Swaps_swapAddressAddressId",
                table: "Swaps",
                newName: "IX_Swaps_SwapAddressAddressId");

            migrationBuilder.AddColumn<DateTime>(
                name: "AcceptTime",
                table: "Swaps",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ReceiverField",
                table: "Swaps",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SendTime",
                table: "Swaps",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SenderField",
                table: "Swaps",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SwapTime",
                table: "Swaps",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Swaps_Address_SwapAddressAddressId",
                table: "Swaps",
                column: "SwapAddressAddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Swaps_Address_SwapAddressAddressId",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "AcceptTime",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "ReceiverField",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "SendTime",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "SenderField",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "SwapTime",
                table: "Swaps");

            migrationBuilder.RenameColumn(
                name: "SwapRate",
                table: "Swaps",
                newName: "swapRate");

            migrationBuilder.RenameColumn(
                name: "SwapAddressAddressId",
                table: "Swaps",
                newName: "swapAddressAddressId");

            migrationBuilder.RenameColumn(
                name: "SenderUserPhotoUrl",
                table: "Swaps",
                newName: "senderUserPhotoUrl");

            migrationBuilder.RenameColumn(
                name: "SenderUserName",
                table: "Swaps",
                newName: "senderUserName");

            migrationBuilder.RenameColumn(
                name: "SenderUserId",
                table: "Swaps",
                newName: "senderUserID");

            migrationBuilder.RenameColumn(
                name: "ReceiverUserPhotoUrl",
                table: "Swaps",
                newName: "receiverUserPhotoUrl");

            migrationBuilder.RenameColumn(
                name: "ReceiverUserName",
                table: "Swaps",
                newName: "receiverUserName");

            migrationBuilder.RenameColumn(
                name: "ReceiverUserId",
                table: "Swaps",
                newName: "receiverUserID");

            migrationBuilder.RenameColumn(
                name: "IsDone",
                table: "Swaps",
                newName: "isDone");

            migrationBuilder.RenameColumn(
                name: "IsContinue",
                table: "Swaps",
                newName: "isContinue");

            migrationBuilder.RenameColumn(
                name: "IsAccepted",
                table: "Swaps",
                newName: "isAccepted");

            migrationBuilder.RenameColumn(
                name: "SwapId",
                table: "Swaps",
                newName: "swapID");

            migrationBuilder.RenameIndex(
                name: "IX_Swaps_SwapAddressAddressId",
                table: "Swaps",
                newName: "IX_Swaps_swapAddressAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Swaps_Address_swapAddressAddressId",
                table: "Swaps",
                column: "swapAddressAddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
