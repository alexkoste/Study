using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.VehiclesConsoleApp.Vehicles
{
    public class CCar:CVehicle
    {
        public int WhilsCount { get; set; }

        public string GetWhilsCount()
        {
            return $"{Name}: WhilsCount = {WhilsCount}";
        }
    }
}
