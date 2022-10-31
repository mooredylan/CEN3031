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

        private void logInButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Username: {username} \nPassword: {password}");

            Profile profile = this.db.GetProfile(username, password);

            if (profile == null)
            {
                profile = this.db.CreateProfile(
                    new NewProfile()
                    {
                        Username = username,
                        Password = password
                    }
                );
            }

            if(profile != null)
            {
                Console.WriteLine($"Id: {profile.Id}");
                
                //TOOD pass profile to profile page

                this.Close();
                th = new Thread(showMainMenu);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                //TODO handle invalid login for username
                //TODO probably make login and register page into two different forms.
            }
        }

        private void showMainMenu(object obj)
        {
            Application.Run(new MainMenu()); //Later, pass profile object as arg for MainMenu()
        }
    }
}
