using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.PointsAndLines.Classes
{
    public class CPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"POINT X: {X}, Y: {Y} ";
        }
    }
}
