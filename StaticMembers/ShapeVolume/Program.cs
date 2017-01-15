using System;

namespace ShapeVolume
{
    public class TriangularPrism
    {
        public double a;
        public double h;
        public double length;
        public TriangularPrism(double a, double h, double len)
        {
            this.a = a;
            this.h = h;
            this.length = len;
        }
    }
    public class Cube
    {
        public double side;

        public Cube(double side)
        {
            this.side = side;
        }
    }
    public class Cylinder
    {
        public double r;
        public double h;

        public Cylinder(double r, double h)
        {
            this.r = r;
            this.h = h;
        }
    }


    public class VolumeCalculator
    {
        public static void CalcCube(double side)
        {
            var volume = side * side * side;
            Console.WriteLine($"{volume:F3}");
        }
        public static void CalcCylinder(double r, double h)
        {
            var volume = Math.PI * r * r * h;
            Console.WriteLine($"{volume:F3}");
        }
        public static void CalcPrizm(double a, double h, double l)
        {
            var volume = (double) (a * h * l)/2;
            Console.WriteLine($"{volume:F3}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            
            while (line != "End")
            {
                string[] input = line.Split(' ');
                if (input.Length==2)
                {
                    string command = input[0];
                    double a = double.Parse(input[1]);
                    VolumeCalculator.CalcCube(a);
                }
                else if (input[0] == "Cylinder")
                {
                    double a = double.Parse(input[1]);
                    double b = double.Parse(input[2]);
                    VolumeCalculator.CalcCylinder(a, b);
                }
                else
                {
                    double a = double.Parse(input[1]);
                    double b = double.Parse(input[2]);
                    double c = double.Parse(input[3]);
                    VolumeCalculator.CalcPrizm(a, b,c);
                }

                line = Console.ReadLine();
            }
        }
    }

}