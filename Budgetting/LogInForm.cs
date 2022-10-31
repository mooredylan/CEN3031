using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgetting
{
    public partial class LogInForm : Form
    {
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
            MessageBox.Show($"Username: {username} \nPassword: {password}");
        }
    }
}
