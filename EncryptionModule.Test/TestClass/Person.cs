using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionModule.Test.TestClass
{
    public class Person : EntityBase
    {
        public Person() : base()
        {
            protectedValues = new List<string>()
            {
                "Name"
            };

            public long Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
    }
    }
}
