﻿using AK.UIP.HW1.VehiclesConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.VehiclesConsoleApp.Vehicles
{
    public class CPlain:CVehicle, IFly
    {
        int _flyingSpeed;
        public int MaxHeight { get; set; }
        public int FlyingSpeed { get => _flyingSpeed; set => _flyingSpeed = value; }

        public string GetMaxHeight()
        {
            return $"{Name}: MaxHeight = {MaxHeight}";
        }
    }
}
