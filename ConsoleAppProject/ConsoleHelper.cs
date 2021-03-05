using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {
        public static void OutputHeading(string title)
        {
            Console.WriteLine("\n------------------------");
            Console.WriteLine($"----{title}---");
            Console.WriteLine("-----BY Kian Rozblat----");
            Console.WriteLine("------------------------\n");
        }

        public static int SelectChoice(string[] choices)
        {
            //Display all the choices
            DisplayChoices(choices);

            //Get the user's choice
            int choiceNo = (int)InputNumber("\n Please enter your choice > ");
            return choiceNo;
        }

        /// <summary>
        /// Displays the Choices
        /// </summary>
        private static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"    {choiceNo}  {choice}");

            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static double InputNumber(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            double number = Convert.ToDouble(value);
            return number;
        }
    }
}
