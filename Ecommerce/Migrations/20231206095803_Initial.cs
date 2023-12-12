using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AccounInfos",
                table: "AccounInfos");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AccounInfos");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "AccounInfos",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "AccounInfos",
                newName: "SecurityStamp");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AccounInfos",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "IsModerator",
                table: "AccounInfos",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "AccounInfos",
                newName: "PhoneNumberConfirmed");

            migrationBuilder.RenameColumn(
                name: "SSN",
                table: "AccounInfos",
                newName: "AccessFailedCount");

            migrationBuilder.AlterColumn<int>(
                name: "AccessFailedCount",
                table: "AccounInfos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AccounInfos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AccounInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "AccounInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "AccounInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "AccounInfos",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "AccounInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "AccounInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "AccounInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccounInfos",
                table: "AccounInfos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AccounInfos",
                table: "AccounInfos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AccounInfos");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AccounInfos");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "AccounInfos");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "AccounInfos");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "AccounInfos");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "AccounInfos");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "AccounInfos");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "AccounInfos");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "AccounInfos",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "AccounInfos",
                newName: "IsModerator");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "AccounInfos",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "PhoneNumberConfirmed",
                table: "AccounInfos",
                newName: "IsAdmin");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "AccounInfos",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AccessFailedCount",
                table: "AccounInfos",
                newName: "SSN");

            migrationBuilder.AlterColumn<int>(
                name: "SSN",
                table: "AccounInfos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AccounInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccounInfos",
                table: "AccounInfos",
                column: "SSN");
        }
    }
}
