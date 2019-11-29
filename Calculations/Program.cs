using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please Choose an option: Area, Circumeference or Percentage");

            string option = Console.ReadLine();
            option.ToLower();

            if (option == "area")
            {
                string areaResult = Area.ChooseAreaCalc();
                Console.WriteLine(areaResult);
            }
            
            if(option == "circumferance")
            {
                string circumferenceResult = CircleCircumference.CircleCircumferenceCalc();
                Console.WriteLine(circumferenceResult);
            }

            if (option == "percentage")
            {
                string percentResult = Percentage.PercentgeCalc();
                Console.WriteLine(percentResult);
            }

            else
            {
                Console.WriteLine("That option does not exists");
            }
        }
    }
}
