using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
    public class NullStaffRegistrationException : Exception
    {
        public int age { get; }
        public override string Message => "Sorry staff registration pending";
        public NullStaffRegistrationException() { }
        public NullStaffRegistrationException(string message) : base(message) 
        { }
        public NullStaffRegistrationException(string message, Exception innerException) : base(message, innerException) 
        { }

        public NullStaffRegistrationException(string message, int age) : this(message)
        {
            this.age = age;
        }
    }
}
