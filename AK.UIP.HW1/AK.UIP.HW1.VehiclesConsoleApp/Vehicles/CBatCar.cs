using AK.UIP.HW1.VehiclesConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.VehiclesConsoleApp.Vehicles
{
    public class CBatCar : CCar, ISwim, IFly
    {
        int _swimmingSpeed;
        int _flyingSpeed;
        public int SwimmingSpeed { get => _swimmingSpeed; set => _swimmingSpeed = value; }
        public int FlyingSpeed { get => _flyingSpeed; set => _flyingSpeed = value; }
    }
}
