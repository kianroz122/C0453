using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        public string[] Students
        public int[] Marks
        public int[] GradeProfile


        public double Mean
        public int Minimum
        public int Maximum
        
        /// <summary>
        /// 
        /// </summary>
        public StudentGrades()
        { 
            Students = new string[]
            {
           
                "aaliyah","jimmy","tom",
                "ricardo","jeffhardy","trevor",
                "juan","hank","peter","rashid"

            };

            GradeProfile = new int[(int)StudentGrades.A + 1];
            Marks = mew int[Students.Length];
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
        public StudentGrades ConvertToGrade(int mark)
        {
            throw new NotImplementedException();
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
