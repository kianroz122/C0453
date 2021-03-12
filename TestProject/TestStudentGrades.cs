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
        public void TestConvert40ToGradeD()
        {
            //arrange

            Grades expectedGrade = Grades.D;

            //act
            Grades actualGrade = converter.ConvertToGrade(40);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert49ToGradeD()
        {
            //arrange

            Grades expectedGrade = Grades.D;

            //act
            Grades actualGrade = converter.ConvertToGrade(49);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert50ToGradeC()
        {
            //arrange

            Grades expectedGrade = Grades.C;

            //act
            Grades actualGrade = converter.ConvertToGrade(50);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert59ToGradeC()
        {
            //arrange

            Grades expectedGrade = Grades.C;

            //act
            Grades actualGrade = converter.ConvertToGrade(59);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert60ToGradeB()
        {
            //arrange

            Grades expectedGrade = Grades.B;

            //act
            Grades actualGrade = converter.ConvertToGrade(60);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert69ToGradeB()
        {
            //arrange

            Grades expectedGrade = Grades.B;

            //act
            Grades actualGrade = converter.ConvertToGrade(69);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert70ToGradeA()
        {
            //arrange

            Grades expectedGrade = Grades.A;

            //act
            Grades actualGrade = converter.ConvertToGrade(70);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert100ToGradeA()
        {
            //arrange

            Grades expectedGrade = Grades.A;

            //act
            Grades actualGrade = converter.ConvertToGrade(100);

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
        public void TestCalculateMax()
        {


            converter.Marks = statsMarks;
            int expectedMax = 100;

            converter.CalculateStats();

            Assert.AreEqual(expectedMax, converter.Maximum);
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            converter.Marks = testMarks;

            converter.CalculateGradeProfile();

            bool expectedProfile;
            expectedProfile = ((converter.GradeProfile[0] == 0) &&
                               (converter.GradeProfile[1] == 3) &&
                               (converter.GradeProfile[2] == 1) &&
                               (converter.GradeProfile[3] == 1) &&
                               (converter.GradeProfile[4] == 1) &&
                               (converter.GradeProfile[5] == 4));
            
            Assert.IsTrue(expectedProfile);
        }
    }
}
