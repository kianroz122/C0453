using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        //constants
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        public const string INPUTMARK = "Input Mark For Student";
        public const string SEEALL = "see all marks for students";
        public const string SEEMIN = "See the minimum mark";
        public const string SEEMAX = "See the maximum mark";
        public const string MEANMARK = "see the mean mark";
        public const string QUIT = "Quit";
        public const string GRADEPROFILE = "See the grade profile";


        //properties
        public string[] Students;
        public int[] Marks;
        public int[] GradeProfile;
        public int[] StatsMarks;

        public double Mean;
        public int Minimum;
        public int Maximum;
        public string options;
        
        /// <summary>
        /// 
        /// </summary>
        public StudentGrades()
        { 
            Students = new string[]
            {
           
                "aaliyah","jimmy","tom",
                "ricardo","jeff","trevor",
                "juan","hank","peter","rashid"

            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string InputMarks()
        {
            int mark;
            int index = 0;
            foreach (string student in Students)
            {

                mark = (int)ConsoleHelper.InputNumber("Please enter a mark for  " + (student) + " > ", 0, 100);
                Marks[index] = mark;
                index++;
            }

            DisplayMenu();
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// 
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
                return Grades.F;
            else if (mark >= LowestGradeD && mark < LowestGradeC)
                return Grades.D;
            else if (mark >= LowestGradeC && mark < LowestGradeB)
                return Grades.C;
            else if (mark >= LowestGradeB && mark < LowestGradeA)
                return Grades.B;
            else if (mark >= LowestGradeA && mark < HighestMark)
                return Grades.A;
            else
            return Grades.X;
        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;
            
            foreach(int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
                total = total + mark;
            }
            Mean = total / Marks.Length;
        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateGradeProfile()
        {
            for(int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach(int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
            OutputGradeProfile();
        }

        private void OutputGradeProfile()
        {
            Grades grade = Grades.X;
            Console.WriteLine();

            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }

            Console.WriteLine();
        }

        public string DisplayMenu()
        {
            ConsoleHelper.OutputHeading("Student Grade Calculater");
            options = SelectUnit("Please select the Option you wish to use");

            if (options.Equals(INPUTMARK))
            {
                InputMarks();
            }

            else if (options.Equals(SEEALL))
            {
                OutputAll();
            }

            else if (options.Equals(SEEMIN))
            {
                OutputMin();
            }

            else if (options.Equals(SEEMAX))
            {
                OutputMax();
            }

            else if (options.Equals(MEANMARK))
            {
                OutputMean();
            }

            else if (options.Equals(GRADEPROFILE))
            {
                OutputGradeProfile();
            }

            else if (options.Equals(QUIT))
            {
                Quit();
            }

            else


            Console.WriteLine();
            Console.WriteLine();
           
            return DisplayMenu();
        }

        public string StudentSelect()
        {
            throw new NotImplementedException();
        }

        private void OutputMean()
        {
            CalculateStats();
            Console.WriteLine($"The average mark was {Mean}");
           
        }

        private void OutputMax()
        {
            CalculateStats();
            Console.WriteLine($"The Highest mark was {Maximum}");
        }


        private void OutputMin()
        {
            CalculateStats();
            Console.WriteLine($"The Lowest mark was {Minimum}");
        }

        private void OutputAll()
        {
            CalculateStats();
        }

        public void Quit()
        {
            Environment.Exit(0);
        }

        public string SelectUnit(string prompt)
        {
            string[] choices =
            {
             INPUTMARK,
             SEEALL,
             SEEMIN,
             SEEMAX,
             MEANMARK,
             GRADEPROFILE,
             QUIT
            };

            Console.WriteLine();
            Console.WriteLine();

            int choiceNo = ConsoleHelper.SelectChoice(choices);

            string unit = choices[choiceNo - 1];
            return unit;
        }
    }
}
