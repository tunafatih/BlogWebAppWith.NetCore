using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FatihTuna.Migrations
{
    public partial class FirstUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Post",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Post",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Post",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Post");
        }
    }
}
