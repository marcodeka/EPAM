using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampTimeConverter
{
    /// <summary>
    /// States & Colors values of the Lamp
    /// </summary>
    public class LampConfig
    {
        public const string OFF = "O";
        public const string ON_Yellow = "Y";
        public const string ON_Red = "R";
        public const string NEW_LINE = "\r\n";
    }

    public enum LampState
    {
        On,
        Off
    }

    public enum LampColor
    {
        Yellow,
        Red
    }

    public enum LampType
    {
        None,
        Seconds,
        Minutes,
        Hours
    }
}
