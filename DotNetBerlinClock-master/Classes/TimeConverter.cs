using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        /// <summary>
        /// Converts string Time format from "hh:mm:ss" to LampCLock string time
        /// </summary>
        /// <param name="aTime">String representing the time in the format "hh:mm:ss" </param>
        /// <returns>String representing the time in the format LampClock</returns>
        public string convertTime(string aTime)
        {
            var berlinCLock = new BerlinClockConfiguration();

            return berlinCLock.PrintLampTime(aTime);
        }
    }
}
