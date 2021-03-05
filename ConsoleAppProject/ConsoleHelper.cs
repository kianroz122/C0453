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
            int choiceNo = (int)InputNumber("\n Please enter your choice > ",1, choices.Length);
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
            double number = 0;
            bool Isvalid= false;

            do
            {
                Console.Write(prompt);
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                }
                catch (Exception)
                {
                    Isvalid = false;
                    Console.WriteLine("Invalid Number");
                }

            } while (!Isvalid);
            
            return number;
        }

        /// <summary>
        /// 
        /// </summary>
        public static double InputNumber(string prompt, double min, double max)
        {
            bool isValid = false;
            double number = 0;

            do
            {
                number = InputNumber(prompt);

                if (number < min || number > max)
                {
                    isValid = false;
                    Console.WriteLine($" Number must be between {min} and {max} ");
                }
                else isValid = true;
            } while (!isValid);

            return number;
        }


    }
}
