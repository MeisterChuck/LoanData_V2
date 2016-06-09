using System;

namespace LoanDataRevisedCSharp
{
    class LoanData
    {
        private double Bal, n, i, A;
        
        public LoanData(double loanAmount, double years, double interestRate)
        {
            i = interestRate / 1200;
            n = years * 12;
            A = loanAmount * ((i * Math.Pow(1 + i, n)) / ((Math.Pow(1 + i, n)) - 1));
            Bal = loanAmount;
        }

        public void MakePayment(double payment)
        {
            Bal = (i + 1) * Bal - payment;
        }

        public void PrintAmortizationSchedule()
        {
            double payment, interestPaid, principlePaid, endingBalance;
            double beginningBalance = Bal;
            String title = String.Format("{0, 17}   {1, 13}   {2, 14}   {3, 14}\n",
                                         "Beginning Balance",
                                         "Interest Paid",
                                         "Principle Paid",
                                         "Ending Balance");

            Console.Write("\n" + title);

            while(beginningBalance > 0)
            {
                if (i + 1 * Bal > A)
                {
                    payment = A;
                }
                else
                {
                    payment = (i + 1) * Bal;
                }

                interestPaid = i * beginningBalance;
                principlePaid = A - interestPaid;
                endingBalance = (i + 1) * beginningBalance - A;

                title = String.Format("{0, 17:C2}   {1, 13:C2}   {2, 14:C2}   {3, 14:C2}\n",
                                         beginningBalance,
                                         interestPaid,
                                         principlePaid,
                                         endingBalance);
                Console.Write(title); 

                beginningBalance = endingBalance;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double loanAmount, years, interestRate;
            LoanData loanData;

            System.Console.Write("Loan amount is: ");
            loanAmount = double.Parse(System.Console.ReadLine());
            System.Console.Write("Number of years to pay off loan is: ");
            years = double.Parse(System.Console.ReadLine());
            System.Console.Write("Yearly interest rate is: ");
            interestRate = double.Parse(System.Console.ReadLine());

            loanData = new LoanData(loanAmount, years, interestRate);
            loanData.MakePayment(650.00);
            loanData.PrintAmortizationSchedule();
        }
    }
}
