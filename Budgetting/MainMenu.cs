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
using ScottPlot;

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

            this.retirementComboBox.Items.AddRange(new string[] {
                "2025","2030","2035","2040","2045","2050","2055","2060","2065","2070",
            });

            this.retirementSaveComboBox.Items.AddRange(new string[] {
                "4%","5%","6%","7%","8%","9%","10%","11%","12%","13%","14%","15%"
            });

            this.retirementComboBox.SelectedItem = "2050";
            this.retirementSaveComboBox.SelectedItem = "10%";
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
            this.addIfExists(this.curBudget.ExtraBudget > 0 ? this.curBudget.ExtraBudget : 0, "Remaining Income", values, names);

            string centerText = $"Utilization\n{values[0] / (this.curBudget.MonthlyTotalExpenses + this.curBudget.ExtraBudget) * 100:00.0}%";

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
            object retirementComboBoxObj = this.retirementComboBox.SelectedItem;
            object retirementSaveComboBox = this.retirementSaveComboBox.SelectedItem;

            if(retirementComboBoxObj == null || retirementSaveComboBox == null || this.curBudget == null) 
                return;

            this.formsPlot5.Reset();

            List<double> values = new List<double>();
            List<double> positions = new List<double>();
            List<string> labels = new List<string>();

            int year = Convert.ToInt32(retirementComboBoxObj.ToString());

            double runningTotal = 0;

            string percentString = retirementSaveComboBox.ToString().Replace("%", "");

            double percent = Convert.ToInt32(percentString);
            double percentOfIncome = this.curBudget.YearlyTotalNetIncome * (percent / 100);

            for (int i = DateTime.Now.Year; i <= year; i++)
            {
                runningTotal = (runningTotal + percentOfIncome) * 1.07;
                values.Add(runningTotal);
                positions.Add(i);
                labels.Add(i % 5 == 0 ? i.ToString() : "");
            }

            // add a bar graph to the plot
            var bar = formsPlot5.Plot.AddBar(values.ToArray(), positions.ToArray());
            formsPlot5.Plot.XTicks(positions.ToArray(), labels.ToArray());

            // customize the width of bars (80% of the inter-position distance looks good)
            bar.BarWidth = (positions[1] - positions[0]) * .8;

            // adjust axis limits so there is no padding below the bar graph
            formsPlot5.Plot.SetAxisLimits(yMin: 0);

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

        private void retirementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.updatetab5Chart();
        }

        private void retirementSaveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.updatetab5Chart();
        }
    }
}
