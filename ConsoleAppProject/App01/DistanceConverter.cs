using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Kian Rozblat Version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double miles;

        private double feet;

        /// <summary>
        /// Runs the method of converting the miles to feet
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n------------------------");
            Console.WriteLine("--Convert Miles to feet-");
            Console.WriteLine("-----BY Kian Rozblat----");
            Console.WriteLine("------------------------\n");
        }

        /// <summary>
        /// Promt the user to enter the distance in miles 
        /// Input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("please enter a number of miles ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        /// <summary>
        /// Calculates the Inputted miles into feet
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// Outputs the calculated feet to the user 
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet");

        }
    }
}
