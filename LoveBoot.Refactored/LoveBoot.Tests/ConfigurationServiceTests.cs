using LoveBoot.Core.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoveBoot.Tests
{
    [TestClass]
    public class ConfigurationServiceTests
    {
        [TestMethod]
        public void GetConfiguration_Returns_Default_Configuration()
        {
            // Arrange
            var service = new ConfigurationService();

            // Act
            var config = service.GetConfiguration();

            // Assert
            Assert.IsNotNull(config);
            Assert.AreEqual(250, config.KeyCropSettings.X);
            Assert.AreEqual(0.94, config.KeyThreshold);
        }
    }
}
