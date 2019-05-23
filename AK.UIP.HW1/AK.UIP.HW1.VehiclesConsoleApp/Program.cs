using AK.UIP.HW1.VehiclesConsoleApp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK.UIP.HW1.VehiclesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CVehicle> vehicles = GetVehicles();
            string input;
            do
            {
                PrintMenu();
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        GetCoordinatesOfVehicles(vehicles);
                        break;
                    case "2":
                        GetVehiclePrice(vehicles);
                        break;
                    case "3":
                        GetCountOfPasengers(vehicles);
                        break;
                    case "4":
                        GetSpeadOfVehicles(vehicles);
                        break;
                    case "5":
                        GetPortOfVehicle(vehicles);
                        break;
                    case "6":
                        GetYearOfVehicle(vehicles);
                        break;
                    case "7":
                        GetMaxHeight(vehicles);
                        break;
                    case "8":
                        GetWilsCount(vehicles);
                        break;
                    default:
                        break;
                }

            } while (input!="EXIT");
            
        }

        private static void GetWilsCount(List<CVehicle> vehicles)
        {
            foreach (var item in vehicles)
            {
                CCar car = item as CCar;
                if (car != null)
                {
                    Console.WriteLine(car.GetWhilsCount());
                    Console.WriteLine("\n");
                }
            }
        }

        private static void GetMaxHeight(List<CVehicle> vehicles)
        {
            foreach (var item in vehicles)
            {
                CPlain plain = item as CPlain;
                if (plain != null)
                {
                    Console.WriteLine(plain.GetMaxHeight());
                    Console.WriteLine("\n");
                }
            }
        }

        private static void GetYearOfVehicle(List<CVehicle> vehicles)
        {
            foreach (var item in vehicles)
            {
                Console.WriteLine(item.GetYearOfEdition());
                Console.WriteLine("\n");
            }
        }

        private static void GetPortOfVehicle(List<CVehicle> vehicles)
        {
            foreach (var item in vehicles)
            {
                CShip ship = item as CShip;
                if (ship != null)
                {
                    Console.WriteLine(ship.GetPort());
                    Console.WriteLine("\n");
                }
            }
        }

        private static void GetSpeadOfVehicles(List<CVehicle> vehicles)
        {
            foreach (var item in vehicles)
            {
                Console.WriteLine(item.GetSpeed());
                Console.WriteLine("\n");
            }
        }

        private static void GetCountOfPasengers(List<CVehicle> vehicles)
        {
            foreach (var item in vehicles)
            {
                Console.WriteLine(item.GetPassangersCount());
                Console.WriteLine("\n");
            }
        }

        private static void GetVehiclePrice(List<CVehicle> vehicles)
        {
            foreach (var item in vehicles)
            {
                Console.WriteLine(item.GetPrice());
                Console.WriteLine("\n");
            }
        }

        private static void GetCoordinatesOfVehicles(List<CVehicle> vehicles)
        {
            foreach (var item in vehicles)
            {
                Console.WriteLine(item.GetCoordinates());
                Console.WriteLine("\n");
            }
        }

        private static void PrintMenu()
        {
            string menu = "#####################################################\n"+
                "For berak write EXIT\n" +
                                        "To get Coordinates Of Vehicles press 1\n" +
            "To get Vehicle Price press 2\n" +
            "To get Count Of Pasengers press 3\n" +
            "To get Spead Of Vehicles press 4\n" +
            "To get Port Of Vehicle press 5\n" +
            "To get Year Of Vehicle press 6\n" +
            "To get Max Height press 7\n" +
            "To get Wils Count press 8\n"+
            "#####################################################\n";

            Console.WriteLine(menu);

        }

        public static List<CVehicle> GetVehicles()
        {
            var vehicles = new List<CVehicle>();

            vehicles.Add(
                new CShip() {
                Name = "Ship",
                CoordinateX = 1,
                CoordinateY = 1,
                PassangersCount = 1,
                Price = 1,
                Speed = 1,
                YearOfEdition = 1,
                Port = "1" });

            vehicles.Add(
                new CCar() {
                    Name = "Car",
                    CoordinateX = 2,
                    CoordinateY = 2,
                    PassangersCount = 2,
                    Price = 2,
                    Speed = 2,
                    YearOfEdition = 2,
                    WhilsCount = 4 });

            vehicles.Add(
                new CPlain() {
                    Name = "Plain",
                    CoordinateX = 3,
                    CoordinateY = 3,
                    PassangersCount = 3,
                    Price = 3,
                    Speed = 3,
                    YearOfEdition = 3,
                    MaxHeight = 150 });


            return vehicles;
        }


    }
}
