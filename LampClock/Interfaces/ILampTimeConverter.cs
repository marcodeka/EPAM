using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampClock.Interfaces
{
    interface ILampClockObject
    {
        /// <summary>
        /// Print a representation of the Lamp Clock time in strings
        /// </summary>
        /// <param name="timeString">String time value to represent. Format: "hh:mm:ss"</param>
        /// <returns></returns>
        string PrintLampTime(string timeString);
    }
}
