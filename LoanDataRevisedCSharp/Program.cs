namespace LoanDataRevisedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int loanAmount, years, interestRate;

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
        }
    }
}
