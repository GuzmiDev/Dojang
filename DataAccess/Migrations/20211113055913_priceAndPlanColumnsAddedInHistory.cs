using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class priceAndPlanColumnsAddedInHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentPlanInTheMoment",
                table: "PaymentHistory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "PriceInTheMoment",
                table: "PaymentHistory",
                type: "money",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentPlanInTheMoment",
                table: "PaymentHistory");

            migrationBuilder.DropColumn(
                name: "PriceInTheMoment",
                table: "PaymentHistory");
        }
    }
}
