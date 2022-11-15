using Microsoft.EntityFrameworkCore.Migrations;

namespace Budgetting.Migrations
{
    public partial class AddedAdditionalIncomeFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "YearlyInterestAndDividendIncome",
                table: "Budgets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "YearlyOtherIncome",
                table: "Budgets",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearlyInterestAndDividendIncome",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "YearlyOtherIncome",
                table: "Budgets");
        }
    }
}
