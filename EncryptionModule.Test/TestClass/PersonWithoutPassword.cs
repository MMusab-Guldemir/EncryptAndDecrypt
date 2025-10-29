using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionModule.Test.TestClass
{
    public class PersonWithoutPassword : Person
    {
        protected override Configuration GetConfiguration()
        {
            Configuration config = base.GetConfiguration();
            config.PassPhrase = string.Empty;

            return config;
        }
    }
}
