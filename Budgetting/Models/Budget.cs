using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Budgetting.Models
{
    public class Budget
    {
        [Key]
        public int Id { get; set; }

        public int ProfileId { get; set; }

        public double YearlyGrossIncome { get; set; }

        public double YearlyOtherIncome { get; set; }

        public double YearlyInterestAndDividendIncome { get; set; }

        public double MonthlyRentAndUtilities { get; set; }

        public double MonthlySaving { get; set; }

        public double MonthlyInvesting { get; set; }

        public double MonthlyFood { get; set; }

        public double MonthlyCarInsurance { get; set; }
        
        public double MonthlyHealthInsurance { get; set; }

        public double MonthlyRecreation { get; set; }

        public double MonthlyCreditCard { get; set; }

        public double MonthlyStudentLoan { get; set; }

        public double MonthlyCarPayment { get; set; }

        public double MonthlyTotalExpenses { get {
            return this.MonthlyRentAndUtilities
            + this.MonthlySaving
            + this.MonthlyInvesting
            + this.MonthlyFood
            + this.MonthlyCarInsurance
            + this.MonthlyHealthInsurance
            + this.MonthlyRecreation
            + this.MonthlyCreditCard
            + this.MonthlyStudentLoan
            + this.MonthlyCarPayment;
        } }

        public double YearlyTotalGrossIncome { get {
            return this.YearlyGrossIncome + this.YearlyOtherIncome + this.YearlyInterestAndDividendIncome;
        } }

        public double TaxBracket { get {
            if (YearlyTotalGrossIncome <= 9275)
            {
                return 0.10;
            }
            else if (YearlyTotalGrossIncome <= 37650)
            {
                return 0.15;
            }
            else if (YearlyTotalGrossIncome <= 91150)
            { 
                return 0.25;
            }
            else if (YearlyTotalGrossIncome <= 190150)
            {
                return 0.28;
            }
            else if (YearlyTotalGrossIncome <= 413350)
            {
                return 0.33;
            }
            else if (YearlyTotalGrossIncome <= 415050)
            {
                return 0.35;
            }
            else
            {
                return 0.396;
            }
        } }

        public double YearlyTotalNetIncome { get {
            return this.YearlyTotalGrossIncome * this.TaxBracket;
        } }

        public double MonthlyTotalNetIncome { get {
            return this.YearlyTotalNetIncome / 12;
        } }

        public double BudgetUtilization { get {
            return this.MonthlyTotalExpenses / this.MonthlyTotalNetIncome;
        } }

        public double ExtraBudget { get {
            return this.MonthlyTotalNetIncome - MonthlyTotalExpenses;
        }}
    }
}
