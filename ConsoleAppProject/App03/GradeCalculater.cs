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


        //properties
        public string[] Students;
        public int[] Marks;
        public int[] GradeProfile;
        public int[] StatsMarks;

        public double Mean;
        public int Minimum;
        public int Maximum;
        
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
        public void InputMarks()
        {
            throw new NotImplementedException();
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

        public void DisplayMenu()
        {
            throw new NotImplementedException();
        }
    }
}
