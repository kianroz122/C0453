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
       
        public double FromDistance;
        public double ToDistance;

        public string FromUnit;
        public string ToUnit;

        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
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
            
            ConsoleHelper.OutputHeading("Distance Converter");

            FromUnit = SelectUnit(" Please select the from distance unit > ");
            ToUnit = SelectUnit(" Please select the to distance unit > ");

            Console.WriteLine($" Convert {FromUnit} to {ToUnit}");

            FromDistance = ConsoleHelper.InputNumber($" Please enter the number of {FromUnit} > ");

            CalculateDistance();
            
            OutputDistance();
        }

        /// <summary>
        /// Calculate the fromUnit and toUnit to give 
        /// the correct converted distance that the 
        /// user has inputted
        /// </summary>
        public void CalculateDistance()
        {
            if (FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == METRES)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == METRES && ToUnit == MILES)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == METRES)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
            else if (FromUnit == METRES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }

        }

        /// <summary>
        /// where the program will show a prompt 
        /// that shows the user the options to choose
        /// what units they will be converting
        /// </summary>
        private string SelectUnit(string prompt)
        {
            string[] choices =
            {
             FEET,
             METRES,
             MILES
            };

            Console.WriteLine(prompt);
            Console.WriteLine();

            int choiceNo = ConsoleHelper.SelectChoice(choices);

            string unit = choices[choiceNo - 1];
            return unit;
        }

        /// <summary>
        /// outputs the converted distance
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance:0.00}  {FromUnit} " +
                $" is {ToDistance:0.00} {ToUnit}\n");
        }

    }
}
