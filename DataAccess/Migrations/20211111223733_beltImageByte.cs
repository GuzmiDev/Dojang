using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class beltImageByte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Belts");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Belts",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Belts");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Belts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
