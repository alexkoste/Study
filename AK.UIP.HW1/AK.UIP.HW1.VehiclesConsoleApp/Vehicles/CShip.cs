﻿using AK.UIP.HW1.VehiclesConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.VehiclesConsoleApp.Vehicles
{
    public class CShip:CVehicle, ISwim
    {
        int _swimmingSpeed;
        public string Port { get; set; }
        public int SwimmingSpeed { get => _swimmingSpeed; set => _swimmingSpeed = value; }

        public string GetPort()
        {
            return $"{Name}: Port = {Port}";
        }
    }
}
