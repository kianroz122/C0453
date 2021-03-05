﻿using ConsoleAppProject.App01;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Kian Rozblat 04/02/21
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();
        
        private static App02.BMI calculator = new App02.BMI();

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2020-2021!");

            string[] choices = { "Distance Converter", "BMI Calculator" };
            int choiceNo = ConsoleHelper.SelectChoice(choices);

            if (choiceNo == 1)
            {
                converter.ConvertDistance();
            }
            else if (choiceNo == 2)
            {
                calculator.CalculateBmi();
            }
            else Console.WriteLine("Invalid Try Again");
        }
    }
}
