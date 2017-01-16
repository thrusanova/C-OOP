using System;

namespace Encapsulation
{
    public class Box
    {
        private double lenght;
        private double height;
        private double width;

        public Box(double lenght, double height, double width)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.lenght;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative. ");
                }
                this.lenght = value;
            }

        }
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative. ");
                }
                else
                {
                    this.width = value;
                }
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative. ");
                }
                this.height = value;
            }
        }

        public void CalcSurfaceArea()
        {
            var res = 2 * (this.lenght * this.width + this.lenght * this.height + this.width * this.height);
            Console.WriteLine($"Surface Area - {res:F2}");
        }
        public void CalcVolume()
        {
            var res = lenght * height * width;
            Console.WriteLine($"Volume - {res:F2}");

        }
        public void LateralSurfaceArea()
        {
            var res = 2 * (lenght * height + width * height);
            Console.WriteLine($"Lateral Surface Area - {res:F2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("3");
                var box = new Box(a, c, b);
                
                box.CalcSurfaceArea();
                box.LateralSurfaceArea();
                box.CalcVolume();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}