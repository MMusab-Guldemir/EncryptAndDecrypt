using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncryptionModule.Test.TestClass;

namespace EncryptionModule.Test
{
    public class EncryptionTest
    {
        [Fact]
        public void TestSuccess()
        {
            // Arrange
            Person person = new Person
            {
                Id = 1,
                Name = "Kevin Beye",
                Email = "kevin.beye1999@hotmail.com",
                Phone = "+31 6 11 06 17 88"
            };

            // Act
            person.Encode();

            // Assert
            Assert.AreNotEqual("Kevin Beye", person.Name);
            Assert.IsNotNull(person.Name);
            Assert.IsNotNull(person.Name);

            // Make sure only name is encrypted
            Assert.Equals("kevin.beye1999@hotmail.com", person.Email);
        }

        [Fact]
        public void TestCustomConfigSuccess()
        {
            // Arrange
            PersonWithCustomConfig person = new PersonWithCustomConfig
            {
                Id = 1,
                Name = "Kevin Beye",
                Email = "kevin.beye1999@hotmail.com",
                Phone = "+31 6 11 06 17 88"
            };

            // Act
            person.Encode();

            // Assert
            Assert.AreNotEqual("Kevin Beye", person.Name);
            Assert.IsNotNull(person.Name);
            Assert.IsNotNull(person.Name);

            // Make sure only name is encrypted
            Assert.Equals("kevin.beye1999@hotmail.com", person.Email);
        }

        [Fact]
        public void PersonWithNonExistingPropertiesFail()
        {
            PersonWithNonExisitngProperties person = new PersonWithNonExisitngProperties
            {
                Id = 1,
                Name = "Kevin Beye",
                Email = "kevin.beye1999@hotmail.com",
                Phone = "+31 6 11 06 17 88"
            };

            // Act / assert
            Assert.ThrowsException<ArgumentNullException>(() => person.Encode());
        }

        [Fact]
        public void EncryptWithoutPropertiesThrowsException()
        {
            // Arrange
            PersonWithoutProperties person = new PersonWithoutProperties
            {
                Id = 1,
                Name = "Kevin Beye",
                Email = "kevin.beye1999@hotmail.com",
                Phone = "+31 6 11 06 17 88"
            };

            // Act / assert
            Assert.ThrowsException<NoPropertiesException>(() => person.Encode());
        }
    } 
}
