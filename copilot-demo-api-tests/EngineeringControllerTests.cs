using copilot_demo_api;
using copilot_demo_api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace copilot_demo_api_tests
{
    [TestClass]
    public class EngineeringControllerTests
    {
        [TestMethod]
        public void TestGetAllReturnsSomething()
        {
            // Arrange
            var controller = new EngineeringController(new Logger<EngineeringController>(new NullLoggerFactory()));

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}