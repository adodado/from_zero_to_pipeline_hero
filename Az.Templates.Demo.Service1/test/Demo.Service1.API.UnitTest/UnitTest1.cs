using HelloWorld.Controllers;

namespace TestHelloWord
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WeatherForecast()
        {
            // Arrange
            var controller = new WeatherForecastController();
            // Act
            var result = controller.Get();

            // Assert
            Assert.AreEqual(5, result.Count());
        }
    }
}