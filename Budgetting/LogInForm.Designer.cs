
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
            this.SuspendLayout();
            // 
            // usernameField
            // 
            this.usernameField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameField.Location = new System.Drawing.Point(13, 53);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(233, 23);
            this.usernameField.TabIndex = 0;
            this.usernameField.TextChanged += new System.EventHandler(this.usernameField_TextChanged);
            // 
            // passwordField
            // 
            this.passwordField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordField.Location = new System.Drawing.Point(13, 140);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(233, 23);
            this.passwordField.TabIndex = 1;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLabel.Location = new System.Drawing.Point(94, 122);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(68, 15);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "PASSWORD";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(94, 35);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(68, 15);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "USERNAME";
            // 
            // logInButton
            // 
            this.logInButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logInButton.Location = new System.Drawing.Point(76, 210);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(107, 51);
            this.logInButton.TabIndex = 4;
            this.logInButton.Text = "LOG IN";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 301);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(273, 340);
            this.MinimumSize = new System.Drawing.Size(273, 340);
            this.Name = "LogInForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button logInButton;
    }
}

