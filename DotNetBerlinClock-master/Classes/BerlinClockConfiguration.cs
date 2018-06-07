using LampTimeConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    public class BerlinClockConfiguration : LampClockObject
    {
        public BerlinClockConfiguration()
        {
            Lamps = new Lamp[24];

            //Top Lamp
            Lamps[0] = new LampSeconds(LampColor.Yellow);

            //Top First Row 5h
            Lamps[1] = new LampHours(LampColor.Red, 5);
            Lamps[2] = new LampHours(LampColor.Red, 5);
            Lamps[3] = new LampHours(LampColor.Red, 5);
            Lamps[4] = new LampHours(LampColor.Red, 5);

            //Top Second Row 1h
            Lamps[5] = new LampHours(LampColor.Red, 1);
            Lamps[6] = new LampHours(LampColor.Red, 1);
            Lamps[7] = new LampHours(LampColor.Red, 1);
            Lamps[8] = new LampHours(LampColor.Red, 1);

            //First Bottom Row 5m
            Lamps[9] = new LampMinutes(LampColor.Yellow, 5);
            Lamps[10] = new LampMinutes(LampColor.Yellow, 5);
            Lamps[11] = new LampMinutes(LampColor.Red, 5);
            Lamps[12] = new LampMinutes(LampColor.Yellow, 5);
            Lamps[13] = new LampMinutes(LampColor.Yellow, 5);
            Lamps[14] = new LampMinutes(LampColor.Red, 5);
            Lamps[15] = new LampMinutes(LampColor.Yellow, 5);
            Lamps[16] = new LampMinutes(LampColor.Yellow, 5);
            Lamps[17] = new LampMinutes(LampColor.Red, 5);
            Lamps[18] = new LampMinutes(LampColor.Yellow, 5);
            Lamps[19] = new LampMinutes(LampColor.Yellow, 5);

            //Second Bottom Row 1m
            Lamps[20] = new LampMinutes(LampColor.Yellow, 1);
            Lamps[21] = new LampMinutes(LampColor.Yellow, 1);
            Lamps[22] = new LampMinutes(LampColor.Yellow, 1);
            Lamps[23] = new LampMinutes(LampColor.Yellow, 1);
        }


    }
}
