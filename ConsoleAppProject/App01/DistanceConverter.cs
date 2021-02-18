using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// App that will promt the user to input a distance 
    /// measured in a unit and the program will convert 
    /// it into another one specified by the user.
    /// </summary>
    /// <author>
    /// Kian Rozblat Version 0.7
    /// </author>
    public class DistanceConverter
    {
        //constants
        public const double FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        //attributes
        public const string FEET = "feet";
        public const string MILES = "miles";
        public const string METRES = "metres";
       
        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        public DistanceUnits DistanceUnits
        {
            get => default;
            set
            {
            }
        }



        /// <summary>
        /// The Process of converting Miles to Feet 
        /// </summary>
        public void ConvertDistance()
        {
            
            OutputHeading();

            fromUnit = SelectUnit(" Please select the from distance unit > ");
            toUnit = SelectUnit(" Please select the to distance unit > ");

            Console.WriteLine($" Convert {fromUnit} to {toUnit}");

            fromDistance = InputDistance($" Please enter the number of {fromUnit} > ");

            CalculateDistance();
            
            OutputDistance();
        }

        /// <summary>
        /// Calculate the fromUnit and toUnit to give 
        /// the correct converted distance that the 
        /// user has inputted
        /// </summary>
        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }

        }

        /// <summary>
        /// where the program will show a prompt 
        /// that shows the user the options to choose
        /// what units they will be converting
        /// </summary>
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            
            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        /// <summary>
        /// runs the choice that the user has made in the select uni method
        /// </summary>
        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        /// <summary>
        /// the display the user sees to show the options of units to convert to
        /// </summary>
        private static string DisplayChoices(string prompt)
        {
           
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }


        /// <summary>
        /// outputs the converted distance
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance:0.00}  {fromUnit} " +
                $" is {toDistance:0.00} {toUnit}\n");
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
        /// Shows the heading of the window
        /// </summary>
        private void OutputHeading()
        {
            
            Console.WriteLine("\n------------------------");
            Console.WriteLine($"----Distance Converter---");
            Console.WriteLine("-----BY Kian Rozblat----");
            Console.WriteLine("------------------------\n");
        }
    }
}
