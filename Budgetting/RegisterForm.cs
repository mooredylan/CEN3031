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
    public partial class RegisterForm : Form
    {
        Thread th;
        private string username, password;

        DatabaseRepository db = new DatabaseRepository();

        public RegisterForm()
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


        //registers user if username and password are valid
        private void registerButton_Click(object sender, EventArgs e)
        {
            accountExistsLabel.Visible = false;

            Console.WriteLine($"Username: {username} \nPassword: {password}");

            Profile profile = this.db.GetProfile(username, password);

            if (profile != null)
            {
                accountExistsLabel.Visible = true;
            }
            else
            {
                NewProfile newProfile = new NewProfile()
                {
                    Username = username,
                    Password = password
                };

                this.db.CreateProfile(newProfile);
                
                this.Close();
                th = new Thread(showLogin);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }


        //redirects to login page
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(showLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void showLogin(object obj)
        {
            Application.Run(new LogInForm()); //Later, pass profile object as arg for MainMenu()
        }
    }
}
