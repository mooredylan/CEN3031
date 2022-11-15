using Microsoft.EntityFrameworkCore.Migrations;

namespace Budgetting.Migrations
{
    public partial class MadeProfileAndBudgetOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Budgets_ProfileId",
                table: "Budgets");

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_ProfileId",
                table: "Budgets",
                column: "ProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Budgets_ProfileId",
                table: "Budgets");

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_ProfileId",
                table: "Budgets",
                column: "ProfileId",
                unique: true);
        }
    }
}
