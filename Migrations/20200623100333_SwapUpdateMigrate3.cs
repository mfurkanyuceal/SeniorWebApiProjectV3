using Microsoft.EntityFrameworkCore.Migrations;

namespace SeniorWebAPIProjectV3.Migrations
{
    public partial class SwapUpdateMigrate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverUserName",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "ReceiverUserPhotoUrl",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "SenderUserName",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "SenderUserPhotoUrl",
                table: "Swaps");

            migrationBuilder.AlterColumn<double>(
                name: "SwapRate",
                table: "Swaps",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<bool>(
                name: "IsCancel",
                table: "Swaps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsReject",
                table: "Swaps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "ReceiverRate",
                table: "Swaps",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SenderRate",
                table: "Swaps",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Swaps_ReceiverUserId",
                table: "Swaps",
                column: "ReceiverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Swaps_SenderUserId",
                table: "Swaps",
                column: "SenderUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Swaps_Users_ReceiverUserId",
                table: "Swaps",
                column: "ReceiverUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Swaps_Users_SenderUserId",
                table: "Swaps",
                column: "SenderUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Swaps_Users_ReceiverUserId",
                table: "Swaps");

            migrationBuilder.DropForeignKey(
                name: "FK_Swaps_Users_SenderUserId",
                table: "Swaps");

            migrationBuilder.DropIndex(
                name: "IX_Swaps_ReceiverUserId",
                table: "Swaps");

            migrationBuilder.DropIndex(
                name: "IX_Swaps_SenderUserId",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "IsCancel",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "IsReject",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "ReceiverRate",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "SenderRate",
                table: "Swaps");

            migrationBuilder.AlterColumn<long>(
                name: "SwapRate",
                table: "Swaps",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<string>(
                name: "ReceiverUserName",
                table: "Swaps",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverUserPhotoUrl",
                table: "Swaps",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderUserName",
                table: "Swaps",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderUserPhotoUrl",
                table: "Swaps",
                type: "text",
                nullable: true);
        }
    }
}
