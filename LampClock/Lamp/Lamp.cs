using LampTimeConverter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampTimeConverter
{
    public class Lamp : ILamp
    {
        /// <summary>
        /// State of the Lamp, on/off
        /// </summary>
        public LampState LampState { get; private set; }

        /// <summary>
        /// Type of the Lamp, hours/minutes/seconds
        /// </summary>
        public LampType LampType { get; private set; }

        /// <summary>
        /// Color of the light's Lamp
        /// </summary>
        public LampColor LampColor { get; private set; }

        /// <summary>
        /// Time that the Lamp represents when it's ON
        /// </summary>
        public int LampTimeValue { get; private set; }

        public Lamp(LampType type, LampColor color, int timeValue)
        {
            LampTimeValue = timeValue;
            LampType = type;
            LampColor = color;
        }

        public void TurnOff()
        {
            LampState = LampState.Off;
        }

        public void TurnOn()
        {
            LampState = LampState.On;
        }

        public virtual int SetState(int timeValue)
        {
            if (LampTimeValue <= timeValue) //if yes the Lamp can be turned on
            {
                TurnOn();
                return timeValue - LampTimeValue; //return the new time value
            }

            TurnOff();
            return timeValue;
        }

        public override string ToString()
        {
            if (LampState == LampState.Off)
            {
                return LampConfig.OFF;
            }
            switch (LampColor)
            {
                case LampColor.Yellow:
                    return LampConfig.ON_Yellow;
                case LampColor.Red:
                    return LampConfig.ON_Red;
            }

            return string.Empty;
        }
    }
}
