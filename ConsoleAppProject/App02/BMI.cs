using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Kian Rozblat version 0.1
    /// </author>
    public class BMI
    {
        //Constants
        public const double Underweight = 18;
        public const double Healthy = 25;
        public const double Overweight = 29;
        public const double Obese1 = 34;
        public const double Obese2 = 39;
        public const double Obese3 = 40;

        public const int InchesInFeet = 12;
        public const int PoundsInStone = 14;
        public const int OneHundred = 100;
        public const int SevenZeroThree = 703;

        public const string METRIC = "metric";
        public const string IMPERIAL = "imperial";

        //attributes
        public double index;
        public string who;
        public string unit;

        public double kilograms;
        public double metres;
        public double centimetres;
        public double stones;
        public double pounds;
        public double feet;
        public double inches;
        public double bmi;

        public Units Units
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Input the weight in imperial units
        /// </summary>
        public void CalculateBmi()
        {

            ConsoleHelper.OutputHeading("BMI Calculator");
            SelectUnit();
            
            if (unit == "metric")
            {
                centimetres = InputMetricHeight();
                kilograms = InputMetricWeight();
                CalculateMetric();
            }
            else
            {
                inches = InputImperialHeight();
                pounds = InputImperialWeight();
                CalculateImperial();
            }
            OutputBmi();
            CalculateWho();
            OutputWho();
            OutputWarning();
        }

        /// <summary>
        /// Input the weight in imperial units
        /// </summary>
        private double InputImperialWeight()
        {
            Console.Write("Enter Weight in lbs > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Input the height in imperial units
        /// </summary>
        private double InputImperialHeight()
        {
            Console.Write("Enter Height in Inches > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Input the weight in metric units
        /// </summary>
        private double InputMetricWeight()
        {
            Console.Write("Enter Weight in Kg > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Input the height in metric units
        /// </summary>
        private double InputMetricHeight()
        {
            Console.Write("Enter Height in Centimeters > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Executes the choice of imperial or metric that the user makes
        /// </summary>
        private string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return IMPERIAL;
            }

            else if (choice.Equals("2"))
            {
                return METRIC;
            }
            Console.WriteLine("Invalid");
            return null;
        }

        /// <summary>
        /// displays the choices of the units the user can choose between
        /// </summary>
        private string DisplayChoices()
        {
            string[] choices =
            {
             IMPERIAL,
             METRIC,

            };
            Console.WriteLine("Choose your Units\n");
            Console.WriteLine(" 1. Imperial");
            Console.WriteLine(" 2. Metric");
            Console.WriteLine();

            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// process of selecting the units
        /// </summary>
        private string SelectUnit()
        {
            Console.WriteLine();
            string choice = DisplayChoices();

            unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        /// <summary>
        /// Calculates the BMI from Imperial units that was input
        /// </summary>
        private void CalculateImperial()
        {
            index = (double)pounds * SevenZeroThree / (inches * inches);
        }


        /// <summary>
        /// calculates the BMI from Metric units that was input
        /// </summary>
        private void CalculateMetric()
        {
            metres = centimetres / OneHundred;
            index = (kilograms / (metres* metres));
        }

        /// <summary>
        /// outputs the converted distance
        /// </summary>
        private void OutputBmi()
        {
            Console.WriteLine($"Your BMI is {index:0.00}");
        }

        /// <summary>
        /// calculates the WHO to show the body type of the user e.g overweight healthy
        /// </summary>
        private void CalculateWho()
        {
            if (index <= Underweight)
            {
                who = "underweight";
            }
            else if (index > Underweight && index <= Healthy)
            {
                who = "healthy";
            }
            else if (index > Healthy && index <= Overweight)
            {
                who = "overweight";
            }
            else if (index > Overweight && index <= Obese1)
            {
                who = "obese level 1";
            }
            else if (index > Obese1 && index <= Obese2)
            {
                who = "obese level 2";
            }
            else if (index >= Obese3)
            {
                who = "obese level 3";
            }
        }

        /// <summary>
        /// Outputs the Who of the user
        /// </summary>
        private void OutputWho()
        {
            Console.WriteLine("With your BMI you are classed as Being " + who);
        }

        /// <summary>
        /// Outputs Health warnings to the user
        /// </summary>
        private void OutputWarning()
        {
            Console.WriteLine(" If you are Black, Asian or other minority ethnic groups, you have a higher risk");
            Console.WriteLine("\n Adults 23.0 or more are at increased risk");
            Console.WriteLine("\n Adults 27.5 or more are at high risk");
        }
    }
}