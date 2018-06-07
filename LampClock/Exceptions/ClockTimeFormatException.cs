using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampTimeConverter.Exceptions
{
    /// <summary>
    /// Custom Exception class to manage the errors from the parsing of string time
    /// </summary>
    public class ClockTimeParsingException : Exception
    {
        public ClockTimeParsingException(string time)
                : base($"The time inserted '{time}' is not in the correct numeric format \"hh:mm:ss\"") { }
    }
}
