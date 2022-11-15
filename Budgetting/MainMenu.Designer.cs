
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
            this.currentBudgetPanel = new System.Windows.Forms.Panel();
            this.budgetUtilizationLabel = new System.Windows.Forms.Label();
            this.monthlyExpensesLabel = new System.Windows.Forms.Label();
            this.totalNetIncomeLabel = new System.Windows.Forms.Label();
            this.taxBracketLabel = new System.Windows.Forms.Label();
            this.yearlyTotalGrossIncomeLabel = new System.Windows.Forms.Label();
            this.netIncomeLabel = new System.Windows.Forms.Label();
            this.remainingBudgetLabel = new System.Windows.Forms.Label();
            this.currentBudgetPanel.SuspendLayout();
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
            // currentBudgetPanel
            // 
            this.currentBudgetPanel.Controls.Add(this.remainingBudgetLabel);
            this.currentBudgetPanel.Controls.Add(this.budgetUtilizationLabel);
            this.currentBudgetPanel.Controls.Add(this.monthlyExpensesLabel);
            this.currentBudgetPanel.Controls.Add(this.totalNetIncomeLabel);
            this.currentBudgetPanel.Controls.Add(this.taxBracketLabel);
            this.currentBudgetPanel.Controls.Add(this.yearlyTotalGrossIncomeLabel);
            this.currentBudgetPanel.Controls.Add(this.netIncomeLabel);
            this.currentBudgetPanel.Location = new System.Drawing.Point(630, 119);
            this.currentBudgetPanel.Name = "currentBudgetPanel";
            this.currentBudgetPanel.Size = new System.Drawing.Size(763, 687);
            this.currentBudgetPanel.TabIndex = 4;
            this.currentBudgetPanel.Visible = false;
            // 
            // budgetUtilizationLabel
            // 
            this.budgetUtilizationLabel.AutoSize = true;
            this.budgetUtilizationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.budgetUtilizationLabel.Location = new System.Drawing.Point(33, 581);
            this.budgetUtilizationLabel.Name = "budgetUtilizationLabel";
            this.budgetUtilizationLabel.Size = new System.Drawing.Size(281, 45);
            this.budgetUtilizationLabel.TabIndex = 5;
            this.budgetUtilizationLabel.Text = "Budget Utilization:";
            // 
            // monthlyExpensesLabel
            // 
            this.monthlyExpensesLabel.AutoSize = true;
            this.monthlyExpensesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthlyExpensesLabel.Location = new System.Drawing.Point(33, 412);
            this.monthlyExpensesLabel.Name = "monthlyExpensesLabel";
            this.monthlyExpensesLabel.Size = new System.Drawing.Size(284, 45);
            this.monthlyExpensesLabel.TabIndex = 4;
            this.monthlyExpensesLabel.Text = "Monthly Expenses:";
            // 
            // totalNetIncomeLabel
            // 
            this.totalNetIncomeLabel.AutoSize = true;
            this.totalNetIncomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalNetIncomeLabel.Location = new System.Drawing.Point(33, 246);
            this.totalNetIncomeLabel.Name = "totalNetIncomeLabel";
            this.totalNetIncomeLabel.Size = new System.Drawing.Size(271, 45);
            this.totalNetIncomeLabel.TabIndex = 3;
            this.totalNetIncomeLabel.Text = "Total Net Income:";
            // 
            // taxBracketLabel
            // 
            this.taxBracketLabel.AutoSize = true;
            this.taxBracketLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.taxBracketLabel.Location = new System.Drawing.Point(33, 159);
            this.taxBracketLabel.Name = "taxBracketLabel";
            this.taxBracketLabel.Size = new System.Drawing.Size(184, 45);
            this.taxBracketLabel.TabIndex = 2;
            this.taxBracketLabel.Text = "Tax Bracket:";
            // 
            // yearlyTotalGrossIncomeLabel
            // 
            this.yearlyTotalGrossIncomeLabel.AutoSize = true;
            this.yearlyTotalGrossIncomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearlyTotalGrossIncomeLabel.Location = new System.Drawing.Point(33, 73);
            this.yearlyTotalGrossIncomeLabel.Name = "yearlyTotalGrossIncomeLabel";
            this.yearlyTotalGrossIncomeLabel.Size = new System.Drawing.Size(299, 45);
            this.yearlyTotalGrossIncomeLabel.TabIndex = 1;
            this.yearlyTotalGrossIncomeLabel.Text = "Total Gross Income:";
            // 
            // netIncomeLabel
            // 
            this.netIncomeLabel.AutoSize = true;
            this.netIncomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.netIncomeLabel.Location = new System.Drawing.Point(33, 330);
            this.netIncomeLabel.Name = "netIncomeLabel";
            this.netIncomeLabel.Size = new System.Drawing.Size(321, 45);
            this.netIncomeLabel.TabIndex = 0;
            this.netIncomeLabel.Text = "Monthly Net Income:";
            // 
            // remainingBudgetLabel
            // 
            this.remainingBudgetLabel.AutoSize = true;
            this.remainingBudgetLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remainingBudgetLabel.Location = new System.Drawing.Point(33, 499);
            this.remainingBudgetLabel.Name = "remainingBudgetLabel";
            this.remainingBudgetLabel.Size = new System.Drawing.Size(288, 45);
            this.remainingBudgetLabel.TabIndex = 6;
            this.remainingBudgetLabel.Text = "Remaining Budget:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.currentBudgetPanel);
            this.Controls.Add(this.selectBudgetLabel);
            this.Controls.Add(this.budgetsList);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.newBudgetButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.currentBudgetPanel.ResumeLayout(false);
            this.currentBudgetPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button newBudgetButton;
        private System.Windows.Forms.ListView budgetsList;
        private System.Windows.Forms.Label selectBudgetLabel;
        private System.Windows.Forms.Panel currentBudgetPanel;
        private System.Windows.Forms.Label netIncomeLabel;
        private System.Windows.Forms.Label budgetUtilizationLabel;
        private System.Windows.Forms.Label monthlyExpensesLabel;
        private System.Windows.Forms.Label totalNetIncomeLabel;
        private System.Windows.Forms.Label taxBracketLabel;
        private System.Windows.Forms.Label yearlyTotalGrossIncomeLabel;
        private System.Windows.Forms.Label remainingBudgetLabel;
    }
}