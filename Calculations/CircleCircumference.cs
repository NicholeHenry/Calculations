using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class CircleCircumference
    {
        public static string CircleCircumferenceCalc()

        {

            Console.WriteLine("Please enter the redius of the circle");

            double radius = double.Parse(Console.ReadLine());

            double diameter = radius + radius;

            double circumeference = Math.PI * diameter;

            string result = circumeference.ToString();

            return result;

        } 
    }
}
