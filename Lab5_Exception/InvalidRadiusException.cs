using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Exception
{
    internal class InvalidRadiusException : Exception
    {
        public InvalidRadiusException():base("The radius is greater than zero.") { }
        public InvalidRadiusException(string message) : base($"The radius({message}) is equal to or less than zero.") { }
    }
}
