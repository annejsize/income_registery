using System;
namespace Banking_App.Properties
{
    public class CalculateIncome
	{

     
        //later move the calculations in here

		public CalculateIncome() //a constructor initilizing the variables
		{
		TotalIncome = 0;
		LowestIncome = 30M;
		HighestIncome = 0;
		}
    
        //Create the fields
		public decimal LowestIncome;
	    public decimal HighestIncome;
	    public decimal TotalIncome;
    }
    
}
