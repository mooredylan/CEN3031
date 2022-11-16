
namespace Budgetting
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.noAccountLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameField
            // 
            this.usernameField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameField.Location = new System.Drawing.Point(24, 113);
            this.usernameField.Margin = new System.Windows.Forms.Padding(6);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(429, 39);
            this.usernameField.TabIndex = 0;
            this.usernameField.TextChanged += new System.EventHandler(this.usernameField_TextChanged);
            // 
            // passwordField
            // 
            this.passwordField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordField.Location = new System.Drawing.Point(24, 240);
            this.passwordField.Margin = new System.Windows.Forms.Padding(6);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(429, 39);
            this.passwordField.TabIndex = 1;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLabel.Location = new System.Drawing.Point(161, 201);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(152, 33);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "PASSWORD";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(161, 64);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(136, 32);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "USERNAME";
            // 
            // logInButton
            // 
            this.logInButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logInButton.Location = new System.Drawing.Point(258, 410);
            this.logInButton.Margin = new System.Windows.Forms.Padding(6);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(154, 91);
            this.logInButton.TabIndex = 4;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // noAccountLabel
            // 
            this.noAccountLabel.AutoSize = true;
            this.noAccountLabel.ForeColor = System.Drawing.Color.Red;
            this.noAccountLabel.Location = new System.Drawing.Point(105, 327);
            this.noAccountLabel.Name = "noAccountLabel";
            this.noAccountLabel.Size = new System.Drawing.Size(260, 32);
            this.noAccountLabel.TabIndex = 6;
            this.noAccountLabel.Text = "Could not find account";
            this.noAccountLabel.Visible = false;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.createAccountButton.Location = new System.Drawing.Point(43, 410);
            this.createAccountButton.Margin = new System.Windows.Forms.Padding(6);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(154, 91);
            this.createAccountButton.TabIndex = 5;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 574);
            this.Controls.Add(this.noAccountLabel);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(485, 645);
            this.MinimumSize = new System.Drawing.Size(485, 645);
            this.Name = "LogInForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label noAccountLabel;
        private System.Windows.Forms.Button createAccountButton;
    }
}

