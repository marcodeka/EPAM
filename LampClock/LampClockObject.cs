using LampClock.Interfaces;
using LampTimeConverter.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampTimeConverter
{
    public class LampClockObject : ILampClockObject
    {
        /// <summary>
        /// List of Lamps use to configure a Lamp CLock
        /// </summary>
        protected Lamp[] Lamps;

        /// <summary>
        /// Set the time which will be displayed on the Lamp Clock, parsed from a string
        /// </summary>
        /// <param name="timeString">String representing the time. Format: "hh:mm:ss"</param>
        private void ConvertToLampTime(string timeString)
        {
            try
            {
                // Using Split instead of 'TimeSpan.Parse' because of the possibility to insert 24:00:00
                // which, by specification, needs to produce a different result from 00:00:00
                string[] result = timeString.Split(':');

                ConvertToLampTime(int.Parse(result[0]), int.Parse(result[1]), int.Parse(result[2]));
            }
            catch (Exception)
            {
                throw new ClockTimeFormatException(timeString);
            }
        }

        /// <summary>
        /// Set the time which will be displayed on the Lamp Clock from int values
        /// </summary>
        private void ConvertToLampTime(int hours, int minutes, int seconds)
        {
            if (Lamps != null)
            {
                foreach (var lamp in Lamps)
                {

                    switch (lamp.LampType)
                    {
                        case LampType.Seconds:
                            seconds = lamp.SetState(seconds);
                            break;
                        case LampType.Minutes:
                            minutes = lamp.SetState(minutes);
                            break;
                        case LampType.Hours:
                            hours = lamp.SetState(hours);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Print a representation of the Lamp Clock time in strings
        /// </summary>
        /// <param name="timeString">String time value to represent. Format: "hh:mm:ss"</param>
        /// <returns></returns>
        public string PrintLampTime(string timeString)
        {
            ConvertToLampTime(timeString);

            var lampTime = string.Empty;

            if (Lamps != null)
            {
                LampType prevLampType = LampType.None;
                int prevLampTimeValue = -1;

                for (int i = 0; i < Lamps.Length; i++)
                {
                    if (prevLampType != LampType.None && (prevLampType != Lamps[i].LampType || prevLampTimeValue != Lamps[i].LampTimeValue))
                    {
                        lampTime += LampConfig.NEW_LINE;
                    }

                    lampTime += Lamps[i].ToString();

                    prevLampType = Lamps[i].LampType;
                    prevLampTimeValue = Lamps[i].LampTimeValue;
                }
            }

            return lampTime;
        }
    }
}
