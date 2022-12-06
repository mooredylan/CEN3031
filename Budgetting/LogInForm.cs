using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Budgetting.Data;
using Budgetting.ViewModels;
using Budgetting.Models;

namespace Budgetting
{
    public partial class LogInForm : Form
    {
        Thread th;
        private string username, password;

        DatabaseRepository db = new DatabaseRepository();

        private Profile profile;

        public LogInForm()
        {
            InitializeComponent();
        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {
            username = usernameField.Text;
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {
            password = passwordField.Text;
        }

        //logs in user with valid username and password
        private void logInButton_Click(object sender, EventArgs e)
        {
            noAccountLabel.Visible = false;

            Console.WriteLine($"Username: {username} \nPassword: {password}");

            Profile profile = this.db.GetProfile(username, password);

            if (profile == null)
            {
                noAccountLabel.Visible = true;
            }
            else
            {
                Console.WriteLine($"Id: {profile.Id}");

                this.profile = profile;

                this.Close();
                th = new Thread(showMainMenu);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            
        }

        //redirects to register page
        private void createAccountButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(showRegister);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void showMainMenu(object obj)
        {
            Application.Run(new MainMenu(profile));
        }

        private void showRegister(object obj)
        {
            Application.Run(new RegisterForm());
        }
    }
}
