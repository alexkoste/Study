using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.VehiclesConsoleApp.Vehicles
{
    public class CPlain:CVehicle
    {
        public int MaxHeight { get; set; }

        public string GetMaxHeight()
        {
            return $"{Name}: MaxHeight = {MaxHeight}";
        }
    }
}
