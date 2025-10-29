using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Testing.Platform.Configurations;

namespace EncryptionModule.Test.TestClass
{
    class PersonWithCustomConfig : Person
    {
        protected override ConfigurationExtensions GetConfiguration()
        {
            return new Configuration("Test123", 128, 128, 500);
        }
    }
}
