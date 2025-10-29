using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionModule.Exceptions
{
    public class NoPropertiesException : Exception
    {
        public NoPropertiesException()
        {
            
        }

        public NoPropertiesException(string message)
            : base(message)
        {
        }

        public NoPropertiesException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
