using AK.UIP.HW1.VehiclesConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.VehiclesConsoleApp.Vehicles
{
    public class CCar:CVehicle, IMove
    {
        int _speed;
        public int WhilsCount { get; set; }
        public int MovingSpeed { get => _speed; set => _speed = value; }

        public string GetWhilsCount()
        {
            return $"{Name}: WhilsCount = {WhilsCount}";
        }
    }
}
