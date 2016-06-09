namespace LoanDataRevisedCSharp
{
    class LoanData
    {
        private double Bal, n, i, A;
        
        public LoanData(double loanAmount, double years, double interestRate)
        {
            this.i = interestRate / 1200;
            this.n = years * 12;
            //this.A; Gotta figure out how to create powers
            this.Bal = loanAmount;
        }

        public void MakePayment(double payment)
        {
            this.Bal = (i + 1) * Bal - payment;
        }

        //Debugging
        public void Print()
        {
            System.Console.WriteLine(Bal);
            System.Console.WriteLine(n);
            System.Console.WriteLine(i);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int loanAmount, years, interestRate;
            LoanData loanData;

            System.Console.Write("Loan amount is: ");
            loanAmount = int.Parse(System.Console.ReadLine());
            System.Console.Write("Number of years to pay off loan is: ");
            years = int.Parse(System.Console.ReadLine());
            System.Console.Write("Yearly interest rate is: ");
            interestRate = int.Parse(System.Console.ReadLine());

            //Debugging
            System.Console.WriteLine(loanAmount);
            System.Console.WriteLine(years);
            System.Console.WriteLine(interestRate);

            loanData = new LoanData(loanAmount, years, interestRate);
            loanData.Print();
        }
    }
}
