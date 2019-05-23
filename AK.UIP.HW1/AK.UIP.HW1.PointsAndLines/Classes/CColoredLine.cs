using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.PointsAndLines.Classes
{
    public class CColoredLine:CLine
    {
        public ConsoleColor Color { get; set; }

        public override string ToString()
        {
            return $"COLORED LINE START: {StartPoint}, END: {EndPoint}, COLOR";
        }
    }
}
