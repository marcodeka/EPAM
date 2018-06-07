using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampTimeConverter
{
    /// <summary>
    /// Lamp used to represent hours
    /// </summary>
    public class LampHours : Lamp
    {
        public LampHours(LampColor color, int timeValue) 
            : base(LampType.Hours, color, timeValue) { }

    }
}
