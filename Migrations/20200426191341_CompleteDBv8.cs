using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PinArt_ProfileInfo_MS.Migrations
{
    public partial class CompleteDBv8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nick",
                table: "Users");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CauseId",
                table: "Reports",
                column: "CauseId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_CountryId",
                table: "Profiles",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Countries_CountryId",
                table: "Profiles",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Causes_CauseId",
                table: "Reports",
                column: "CauseId",
                principalTable: "Causes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Countries_CountryId",
                table: "Profiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Causes_CauseId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_CauseId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_CountryId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Nick",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
