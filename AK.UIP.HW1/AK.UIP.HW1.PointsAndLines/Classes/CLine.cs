using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.PointsAndLines.Classes
{
    public class CLine
    {
        public virtual CPoint StartPoint { get; set; }
        public virtual CPoint EndPoint { get; set; }

        public override string ToString()
        {
            return $"LINE START: {StartPoint}, END: {EndPoint}";
        }
    }
}
