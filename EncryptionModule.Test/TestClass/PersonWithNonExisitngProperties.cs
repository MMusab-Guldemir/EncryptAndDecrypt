using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionModule.Test.TestClass
{
    public class PersonWithNonExisitngProperties
    {
        public PersonWithNonExisitngProperties()
        {
            protectedValues = new List<string>()
            {
                "idonotexist"
            };
        }
    }
}
