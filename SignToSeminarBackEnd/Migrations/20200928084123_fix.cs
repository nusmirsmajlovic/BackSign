using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SignToSeminarBackEnd.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "seminarId",
                table: "Visitors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Datum",
                table: "Seminars",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Maxplats",
                table: "Seminars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Seminars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_seminarId",
                table: "Visitors",
                column: "seminarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visitors_Seminars_seminarId",
                table: "Visitors",
                column: "seminarId",
                principalTable: "Seminars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visitors_Seminars_seminarId",
                table: "Visitors");

            migrationBuilder.DropIndex(
                name: "IX_Visitors_seminarId",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "seminarId",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "Datum",
                table: "Seminars");

            migrationBuilder.DropColumn(
                name: "Maxplats",
                table: "Seminars");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Seminars");
        }
    }
}
