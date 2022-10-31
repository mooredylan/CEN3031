using Microsoft.EntityFrameworkCore.Migrations;

namespace Budgetting.Migrations
{
    public partial class AddedReferenceToBudget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Budgets_BudgetId",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_BudgetId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "BudgetId",
                table: "Profiles");

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Budgets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_ProfileId",
                table: "Budgets",
                column: "ProfileId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Budgets_Profiles_ProfileId",
                table: "Budgets",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budgets_Profiles_ProfileId",
                table: "Budgets");

            migrationBuilder.DropIndex(
                name: "IX_Budgets_ProfileId",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Budgets");

            migrationBuilder.AddColumn<int>(
                name: "BudgetId",
                table: "Profiles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_BudgetId",
                table: "Profiles",
                column: "BudgetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Budgets_BudgetId",
                table: "Profiles",
                column: "BudgetId",
                principalTable: "Budgets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
