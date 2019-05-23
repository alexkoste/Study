using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.PointsAndLines.Classes
{
    public class CPoliLine
    {
        public CPoliLine()
        {
            Lines = new List<CLine>();
        }
        public List<CLine> Lines { get; set; }

        public override string ToString()
        {
            string str = ""; ;
            foreach (var item in Lines)
            {
                str += $" {item};";
            }
            return str;
        }

    }
}
