using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.PointsAndLines.Classes
{
    class CColoredPoint:CPoint
    {
        public ConsoleColor Color { get; set; }

        public override string ToString()
        {
            return $"COLORED POINT X: {X}, Y: {Y} , Color {Color}";
        }
    }
}
