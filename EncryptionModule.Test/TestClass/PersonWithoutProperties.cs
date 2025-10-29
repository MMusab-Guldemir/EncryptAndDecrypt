using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionModule.Test.TestClass
{
    class PersonWithoutProperties : EntityBase
    {
        public PersonWithoutProperties()
        { }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
