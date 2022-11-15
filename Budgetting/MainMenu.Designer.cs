
namespace Budgetting
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logOutButton = new System.Windows.Forms.Button();
            this.newBudgetButton = new System.Windows.Forms.Button();
            this.budgetsList = new System.Windows.Forms.ListView();
            this.selectBudgetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logOutButton.Location = new System.Drawing.Point(90, 291);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(6);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(132, 68);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "LOG OUT";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // newBudgetButton
            // 
            this.newBudgetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newBudgetButton.Location = new System.Drawing.Point(90, 119);
            this.newBudgetButton.Margin = new System.Windows.Forms.Padding(6);
            this.newBudgetButton.Name = "newBudgetButton";
            this.newBudgetButton.Size = new System.Drawing.Size(371, 105);
            this.newBudgetButton.TabIndex = 1;
            this.newBudgetButton.Text = "CREATE NEW BUDGET";
            this.newBudgetButton.UseVisualStyleBackColor = true;
            this.newBudgetButton.Click += new System.EventHandler(this.newBudgetButton_Click);
            // 
            // budgetsList
            // 
            this.budgetsList.HideSelection = false;
            this.budgetsList.Location = new System.Drawing.Point(90, 509);
            this.budgetsList.Name = "budgetsList";
            this.budgetsList.Size = new System.Drawing.Size(371, 297);
            this.budgetsList.TabIndex = 2;
            this.budgetsList.UseCompatibleStateImageBehavior = false;
            this.budgetsList.SelectedIndexChanged += new System.EventHandler(this.budgetsList_SelectedIndexChanged);
            // 
            // selectBudgetLabel
            // 
            this.selectBudgetLabel.AutoSize = true;
            this.selectBudgetLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectBudgetLabel.Location = new System.Drawing.Point(696, 374);
            this.selectBudgetLabel.Name = "selectBudgetLabel";
            this.selectBudgetLabel.Size = new System.Drawing.Size(666, 130);
            this.selectBudgetLabel.TabIndex = 3;
            this.selectBudgetLabel.Text = "Select a budget.  \r\nIf no budget exists create one!";
            this.selectBudgetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectBudgetLabel.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.selectBudgetLabel);
            this.Controls.Add(this.budgetsList);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.newBudgetButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button newBudgetButton;
        private System.Windows.Forms.ListView budgetsList;
        private System.Windows.Forms.Label selectBudgetLabel;
    }
}