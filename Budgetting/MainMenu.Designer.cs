
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
            this.monthlyExpensesLabel = new System.Windows.Forms.Label();
            this.netIncomeLabel = new System.Windows.Forms.Label();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.totalNetIncomeLabel = new System.Windows.Forms.Label();
            this.yearlyTotalGrossIncomeLabel = new System.Windows.Forms.Label();
            this.editBudgetButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.formsPlot2 = new ScottPlot.FormsPlot();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.formsPlot3 = new ScottPlot.FormsPlot();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.formsPlot4 = new ScottPlot.FormsPlot();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.formsPlot5 = new ScottPlot.FormsPlot();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logOutButton.Location = new System.Drawing.Point(90, 270);
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
            // monthlyExpensesLabel
            // 
            this.monthlyExpensesLabel.AutoSize = true;
            this.monthlyExpensesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthlyExpensesLabel.Location = new System.Drawing.Point(143, 155);
            this.monthlyExpensesLabel.Name = "monthlyExpensesLabel";
            this.monthlyExpensesLabel.Size = new System.Drawing.Size(284, 45);
            this.monthlyExpensesLabel.TabIndex = 4;
            this.monthlyExpensesLabel.Text = "Monthly Expenses:";
            // 
            // netIncomeLabel
            // 
            this.netIncomeLabel.AutoSize = true;
            this.netIncomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.netIncomeLabel.Location = new System.Drawing.Point(143, 65);
            this.netIncomeLabel.Name = "netIncomeLabel";
            this.netIncomeLabel.Size = new System.Drawing.Size(321, 45);
            this.netIncomeLabel.TabIndex = 0;
            this.netIncomeLabel.Text = "Monthly Net Income:";
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(258, 250);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(374, 311);
            this.formsPlot1.TabIndex = 7;
            // 
            // totalNetIncomeLabel
            // 
            this.totalNetIncomeLabel.AutoSize = true;
            this.totalNetIncomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalNetIncomeLabel.Location = new System.Drawing.Point(143, 155);
            this.totalNetIncomeLabel.Name = "totalNetIncomeLabel";
            this.totalNetIncomeLabel.Size = new System.Drawing.Size(271, 45);
            this.totalNetIncomeLabel.TabIndex = 3;
            this.totalNetIncomeLabel.Text = "Total Net Income:";
            // 
            // yearlyTotalGrossIncomeLabel
            // 
            this.yearlyTotalGrossIncomeLabel.AutoSize = true;
            this.yearlyTotalGrossIncomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearlyTotalGrossIncomeLabel.Location = new System.Drawing.Point(143, 65);
            this.yearlyTotalGrossIncomeLabel.Name = "yearlyTotalGrossIncomeLabel";
            this.yearlyTotalGrossIncomeLabel.Size = new System.Drawing.Size(299, 45);
            this.yearlyTotalGrossIncomeLabel.TabIndex = 1;
            this.yearlyTotalGrossIncomeLabel.Text = "Total Gross Income:";
            // 
            // editBudgetButton
            // 
            this.editBudgetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editBudgetButton.Location = new System.Drawing.Point(90, 376);
            this.editBudgetButton.Margin = new System.Windows.Forms.Padding(6);
            this.editBudgetButton.Name = "editBudgetButton";
            this.editBudgetButton.Size = new System.Drawing.Size(371, 105);
            this.editBudgetButton.TabIndex = 5;
            this.editBudgetButton.Text = "Edit Budget";
            this.editBudgetButton.UseVisualStyleBackColor = true;
            this.editBudgetButton.Visible = false;
            this.editBudgetButton.Click += new System.EventHandler(this.editBudgetButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.ItemSize = new System.Drawing.Size(174, 38);
            this.tabControl1.Location = new System.Drawing.Point(566, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(875, 687);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.formsPlot1);
            this.tabPage1.Controls.Add(this.yearlyTotalGrossIncomeLabel);
            this.tabPage1.Controls.Add(this.totalNetIncomeLabel);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(859, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tax";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.formsPlot2);
            this.tabPage2.Controls.Add(this.netIncomeLabel);
            this.tabPage2.Controls.Add(this.monthlyExpensesLabel);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(859, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Budget";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // formsPlot2
            // 
            this.formsPlot2.Location = new System.Drawing.Point(258, 250);
            this.formsPlot2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.formsPlot2.Name = "formsPlot2";
            this.formsPlot2.Size = new System.Drawing.Size(374, 311);
            this.formsPlot2.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.formsPlot3);
            this.tabPage3.Location = new System.Drawing.Point(8, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(859, 633);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Income";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // formsPlot3
            // 
            this.formsPlot3.Location = new System.Drawing.Point(122, 47);
            this.formsPlot3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.formsPlot3.Name = "formsPlot3";
            this.formsPlot3.Size = new System.Drawing.Size(623, 534);
            this.formsPlot3.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.formsPlot4);
            this.tabPage4.Location = new System.Drawing.Point(8, 46);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(859, 633);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Expenses";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // formsPlot4
            // 
            this.formsPlot4.Location = new System.Drawing.Point(118, 49);
            this.formsPlot4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.formsPlot4.Name = "formsPlot4";
            this.formsPlot4.Size = new System.Drawing.Size(623, 534);
            this.formsPlot4.TabIndex = 9;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.formsPlot5);
            this.tabPage5.Location = new System.Drawing.Point(8, 46);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(859, 633);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Retirement";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // formsPlot5
            // 
            this.formsPlot5.Location = new System.Drawing.Point(97, 153);
            this.formsPlot5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.formsPlot5.Name = "formsPlot5";
            this.formsPlot5.Size = new System.Drawing.Size(668, 431);
            this.formsPlot5.TabIndex = 9;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.editBudgetButton);
            this.Controls.Add(this.selectBudgetLabel);
            this.Controls.Add(this.budgetsList);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.newBudgetButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button newBudgetButton;
        private System.Windows.Forms.ListView budgetsList;
        private System.Windows.Forms.Label selectBudgetLabel;
        private System.Windows.Forms.Label netIncomeLabel;
        private System.Windows.Forms.Label monthlyExpensesLabel;
        private System.Windows.Forms.Label totalNetIncomeLabel;
        private System.Windows.Forms.Label yearlyTotalGrossIncomeLabel;
        private System.Windows.Forms.Button editBudgetButton;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ScottPlot.FormsPlot formsPlot2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private ScottPlot.FormsPlot formsPlot3;
        private ScottPlot.FormsPlot formsPlot4;
        private ScottPlot.FormsPlot formsPlot5;
    }
}