using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace TestProject
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

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
    }
}
