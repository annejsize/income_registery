using System;
using Banking_App.Properties;

namespace Banking_App
{
    class MainClass
    {
      
		public static void Main(string[] args)
        {
			Bank user1 = new Bank();
			user1.AddIncome(4.50M);
			user1.AddIncome(3);
			user1.AddIncome(5.00M);
			user1.AddIncome(25.00M);

			CalculateIncome results = user1.GenerateNumbers();
			PrintMe("The lowest income recorded is", results.LowestIncome);
			PrintMe("The highest income recorded is", results.HighestIncome);
			PrintMe("The total income is", results.TotalIncome);
                   
        }

		static void PrintMe(string description, decimal money)
        {
			Console.WriteLine($"{description} is {money:C}", description, money);
        }
    }
}
