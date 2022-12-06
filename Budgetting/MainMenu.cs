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
using System.Linq;

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
            this.tabControl1.Visible = false;
            this.editBudgetButton.Visible = false;
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

        private void editBudget(object obj)
        {
            Application.Run(new NewBudget(this.profile, this.curBudget));
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
            this.tabControl1.Visible = true;

            if (this.budgetsList.FocusedItem == null) return;

            int index = this.budgetsList.FocusedItem.Index;

            this.curBudget = this.profile.Budgets[index];

            this.editBudgetButton.Visible = true;

            this.updateBudgetLabels();
            this.updateCharts();
        }

        private void updateBudgetLabels()
        {
            this.yearlyTotalGrossIncomeLabel.Text = String.Format("Total Gross Income: {0:C}",this.curBudget.YearlyTotalGrossIncome);
            this.totalNetIncomeLabel.Text = String.Format("Total Net Income: {0:C}",this.curBudget.YearlyTotalNetIncome);
            this.netIncomeLabel.Text = String.Format("Monthly Net Income: {0:C}",this.curBudget.MonthlyTotalNetIncome);
            this.monthlyExpensesLabel.Text = String.Format("Monthly Expenses: {0:C}",this.curBudget.MonthlyTotalExpenses);
        }

        private void updateCharts()
        {
            this.updatetab1Chart();
            this.updatetab2Chart();
            this.updatetab3Chart();
            this.updatetab4Chart();
            this.updatetab5Chart();
        }
        
        private void updatetab1Chart()
        {
            List<double> values = new List<double>();
            List<string> names = new List<string>();

            this.addIfExists(this.curBudget.YearlyTotalGrossIncome - this.curBudget.YearlyTotalNetIncome, "Income Tax", values, names);
            this.addIfExists(this.curBudget.YearlyTotalNetIncome, "Net Income", values, names);

            string centerText = $"Tax\n{values[0] / values.Sum() * 100:00.0}%";

            Color color1 = Color.FromArgb(255, 0, 150, 200);

            var pie = this.formsPlot1.Plot.AddPie(values.ToArray());
            pie.DonutSize = .6;
            pie.DonutLabel = centerText;
            pie.CenterFont.Color = color1;
            pie.CenterFont.Size = 24;
            pie.OutlineSize = 2;
            pie.SliceLabels = names.ToArray();

            this.formsPlot1.Plot.Legend();
            formsPlot1.Refresh();
        }

        private void updatetab2Chart()
        {
            List<double> values = new List<double>();
            List<string> names = new List<string>();

            this.addIfExists(this.curBudget.MonthlyTotalExpenses, "Monthly Expenses", values, names);
            this.addIfExists(this.curBudget.ExtraBudget, "Remaining Income", values, names);

            string centerText = $"Utilization\n{values[0] / values.Sum() * 100:00.0}%";

            Color color1 = Color.FromArgb(255, 0, 150, 200);

            var pie = this.formsPlot2.Plot.AddPie(values.ToArray());
            pie.DonutSize = .6;
            pie.DonutLabel = centerText;
            pie.CenterFont.Color = color1;
            pie.CenterFont.Size = 24;
            pie.OutlineSize = 2;
            pie.SliceLabels = names.ToArray();

            this.formsPlot2.Plot.Legend();
            formsPlot2.Refresh();
        }

        private void updatetab3Chart()
        {
            List<double> values = new List<double>();
            List<string> names = new List<string>();

            this.addIfExists(this.curBudget.YearlyGrossIncome, "Gross Income", values, names);
            this.addIfExists(this.curBudget.YearlyOtherIncome, "Other Income", values, names);
            this.addIfExists(this.curBudget.YearlyInterestAndDividendIncome, "Interest and Dividends", values, names);

            var pie = this.formsPlot3.Plot.AddPie(values.ToArray());
            pie.SliceLabels = names.ToArray();
            pie.ShowPercentages = true;

            this.formsPlot3.Plot.Legend();
            formsPlot3.Refresh();
        }

        private void updatetab4Chart()
        {
            List<double> values = new List<double>();
            List<string> names = new List<string>();

            this.addIfExists(this.curBudget.MonthlyInvesting, "Investing", values, names);
            this.addIfExists(this.curBudget.MonthlySaving, "Savings", values, names);
            this.addIfExists(this.curBudget.MonthlyRentAndUtilities, "Rent and Utilities", values, names);
            this.addIfExists(this.curBudget.MonthlyCreditCard, "Credit Card", values, names);
            this.addIfExists(this.curBudget.MonthlyRecreation, "Recreation", values, names);
            this.addIfExists(this.curBudget.MonthlyHealthInsurance, "Health Insurance", values, names);
            this.addIfExists(this.curBudget.MonthlyStudentLoan, "Student Loan", values, names);
            this.addIfExists(this.curBudget.MonthlyCarPayment, "Car Payment", values, names);
            this.addIfExists(this.curBudget.MonthlyCarInsurance, "Car Insurance", values, names);
            this.addIfExists(this.curBudget.MonthlyFood, "Food", values, names);

            var pie = this.formsPlot4.Plot.AddPie(values.ToArray());
            pie.SliceLabels = names.ToArray();
            pie.ShowPercentages = true;

            this.formsPlot4.Plot.Legend();
            formsPlot4.Refresh();
        }

        private void updatetab5Chart()
        {
            List<double> values = new List<double>();
            List<string> names = new List<string>();

            this.addIfExists(this.curBudget.YearlyGrossIncome, "Gross Income", values, names);
            this.addIfExists(this.curBudget.YearlyOtherIncome, "Other Income", values, names);
            this.addIfExists(this.curBudget.YearlyInterestAndDividendIncome, "Interest and Dividends", values, names);

            var pie = this.formsPlot5.Plot.AddPie(values.ToArray());
            pie.SliceLabels = names.ToArray();
            pie.ShowPercentages = true;

            this.formsPlot5.Plot.Legend();
            formsPlot5.Refresh();
        }

        private void editBudgetButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(editBudget);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void addIfExists(double value, string name, List<double> values, List<string> names)
        {
            if(value != 0 && !String.IsNullOrEmpty(name))
            {
                values.Add(value);
                names.Add(name);
            }
        }
    }
}
