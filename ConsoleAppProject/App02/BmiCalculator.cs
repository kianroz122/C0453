using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Kian Rozblat version 0.1
    /// </author>
    public class BmiCalculator
    {
        //Constants
        public const double Underweight = 18.5;
        public const double Healthy = 24.9;
        public const double Overweight = 29.9;
        public const double Obese1 = 34.9;
        public const double Obese2 = 39.9;
        public const double Obese3 = 40.0;

        public const int InchesInFeet = 12;
        public const int PoundsInStone = 14;

        public const string METRIC = "metric";
        public const string IMPERIAL = "imperial";

        //attributes
        public double index;
        public string who;

        public double kilograms;
        public double metres;
        public double centimetres;
        public double stones;
        public double pounds;
        public double feet;
        public double inches;
        public double bmi;


        /// <summary>
        /// The Process of converting Miles to Feet 
        /// </summary>
        public void CalculateBmi()
        {

            Heading();
            SelectUnit();

            string unit = null;
            if (unit == "metric")
            {
                InputMetricHeight();
                InputMetricWeight();
                CalculateMetric();
            }
            else
            {
                InputImperialHeight();
                InputImperialWeight();
                CalculateImperial();
            }



            OutputBmi();
            OutputWho();
            OutputWarning();
        }

        private double InputImperialWeight()
        {
            Console.Write("Enter Weight in lbs > ");
            string pounds = Console.ReadLine();
            return Convert.ToDouble(pounds);
        }

        private double InputImperialHeight()
        {
            Console.Write("Enter Height in Inches > ");
            string inches = Console.ReadLine();
            return Convert.ToDouble(inches);
        }

        private double InputMetricWeight()
        {
            Console.Write("Enter Weight in Kg > ");
            string kilograms = Console.ReadLine();
            return Convert.ToDouble(kilograms);
        }

        private double InputMetricHeight()
        {
            Console.Write("Enter Height in Centimeters > ");
            string centimeters = Console.ReadLine();
            return Convert.ToDouble(centimeters);
        }

        private string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return METRIC;
            }

            else if (choice.Equals("2"))
            {
                return IMPERIAL;
            }
            Console.WriteLine("Invalid");
            return null;
        }


        private string DisplayChoices()
        {
            Console.WriteLine();
            Console.WriteLine(" 1. Imperial");
            Console.WriteLine(" 2. Metric");
            Console.WriteLine();

            string choice = Console.ReadLine();
            return choice;
        }

        private string SelectUnit()
        {
            Console.WriteLine();
            string choice = DisplayChoices();

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }


        private void Heading()
        {
            Console.WriteLine("\n------------------------");
            Console.WriteLine($"----BMI Calculator---");
            Console.WriteLine("-----BY Kian Rozblat----");
            Console.WriteLine("------------------------\n");
        }




        /// <summary>
        /// Calculate the fromUnit and toUnit to give 
        /// the correct converted distance that the 
        /// user has inputted
        /// </summary>
        private void CalculateImperial()
        {
            index = (pounds / (inches * inches));
        }

        private void CalculateMetric()
        {
            index = ((kilograms * 703) / (centimetres * centimetres));
        }


        /// <summary>
        /// the display the user sees to show the options of units to convert to
        /// </summary>
        private static string DisplayChoices(string prompt)
        {

            Console.WriteLine();
            Console.WriteLine(" 1. Imperial");
            Console.WriteLine(" 2. Metric");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }


        /// <summary>
        /// outputs the converted distance
        /// </summary>
        private void OutputBmi()
        {
            Console.WriteLine($"Your BMI is {index}");
        }

        private void CalculateWho()
        {
         if(index == 18.5)
            {
                who = "underweight";
            }
         else if (index == 24.9)
            {
                who = "healthy";
            }
            else if (index == 29.9)
            {
                who = "overweight";
            }
            else if (index == 34.9)
            {
                who = "obese level 1";
            }
            else if (index == 39.9)
            {
                who = "obese level 2";
            }
            else if (index == 40.0)
            {
                who = "obese level 3";
            }
        }

        private void OutputWho()
        {
            Console.WriteLine("With your BMI you are classed as Being " + who);
        }

        private void OutputWarning()
        {
            Console.WriteLine("\n");
            Console.WriteLine(" If you are Black, Asian or other minority ethnic groups, you have a higher risk");
            Console.WriteLine("\n");
            Console.WriteLine("\n Adults 23.0 or more are at increased risk");
            Console.WriteLine("\n");
            Console.WriteLine("\n Adults 27.5 or more are at high risk");
            Console.WriteLine("\n");
        }
    }   
}