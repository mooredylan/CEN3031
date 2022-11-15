using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Budgetting.Data;
using Budgetting.Models;

namespace Budgetting
{
    public partial class MainMenu : Form
    {
        Thread th;

        DatabaseRepository db = new DatabaseRepository();

        public Profile profile;
        public Budget curBudget;

        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(Profile profile)
        {
            InitializeComponent();

            this.profile = profile;

            foreach(Budget budget in this.profile.Budgets)
            {
                this.budgetsList.Items.Add($"Budget: {budget.Id}");
            }
            
            this.selectBudgetLabel.Visible = true;
            this.currentBudgetPanel.Visible = false;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(showLogIn);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void showLogIn(object obj)
        {
            Application.Run(new LogInForm());
        }

        private void showNewBudget(object obj)
        {
            Application.Run(new NewBudget(this.profile));
        }

        private void newBudgetButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(showNewBudget);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void budgetsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectBudgetLabel.Visible = false;
            this.currentBudgetPanel.Visible = true;

            if (this.budgetsList.FocusedItem == null) return;

            int index = this.budgetsList.FocusedItem.Index;

            this.curBudget = this.profile.Budgets[index];

            this.updateBudgetLabels();
        }

        private void updateBudgetLabels()
        {
            this.yearlyTotalGrossIncomeLabel.Text = String.Format("Total Gross Income: {0:C}",this.curBudget.YearlyTotalGrossIncome);
            this.taxBracketLabel.Text = String.Format("Tax Bracket: {0:P2}",this.curBudget.TaxBracket);
            this.totalNetIncomeLabel.Text = String.Format("Total Net Income: {0:C}",this.curBudget.YearlyTotalNetIncome);
            this.netIncomeLabel.Text = String.Format("Monthly Net Income: {0:C}",this.curBudget.MonthlyTotalNetIncome);
            this.monthlyExpensesLabel.Text = String.Format("Monthly Expenses: {0:C}",this.curBudget.MonthlyTotalExpenses);
            this.remainingBudgetLabel.Text = String.Format("Remaining Budget: {0:C}",this.curBudget.ExtraBudget);
            this.budgetUtilizationLabel.Text = String.Format("Budget Utilization: {0:P2}",this.curBudget.BudgetUtilization);
        }
    }
}
