using System;
using System.Collections.Generic;
using Banking_App.Properties;

namespace Banking_App
{

	public class Bank
	{   // -----------------------------------------------------------------------------------
		public Bank() //constructor to initlize variable
		{
			newIncome = new List<decimal>(); // adding reference
		}
        // -----------------------------------------------------------------------------------
		public void AddIncome(decimal income) //Add new income to list
		{
			newIncome.Add(income); 
		}
		 -----------------------------------------------------------------------------------
		public CalculateIncome GenerateNumbers() // a method called GenerateNumbers that will return an object CalculateIncome
		{
		          //create an instance of CalculateIncome with fields ready for calculations
			CalculateIncome calculations = new CalculateIncome();

			decimal sum = 0;
		          foreach (decimal income in newIncome)
			{
				sum += income;
				calculations.HighestIncome = Math.Max(income, calculations.HighestIncome);
				calculations.LowestIncome = Math.Min(income, calculations.LowestIncome);
			}

			calculations.TotalIncome = sum;
			return calculations;
		}
		// -----------------------------------------------------------------------------------
		private List<decimal> newIncome; // creating the variable 
    }
   
}
