using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncryptionModule.Test.TestClass;

namespace EncryptionModule.Test
{
    public class DecryptTest
    {
        [Fact]
        public void DecryptSuccess()
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
            person.Decode();

            // Assert
            Assert.Equals("Kevin Beye", person.Name);
            Assert.IsNotNull(person.Name);
            Assert.IsNotNull(person.Name);

            // Make sure only name is encrypted
            Assert.Equals("kevin.beye1999@hotmail.com", person.Email);
        }

        [Fact]
        public void DecryptWithCustomConfigSuccess()
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
            person.Decode();

            // Assert
            Assert.AreNotEqual("Kevin Beye", person.Name);
            Assert.IsNotNull(person.Name);
            Assert.IsNotNull(person.Name);

            // Make sure only name is encrypted
            Assert.Equals("kevin.beye1999@hotmail.com", person.Email);
        }

        [Fact]
        public void DecryptWithoutPasswordFail()
        {
            // Arrange
            PersonWithoutPassword person = new PersonWithoutPassword
            {
                Id = 1,
                Name = "Kevin Beye",
                Email = "kevin.beye1999@hotmail.com",
                Phone = "+31 6 11 06 17 88"
            };

            // Act / Assert
            Assert.ThrowsException<ArgumentException>(() => person.Encode());
            Assert.ThrowsException<ArgumentException>(() => person.Decode());
        }

        [Fact]
        public void DecryptWithoutPropertiesThrowsException()
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
            Assert.ThrowsException<PersonWithoutProperties>(() => person.Decode());
        }
    }
}
