using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampTimeConverter.Exceptions
{
    public class ClockTimeValuesException : Exception
    {
        public ClockTimeValuesException(string time)
                : base($"The time inserted '{time}' has values outside the ranges.") { }
    }
}
