using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgageCaculatorApp
{
    public class MortgageCaculationsRaw
    {
        public double taxClosingCost = 2500;
        public double originationFee = .01;
        public double loanAmount = 0;
        public double equity = 0;
        public double propertyTax = .0125;
        public double homeInsurance = .0075;
        public double loanInsurance = 0;
        public double hoaMonthlyFee = 0;
        public double escrow = 0;
        public double principle = 0;
        public double payment = 0;
        public double InterestRateFinal = 0;


      
        


        public double HomePrice { get; set; }
        public double DownPayment { get; set; }
        public double MonthlyIncome { get; set; }
        public double HoaFees { get; set; }
        public string InterestRate { get; set; }
        public double PaymentsPerYear { get; set; }
        public double FixedLoanLength { get; set; }


        public double LoanAmount1()
        {

           loanAmount = (HomePrice - DownPayment) + OriginationFee() + taxClosingCost;
           return loanAmount;

        }



        public double OriginationFee()
        {
            originationFee = (HomePrice - DownPayment) * originationFee;

            return originationFee;
        }


        public double interestRate()
        {
            InterestRateFinal = double.Parse(InterestRate.Replace("%", "")) / 100;
            return InterestRateFinal;
        }
        public string Equity()
        {
            equity = (loanAmount / HomePrice);
            equity = 1 - equity;

            string equityAsString = string.Format("{0:F2} %", equity * 100);

          
            return equityAsString;

        }

        public double HoaFeesInput()
        {
            hoaMonthlyFee = (HoaFees / 12);
            return hoaMonthlyFee;


        }

        public double Escrow()
        {
            propertyTax = (HomePrice * propertyTax) / 12;

            homeInsurance = (HomePrice * homeInsurance) / 12;

            escrow = propertyTax + homeInsurance;

            return escrow;

        }

        public string Payment()
        {
            principle = LoanAmount1();

            payment = principle * (interestRate() / PaymentsPerYear) * Math.Pow(1 + interestRate() / PaymentsPerYear, PaymentsPerYear * FixedLoanLength) / Math.Pow(1 + interestRate() / PaymentsPerYear, (PaymentsPerYear * FixedLoanLength)) - 1;
            payment = payment + HoaFeesInput() + Escrow();

            string Payment = string.Format("${0:F2}", payment);

            return Payment;
        }

    }

}




