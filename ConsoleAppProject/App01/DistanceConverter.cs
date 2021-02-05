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
        //constants
        public const double FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;

        //attributes
        private double miles;
        private double feet;
        private double metres;

        /// <summary>
        /// Runs the method of converting the miles to feet
        /// </summary>
        public void Run()
        {
            OutputHeading("Distance Converter");
            InputMiles();
            CalculateFeet();
            CalulateMetres();
            OutputFeet();
        }

        public void ConvertFeetToMiles()
        {
            OutputHeading("Convert Feet to Miles");
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        private void OutputMiles()
        {
            Console.WriteLine($"{feet:0.00} feet is  {miles:0.00} miles");
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        private void InputFeet()
        {
            Console.Write("please enter a number of feet ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        private void CalulateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        private void OutputHeading(string title)
        {
            Console.WriteLine("\n------------------------");
            Console.WriteLine($"--{title}-");
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
            Console.WriteLine(miles + " miles is " + metres + " metres");

        }
    }
}
