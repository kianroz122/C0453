using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        public string[] Students;
        public int[] Marks;
        public int[] GradeProfile;


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
            if (mark >= 0 && mark < 40)
                return Grades.F;
            else
            return Grades.X;
        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateStats()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateGradeProfile()
        {
            throw new NotImplementedException();
        }
    }
}
