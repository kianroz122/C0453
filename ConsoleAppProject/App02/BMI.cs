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


        /// The Process of Calculating BMI
        public void CalculateBmi()
        {

            Heading();
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

        //Input the weight in imperial units
        private double InputImperialWeight()
        {
            Console.Write("Enter Weight in lbs > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        //Input the height in imperial units
        private double InputImperialHeight()
        {
            Console.Write("Enter Height in Inches > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        //Input the weight in metric units
        private double InputMetricWeight()
        {
            Console.Write("Enter Weight in Kg > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        //Input the height in metric units
        private double InputMetricHeight()
        {
            Console.Write("Enter Height in Centimeters > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        //Executes the choice of imperial or metric that the user makes
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

        //displays the choices of the units the user can choose between
        private string DisplayChoices()
        {
            Console.WriteLine("Choose your Units\n");
            Console.WriteLine(" 1. Imperial");
            Console.WriteLine(" 2. Metric");
            Console.WriteLine();

            string choice = Console.ReadLine();
            return choice;
        }

        //process of selecting the units
        private string SelectUnit()
        {
            Console.WriteLine();
            string choice = DisplayChoices();

            unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        //outputs the heading of the app
        private void Heading()
        {
            Console.WriteLine("\n------------------------");
            Console.WriteLine($"----BMI Calculator---");
            Console.WriteLine("-----BY Kian Rozblat----");
            Console.WriteLine("------------------------\n");
        }


        /// Calculates the BMI from Imperial units that was input
        private void CalculateImperial()
        {

            index = (double)pounds * 703 / (inches * inches);
        }

        //calculates the BMI from Metric units that was input
        private void CalculateMetric()
        {
            metres = centimetres / 100;
            index = (kilograms / (metres* metres));
        }

        /// outputs the converted distance
        private void OutputBmi()
        {
            Console.WriteLine($"Your BMI is {index:0.00}");
        }

        //calculates the WHO to show the body type of the user e.g overweight healthy
        private void CalculateWho()
        {
            if (index < 18.5)
            {
                who = "underweight";
            }
            else if (index >= 18.5 && index <= 24.9)
            {
                who = "healthy";
            }
            else if (index >= 25.0 && index <= 29.9)
            {
                who = "overweight";
            }
            else if (index >= 30.0 && index <= 34.9)
            {
                who = "obese level 1";
            }
            else if (index >= 35.0 && index <= 39.9)
            {
                who = "obese level 2";
            }
            else if (index >= 40.0)
            {
                who = "obese level 3";
            }
        }

        //Outputs the Who of the user
        private void OutputWho()
        {
            Console.WriteLine("With your BMI you are classed as Being " + who);
        }

        //Outputs Health warnings to the user
        private void OutputWarning()
        {

            Console.WriteLine(" If you are Black, Asian or other minority ethnic groups, you have a higher risk");
            Console.WriteLine("\n Adults 23.0 or more are at increased risk");
            Console.WriteLine("\n Adults 27.5 or more are at high risk");

        }
    }
}