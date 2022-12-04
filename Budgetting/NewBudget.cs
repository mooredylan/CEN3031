using Budgetting.Data;
using Budgetting.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Budgetting
{
    public partial class NewBudget : Form
    {
        Budget newBudget = new Budget();
        
        DatabaseRepository db = new DatabaseRepository();

        Profile profile;

        Thread th;

        public NewBudget()
        {
            InitializeComponent();
        }

        public NewBudget(Profile profile)
        {
            InitializeComponent();

            this.profile = profile;
            this.newBudget.Id = 0;
            this.newBudget.ProfileId = this.profile.Id;
        }

        public NewBudget(Profile profile, Budget budget)
        {
            InitializeComponent();

            this.profile = profile;
            this.newBudget = budget;
            this.yearlyGrossIncomeTextBox.Text = Convert.ToString(this.newBudget.YearlyGrossIncome);
            this.OtherIncomeTextBox.Text = Convert.ToString(this.newBudget.YearlyOtherIncome);
            this.interestAndDividendsTextBox.Text = Convert.ToString(this.newBudget.YearlyInterestAndDividendIncome);
            this.monthlyInvestingTextBox.Text = Convert.ToString(this.newBudget.MonthlyInvesting);
            this.monthlySavingTextBox.Text = Convert.ToString(this.newBudget.MonthlySaving);
            this.monthlyRentAndUtilitiesTextBox.Text = Convert.ToString(this.newBudget.MonthlyRentAndUtilities);
            this.monthlyCreditCardtextBox.Text = Convert.ToString(this.newBudget.MonthlyCreditCard);
            this.monthlyRecreationTextBox.Text = Convert.ToString(this.newBudget.MonthlyRecreation);
            this.monthlyHealthInsuranceTextBox.Text = Convert.ToString(this.newBudget.MonthlyHealthInsurance);
            this.monthlyStudentLoanTextBox.Text = Convert.ToString(this.newBudget.MonthlyStudentLoan);
            this.monthlyCarPaymentTextBox.Text = Convert.ToString(this.newBudget.MonthlyCarPayment);
            this.monthlyCarInsuranceTextBox.Text = Convert.ToString(this.newBudget.MonthlyCarInsurance);
            this.monthlyFoodTextBox.Text = Convert.ToString(this.newBudget.MonthlyFood);
        }

        private void yearlyGrossIncomeTextBox_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                this.newBudget.YearlyGrossIncome = Convert.ToDouble(yearlyGrossIncomeTextBox.Text);
            }
            catch (Exception except)
            {
                Console.WriteLine("Exception caught: ", except);
            }
            
        }

        private void yearlyGrossIncomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void OtherIncomeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.newBudget.YearlyOtherIncome = Convert.ToDouble(OtherIncomeTextBox.Text);
            }
            catch (Exception except)
            {
                Console.WriteLine("Exception caught: ", except);
            }
            
        }

        private void OtherIncomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void interestAndDividendsTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.newBudget.YearlyInterestAndDividendIncome = Convert.ToDouble(interestAndDividendsTextBox.Text);
            }
            catch (Exception except)
            {
                Console.WriteLine("Exception caught: ", except);
            }
            
        }

        private void interestAndDividendsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void monthlyInvestingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.newBudget.MonthlyInvesting = Convert.ToDouble(monthlyInvestingTextBox.Text);
            }
            catch (Exception except)
            {
                Console.WriteLine("Exception caught: ", except);
            }
            
        }

        private void monthlyInvestingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void monthlySavingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.newBudget.MonthlySaving = Convert.ToDouble(monthlySavingTextBox.Text);
            }
            catch (Exception except)
            {
                Console.WriteLine("Exception caught: ", except);
            }
            
        }

        private void monthlySavingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void monthlyRentAndUtilitiesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.newBudget.MonthlyRentAndUtilities = Convert.ToDouble(monthlyRentAndUtilitiesTextBox.Text);
            }
            catch (Exception except)
            {
                Console.WriteLine("Exception caught: ", except);
            }

            
        }

        private void monthlyRentAndUtilitiesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void monthlyCreditCardtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.newBudget.MonthlyCreditCard = Convert.ToDouble(monthlyCreditCardtextBox.Text);
            }
            catch (Exception except)
            {
                Console.WriteLine("Exception caught: ", except);
            }
            
        }

        private void monthlyCreditCardtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void monthlyRecreationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.newBudget.MonthlyRecreation = Convert.ToDouble(monthlyRecreationTextBox.Text);
            }
            catch (Exception except)
            {
                Console.WriteLine("Exception caught: ", except);
            }
            
        }

        private void monthlyRecreationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void monthlyHealthInsuranceTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.newBudget.MonthlyHealthInsurance = Convert.ToDouble(monthlyHealthInsuranceTextBox.Text);
            }
            catch (Exception except)
            {
                Console.WriteLine("Exception caught: ", except);
            }

            
        }

        private void monthlyHealthInsuranceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void monthlyCarInsuranceTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.newBudget.MonthlyCarInsurance = Convert.ToDouble(monthlyCarInsuranceTextBox.Text);
            }
            catch (Exception except)
            {
                Console.WriteLine("Exception caught: ", except);
            }
            
        }

        private void monthlyCarInsuranceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void monthlyFoodTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.newBudget.MonthlyFood = Convert.ToDouble(monthlyFoodTextBox.Text);
            }
            catch (Exception except)
            {
                Console.WriteLine("Exception caught: ", except);
            }
            
        }

        private void monthlyFoodTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void monthlyCarPaymentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.newBudget.MonthlyCarPayment = Convert.ToDouble(monthlyCarPaymentTextBox.Text);
            }
            catch (Exception except)
            {
                Console.WriteLine("Exception caught: ", except);
            }
            
        }

        private void monthlyCarPaymentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void monthlyStudentLoanTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.newBudget.MonthlyStudentLoan = Convert.ToDouble(monthlyStudentLoanTextBox.Text);
            }
            catch (Exception except)
            {
                Console.WriteLine("Exception caught: ", except);
            }
            
        }

        private void monthlyStudentLoanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void saveBudgetButton_Click(object sender, EventArgs e)
        {
            this.profile = this.db.SaveBudget(this.profile, this.newBudget);

            this.Close();
            th = new Thread(showMainMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void showMainMenu(object obj)
        {
            Application.Run(new MainMenu(this.profile));
        }
        
    }
}
