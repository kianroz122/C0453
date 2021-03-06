using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace TestProject
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

        private readonly int[] testMarks;
        private readonly int[] StatsMarks;


        public TestStudentGrades()
        {
            testMarks = new int[]
            {
                10,20,30,40,50,60,70,80,90,100
            };

            StatsMarks = new int[]
            {
                10,20,30,40,50,60,70,80,90,100
             };

        }

        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            //arrange
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
            Grades expectedGrade = Grades.F;

            //act
            Grades actualGrade = converter.ConvertToGrade(39);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestCalculationMean()
        {
            converter.Marks = testMarks;
            double expectedMean = 55.0;
            converter.CalculateStats();

            Assert.AreEqual(expectedMean, converter.Mean);
        }

        [TestMethod]
        public static void TestCalculateMin()
        {

            StudentGrades.Marks = StatsMarks;
            int expectedMin = 10;

            StudentGrades.CalculateStats();

            Assert.AreEqual(expectedMin, StudentGrades.Minimum);
        }
    }
}
