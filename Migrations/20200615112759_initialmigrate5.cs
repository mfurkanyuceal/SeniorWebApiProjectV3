using Microsoft.EntityFrameworkCore.Migrations;

namespace SeniorWebAPIProjectV3.Migrations
{
    public partial class initialmigrate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "userName",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "userFancies",
                table: "Users",
                newName: "UserFancies");

            migrationBuilder.RenameColumn(
                name: "userAbilities",
                table: "Users",
                newName: "UserAbilities");

            migrationBuilder.RenameColumn(
                name: "profilePhotoURL",
                table: "Users",
                newName: "ProfilePhotoUrl");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "isAdmin",
                table: "Users",
                newName: "IsAdmin");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Users",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "longitude",
                table: "Address",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "latitude",
                table: "Address",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Address",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Users",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "userName");

            migrationBuilder.RenameColumn(
                name: "UserFancies",
                table: "Users",
                newName: "userFancies");

            migrationBuilder.RenameColumn(
                name: "UserAbilities",
                table: "Users",
                newName: "userAbilities");

            migrationBuilder.RenameColumn(
                name: "ProfilePhotoUrl",
                table: "Users",
                newName: "profilePhotoURL");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "Users",
                newName: "isAdmin");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Users",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Address",
                newName: "longitude");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Address",
                newName: "latitude");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Address",
                newName: "description");

            migrationBuilder.AddColumn<string>(
                name: "userID",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "userID");
        }
    }
}
