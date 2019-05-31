using AK.UIP.HW1.VehiclesConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.VehiclesConsoleApp.Vehicles
{
    class CAmfibia : CCar, ISwim
    {
        int _swimmingSpeed;
        public int SwimmingSpeed { get => _swimmingSpeed; set => _swimmingSpeed = value; }
    }
}
