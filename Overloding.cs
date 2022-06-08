using System;

namespace Overloadmethods{
    public class Overloding {
        public double area(double s) {
            double area = s * s;
            return area;
        }

        public double area(double l, double b) {
            double area = l * b;
            return area;
        }
    }

    class Program {
        public static void Main(string[] args) {
            Overloding o = new Overloding();
            double length = 3.3;
            double breadth = 4.9;
            double rect = o.area(length, breadth);
            Console.WriteLine("Area of rectangle " + rect);

            double side = 3.3;
            double square = o.area(side);
            Console.WriteLine(square);
        }
    }
}