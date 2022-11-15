using Microsoft.EntityFrameworkCore.Migrations;

namespace Budgetting.Migrations
{
    public partial class AddedYearlyGrossIncome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "YearlyGrossIncome",
                table: "Budgets",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearlyGrossIncome",
                table: "Budgets");
        }
    }
}
