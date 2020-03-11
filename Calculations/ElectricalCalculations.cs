using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    class ElectricalCalculations
    {
        public static string CalculationChoices()
        {
            Console.WriteLine("Which claculation do you need? R= resistance, V = volts, I = current");

            string choice = Console.ReadLine();

            if (choice == "R")
            {
                return ResistanceCalculation();
            }

            if(choice == "V")
            {
                return VoltsCalculation();
            }

            if(choice == "I")
            {
                return CurrentCalculation();

            }

            else
            {

                string choiceError = "that calculation isnt available, please review choice";

                return choiceError;
            }
        }

        public static string ResistanceCalculation()
        {


        }

        public static string VoltsCalculation() 
        {
            Console.WriteLine("How many amps?"); 

            int amps = int.Parse(Console.ReadLine());

            Console.WriteLine("How much resitance");

            int resistance = int.Parse()

    
            
        }

        public static string CurrentCalculation()
        {
            Console.WriteLine("What is the amps?");

            int amps = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the Voltage?");

            int voltage = int.Parse(Console.ReadLine());

            int resistance = voltage / amps;

            string result = resistance.ToString();

            return result;
        }
    }
}
