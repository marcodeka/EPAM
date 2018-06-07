using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampTimeConverter.Interfaces
{
    /// <summary>
    /// LampClock Interface
    /// </summary>
    public interface ILamp
    {
        /// <summary>
        /// Turns on the Lamp
        /// </summary>
        void TurnOn();

        /// <summary>
        /// Turns off the Lamp
        /// </summary>
        void TurnOff();

        /// <summary>
        /// Set the state of the Lamp off/on based on the time value
        /// </summary>
        /// <param name="timeValue">Value of time used to determine the Lamp state</param>
        /// <returns></returns>
        int SetState(int timeValue);

    }
}
