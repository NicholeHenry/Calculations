using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
   public class Percentage
    {
        public static string PercentgeCalc() 
        {

            Console.WriteLine("Please enter number to be configured");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter percentage");

            int percent = int.Parse(Console.ReadLine());

            int multipliedNumber = number * percent;

            int result = multipliedNumber / 100;

            string stringResult = result.ToString();

            return stringResult;

        }


    }
}
