using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Area
    {
        public static string ChooseAreaCalc()
        {
            Console.WriteLine("Please chose the shape that you want to configure the area");
            string choice = Console.ReadLine();

            choice.ToLower();

            if (choice == "sqaure" || choice == "rectangle")
            {
                return RectangleSquareArea();
            }

            if(choice == "triangle")
            {
                return TriangleArea();
            }

            else
            {
                string errorMessage = "that shape isnt available for calculation";

                return errorMessage;
            }
            
        }
        public static string RectangleSquareArea()
        {
            Console.WriteLine("Please enter the length of the rectangle or Square");

            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width of the rectangle or sqaure");

            int width = int.Parse(Console.ReadLine());

            int rectangleSqaureArea = length * width;

            string result = rectangleSqaureArea.ToString();

            return result;
        }
        public static string TriangleArea()
        {
            Console.WriteLine("Please entert the base of the triangle");

            int triangleBase = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the height of the triangle");

            int height = int.Parse(Console.ReadLine());

            int triangleArea = triangleBase * height / 2;

            string result = triangleArea.ToString();

            return result;

        }

        
    }
}
