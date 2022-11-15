using Microsoft.EntityFrameworkCore.Migrations;

namespace Budgetting.Migrations
{
    public partial class AddedExpenseFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MonthlyCarInsurance",
                table: "Budgets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MonthlyCarPayment",
                table: "Budgets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MonthlyCreditCard",
                table: "Budgets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MonthlyFood",
                table: "Budgets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MonthlyHealthInsurance",
                table: "Budgets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MonthlyInvesting",
                table: "Budgets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MonthlyRecreation",
                table: "Budgets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MonthlyRentAndUtilities",
                table: "Budgets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MonthlySaving",
                table: "Budgets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MonthlyStudentLoan",
                table: "Budgets",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonthlyCarInsurance",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "MonthlyCarPayment",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "MonthlyCreditCard",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "MonthlyFood",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "MonthlyHealthInsurance",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "MonthlyInvesting",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "MonthlyRecreation",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "MonthlyRentAndUtilities",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "MonthlySaving",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "MonthlyStudentLoan",
                table: "Budgets");
        }
    }
}
