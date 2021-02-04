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
        private double miles;

        private double feet;

        /// <summary>
        /// Runs the method of converting the miles to feet
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        /// <summary>
        /// Promt the user to enter the distance in miles 
        /// Input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("please enter a number of miles");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        /// <summary>
        /// Calculates the Inputted miles into feet
        /// </summary>
        private void CalculateFeet()
        {

        }

        /// <summary>
        /// Outputs the calculated feet to the user 
        /// </summary>
        private void OutputFeet()
        { 

        }
    }
}
