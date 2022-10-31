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

namespace Budgetting
{
    public partial class LogInForm : Form
    {
        Thread th;
        private string username, password;

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
            /*
             * INSERT USERNAME/PASSWORD HANDLING HERE
             * CATCH PROFILE OBJECT
             */
            this.Close();
            th = new Thread(showMainMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void showMainMenu(object obj)
        {
            Application.Run(new MainMenu()); //Later, pass profile object as arg for MainMenu()
        }
    }
}
