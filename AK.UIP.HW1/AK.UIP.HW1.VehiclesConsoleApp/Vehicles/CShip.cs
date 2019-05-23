using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.VehiclesConsoleApp.Vehicles
{
    public class CShip:CVehicle
    {
        public string Port { get; set; }

        public string GetPort()
        {
            return $"{Name}: Port = {Port}";
        }
    }
}
