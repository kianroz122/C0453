using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// App that will convert miles to feet, miles to metres, and feet to miles
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
        /// The Process of converting Feet to Miles
        /// </summary>
        public void ConvertFeetToMiles()
        {
            OutputHeading("Convert Feet to Miles");
            feet = InputDistance("Please enter the number of feet > ");
            miles = feet / FEET_IN_MILES;
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        public void ConvertMilesToFeet()
        {
            OutputHeading("Convert Miles to Feet");
            miles = InputDistance("Please enter the number of miles > ");
            feet = miles * FEET_IN_MILES;
            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        public void ConvertMilesToMeters()
        {
            OutputHeading("Convert Miles to Metres");
            miles = InputDistance("Please enter the number of miles > ");
            metres = miles * METRES_IN_MILES;
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }

        /// <summary>
        /// outputs the converted distance
        /// </summary>
        /// <param name="fromDistance"></param>
        /// <param name="fromUnit"></param>
        /// <param name="toDistance"></param>
        /// <param name="toUnit"></param>
        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($"{fromDistance:0.00}  {fromUnit} " +
                $"is {toDistance:0.00} {toUnit}");
        }

        /// <summary>
        /// This is where the user will input the distance to be converted
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Shows the ehading of the window
        /// </summary>
        /// <param name="title"></param>
        private void OutputHeading(string title)
        {
            Console.WriteLine("\n------------------------");
            Console.WriteLine($"--{title}-");
            Console.WriteLine("-----BY Kian Rozblat----");
            Console.WriteLine("------------------------\n");
        }
    }
}
