using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Budgetting
{
    public partial class MainMenu : Form
    {
        Thread th;
        public MainMenu()
        {
            InitializeComponent();
            listBox.Items.Add("Recent Budget 1");
            listBox.Items.Add("Recent Budget 2");
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

    }
}
