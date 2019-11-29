using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string percentResult = Percentage.PercentgeCalc();
            Console.WriteLine(percentResult);

            string circumferenceResult = CircleCircumference.CircleCircumferenceCalc();
            Console.WriteLine(circumferenceResult);
        }
    }
}
