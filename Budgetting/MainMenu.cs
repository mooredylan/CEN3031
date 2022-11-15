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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }
    }
}
