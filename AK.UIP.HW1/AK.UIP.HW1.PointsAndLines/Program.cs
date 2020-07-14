using AK.UIP.HW1.PointsAndLines.Classes;
using System;

namespace AK.UIP.HW1.PointsAndLines
{
    class Program
    {
        static void Main(string[] args)
        {
            CPoint point1 = new CPoint() { X = 1, Y = 1 };
            CPoint point2 = new CPoint() { X = 2, Y = 2 };

            CLine line1 = new CLine() { StartPoint = point1, EndPoint = point2 };
            Console.WriteLine(point1);
            Console.WriteLine(point2);
            Console.WriteLine(line1);

            CColoredPoint coloredPoint1 = new CColoredPoint() { X = 3, Y = 3, Color = ConsoleColor.Red };
            CColoredPoint coloredPoint2 = new CColoredPoint() { X = 4, Y = 4, Color = ConsoleColor.Blue };
            Console.ForegroundColor = coloredPoint1.Color;
            Console.WriteLine(coloredPoint1);
            Console.ForegroundColor = coloredPoint2.Color;
            Console.WriteLine(coloredPoint2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------");

            CColoredLine coloredLine1 = new CColoredLine() { StartPoint = point1, EndPoint = point2, Color = ConsoleColor.Green };
            Console.ForegroundColor = coloredLine1.Color;
            Console.WriteLine(coloredLine1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------");

            CPoliLine poliLine = new CPoliLine();
            poliLine.Lines.Add(line1);
            poliLine.Lines.Add(new CLine() {
                StartPoint = new CPoint() { X = 5, Y = 5 },
                EndPoint = new CPoint() { X = 6, Y = 6 }
            });

            Console.WriteLine(poliLine);

        }

    }
}
