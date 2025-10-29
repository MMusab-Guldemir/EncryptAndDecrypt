using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionModule.Test
{
    public class ConfigTest
    {
        [Fact]
        public void ConfigTestSuccess()
        {
            // Arrange
            string testPass = "Test123";
            Configuration config;

            // Act
            config = Configuration.WithPassword(testPass);

            // Assert
            Assert.Equals(testPass, config.PassPhrase);
            Assert.IsNotNull(config);
        }
    }
}
