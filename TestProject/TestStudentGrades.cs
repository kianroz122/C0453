using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace TestProject
{
    [TestClass]
    public class TestStudentGrades
    {
        private StudentGrades converter = new StudentGrades();

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
        public void TestCalculateMin()
        {


            converter.Marks = statsMarks;
            int expectedMin = 10;

            converter.CalculateStats();

            Assert.AreEqual(expectedMin, converter.Minimum);
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            converter.Marks = testMarks;

            converter.CalculateGradeProfile();

            bool expectedProfile;
            expectedProfile = ((converter.GradeProfile[0] == 3) &&
                               (converter.GradeProfile[1] == 1) &&
                               (converter.GradeProfile[2] == 1) &&
                               (converter.GradeProfile[3] == 1) &&
                               (converter.GradeProfile[4] == 4));
            
            Assert.IsTrue(expectedProfile);
        }
    }
}
