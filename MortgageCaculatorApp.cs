using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;



namespace MorgageCaculatorApp
{
    public partial class MortgageCaculatorApp : Form
    {

        MortgageCaculationsRaw mortgage = new MortgageCaculationsRaw();
        

        //public double taxClosingCost = 2500;
        //public double originationFee = .01;
        //public double loanAmount = 0;
        //public double equity = 0;
        //public double propertyTax = .0125;
        //public double homeInsurance = .0075;
        //public double loanInsurance = 0;
        //public double hoaMonthlyFee = 0;
        //public double escrow = 0;
        //public double principle = 0;
        //public double payment = 0;


        //public double HomePrice { get; set; }
        //public double DownPayment { get; set; }
        //public double MonthlyIncome { get; set; }
        //public double HoaFees { get; set; }
        //public double InterestRate { get; set; }
        //public double PaymentsPerYear { get; set; }
        //public double FixedLoanLength { get; set; }

        //public double LoanAmount1()
        //{

        //    loanAmount = (HomePrice - DownPayment) + OriginationFee() + taxClosingCost;
        //    return loanAmount;

        //}

        //public double OriginationFee()
        //{
        //    originationFee = (HomePrice - DownPayment) * originationFee;

        //    return originationFee;
        //}

        //public string Payment()
        //{
        //    principle = LoanAmount1();

        //    payment = principle * (InterestRate / PaymentsPerYear) * Math.Pow(1 + InterestRate / PaymentsPerYear, PaymentsPerYear * FixedLoanLength) / Math.Pow(1 + InterestRate / PaymentsPerYear, (PaymentsPerYear * FixedLoanLength)) - 1;
        //    payment = payment + loanInsurance + HoaFeesInput() + Escrow();

        //    string Payment = string.Format("${0:F2}", payment);

        //    return Payment;
        //}


        //public double Equity()
        //{
        //    equity = (LoanAmount1() / HomePrice);
        //    equity = 1 - equity;

        //    string equityAsString = string.Format("{0:F2} %", equity * 100);

        //    if (equity <= .10)
        //    {
        //        Console.WriteLine("You will need Loan Insurance.");

        //        loanInsurance = (loanAmount * .01) / 12;
        //    }

        //    else
        //    {
        //        Console.WriteLine("You don't need Loan Insurance.");
        //    }
        //    return equity;

        //}

        //public double HoaFeesInput()
        //{
        //    hoaMonthlyFee = (HoaFees / 12);
        //    return hoaMonthlyFee;


        //}

        //public double Escrow()
        //{
        //    propertyTax = (HomePrice * propertyTax) / 12;

        //    homeInsurance = (HomePrice * homeInsurance) / 12;

        //    escrow = propertyTax + homeInsurance;

        //    return escrow;

        //}


        public MortgageCaculatorApp()
        {
            
           

            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           mortgage.HomePrice = Convert.ToDouble(txtHomePrice.Text);
            

        }

        private void txtInterestRate_TextChanged(object sender, EventArgs e)
       {
            
            
            //Have to convert interest rate by perentage/ or figure out how input decimals
            mortgage.InterestRate = txtInterestRate.Text;

        }

        private void txtLoanInYears_TextChanged(object sender, EventArgs e)
        {
            double fifteenYears = 15;
            double thirtyYears = 30;

           mortgage.FixedLoanLength = Convert.ToDouble(txtLoanInYears.Text);
            
            //if (LoanInYears.FixedLoanLength == fifteenYears || LoanInYears.FixedLoanLength == thirtyYears)
            //{

            //}

        }

        private void txtHoaFees_TextChanged(object sender, EventArgs e)
        {
           mortgage.HoaFees = Convert.ToDouble(txtHoaFees.Text);
        }

        private void txtDownPayment_TextChanged(object sender, EventArgs e)
        {
           mortgage.DownPayment = Convert.ToDouble(txtDownPayment.Text);


        }

        private void txtPaymentsPerYear_TextChanged(object sender, EventArgs e)
        {
           mortgage.PaymentsPerYear = Convert.ToDouble(txtPaymentsPerYear.Text);
        }

        private void txtMonthlyIncome_TextChanged(object sender, EventArgs e)
        {
            mortgage.MonthlyIncome = Convert.ToDouble(txtMonthlyIncome.Text);
        }

        private void TotalPayment_Click(object sender, EventArgs e)
        {
          

           lblTotalPayments.Text = mortgage.Payment();
            
            
            
        }

       

        private void btnEquity_Click(object sender, EventArgs e)
        {
            


            EquityOutput.Text = mortgage.Equity();

        }
    }
}
