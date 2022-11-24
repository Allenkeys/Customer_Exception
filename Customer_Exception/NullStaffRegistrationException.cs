using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
    public class NullStaffRegistrationException : Exception
    {
        public NullStaffRegistrationException() { }
        public NullStaffRegistrationException(string message) : base(message) 
        { }
        public NullStaffRegistrationException(string message, Exception innerException) : base(message, innerException) 
        { }
    }
}
