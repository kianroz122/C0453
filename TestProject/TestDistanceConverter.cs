using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
namespace TestProject
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();
 
            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.FEET;

            converter.FromDistance = 1.0;
            
            //Act
            converter.CalculateDistance();

            double expectedDistance = 5280;
            
            //Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
}
