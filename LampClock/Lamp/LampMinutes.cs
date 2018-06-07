using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampTimeConverter
{
    /// <summary>
    /// Lamp used to represent minutes
    /// </summary>
    public class LampMinutes : Lamp
    {
        public LampMinutes(LampColor color, int timeValue)
            : base(LampType.Minutes, color, timeValue) { }

    }
}
