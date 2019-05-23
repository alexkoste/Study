using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.VehiclesConsoleApp.Vehicles
{
    public abstract class CVehicle
    {
        public string Name { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public int Price { get; set; }
        public int YearOfEdition { get; set; }
        public int Speed { get; set; }
        public int PassangersCount { get; set; }

        public string GetCoordinates() {
            return $"{Name}: Coordinate X = {CoordinateX}; Coordinate Y = {CoordinateY}";
        }

        public string GetPrice()
        {
            return $"{Name}: Price = {Price}";
        }

        public string GetYearOfEdition()
        {
            return $"{Name}: YearOfEdition = {YearOfEdition}";
        }

        public string GetSpeed()
        {
            return $"{Name}: Speed = {Speed}";
        }

        public string GetPassangersCount()
        {
            return $"{Name}: PassangersCount = {PassangersCount}";
        }
    }
}
