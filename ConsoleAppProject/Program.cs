using ConsoleAppProject.App01;
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
        public static App02.BMI BMI
        {
            get => default;
            set
            {
            }
        }

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine("Select an app to use ");
            Console.WriteLine("1 ~ App01 Distance Converter");
            Console.WriteLine("2 ~ App02 BMI Calculator");
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                DistanceConverter converter = new DistanceConverter();
                converter.ConvertDistance();
            }
            else if (choice == "2")
            {
                App02.BMI calculator = new App02.BMI();
                calculator.CalculateBmi();
            }
            else Console.WriteLine("Invalid Try Again");
        }
    }
}
