using AK.UIP.HW1.VehiclesConsoleApp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.VehiclesConsoleApp.Core
{
    public class VehiclesCreator
    {
        public CVehicle[] Vehicles { get {
                CVehicle[] vehicles = new CVehicle[] {
                    new CCar(){ Name = "Car1", YearOfEdition = 3, Price = 1, Speed = 10},
                    new CCar(){ Name = "Car2", YearOfEdition = 1, Price = 2, Speed = 12},
                    new CCar(){ Name = "Car3", YearOfEdition = 2, Price = 3, Speed = 20 },
                    new CPlain(){ Name = "Pl1", YearOfEdition = 4, Price = 4, Speed = 30},
                    new CPlain(){ Name = "Pl2", YearOfEdition = 2, Price = 5,Speed = 40},
                    new CPlain(){ Name = "Pl3", YearOfEdition = 3, Price = 6, Speed = 50},
                    new CShip(){ Name = "SHip1", YearOfEdition = 83, Price = 7 ,Speed = 5 },
                    new CShip(){ Name = "SHip2", YearOfEdition = 33, Price = 8, Speed = 10},
                    new CShip(){ Name = "SHip3", YearOfEdition = 31, Price = 9, Speed = 5}
                };
                return vehicles;
            }
        }

        
    }
}
