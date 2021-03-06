﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace TestProject
{
    [TestClass]
    public class TestStudentGrades
    {
        private StudentGrades converter;

        private int[] testMarks;
        private int[] statsMarks;


        public TestStudentGrades()
        {
            testMarks = new int[]
            {
                10,20,30,40,50,60,70,80,90,100
            };

            statsMarks = new int[]
            {
                10,20,30,40,50,60,70,80,90,100
             };

        }

        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            //arrange
            converter =  new StudentGrades();
            Grades expectedGrade = Grades.F;

            //act
            Grades actualGrade = converter.ConvertToGrade(0);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert39ToGradef()
        {
            //arrange
            converter = new StudentGrades();
            Grades expectedGrade = Grades.F;

            //act
            Grades actualGrade = converter.ConvertToGrade(39);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestCalculationMean()
        {
            converter = new StudentGrades();
            converter.Marks = testMarks;
            double expectedMean = 55.0;
            converter.CalculateStats();

            Assert.AreEqual(expectedMean, converter.Mean);
        }

        [TestMethod]
        public void TestCalculateMin()
        {
            converter = new StudentGrades();

            converter.Marks = statsMarks;
            int expectedMin = 10;

            converter.CalculateStats();

            Assert.AreEqual(expectedMin, converter.Minimum);
        }
    }
}
