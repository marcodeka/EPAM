using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampTimeConverter
{
    /// <summary>
    /// Lamp used to represent seconds
    /// </summary>
    public class LampSeconds : Lamp
    {
        public LampSeconds(LampColor color) : base(LampType.Seconds, color, 0) { }

        /// <summary>
        /// Set the states of a Seconds Lamp. The behaviour is different by specifications.
        /// </summary>
        /// <param name="timeValue">Time to represent with the Lamp</param>
        /// <returns></returns>
        public override int SetState(int timeValue)
        {
            if (timeValue % 2 == 0)
            {
                base.TurnOn();
            }
            else
            {
                base.TurnOff();
            }
            return timeValue;
        }
    }
}
