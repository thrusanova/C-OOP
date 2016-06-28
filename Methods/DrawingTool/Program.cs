using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    public abstract class Figure
    {
        private int a;
        private int b;


        public Figure(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

       

        public int SideA
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
            }
        }
        public int SideB
        {
            get
            {
                return this.b;
            }
            set
            {
                this.b = value;
            }
        }

        public class Square : Figure
        {
            public int size;


            public Square(int a, int b) : base(a, b)
            {
                this.size = a;
                this.size = b;
            }
        }
        public class Rectangle : Figure
        {
            public int c;
            public int d;

            public Rectangle(int c, int d) :base(c,d)
            {
                this.c = c;
                this.d = d;
              
            }
        }

        public class CorDraw
        {

            Figure figure;

          
          public  CorDraw(Figure figure)
            {
                this.figure = figure;
            }
            public  void drawFigure()
            {
                int vertLine = this.figure.a;
                int horLine = this.figure.b;
                Console.Write("|");
                Console.Write(new string('-', vertLine));
                Console.WriteLine("|");
                for (int i = 0; i < horLine-2; i++)
                {

                    Console.Write("|");
                    Console.Write(new string(' ',vertLine));
                    Console.WriteLine("|");
                }
                Console.Write("|");
                Console.Write(new string('-', vertLine));
                Console.Write("|");
            }

          
        }
        class Program
        {
            static void Main(string[] args)
            {

                string input = Console.ReadLine();
                Figure figure;
                switch(input)
                {
                    case "Square":
                        int size = int.Parse(Console.ReadLine());
                         figure = new Square(size, size);
                        CorDraw drawFig = new CorDraw(figure);
                        drawFig.drawFigure();
                        break;
                    case "Rectangle":
                        int sizeA = int.Parse(Console.ReadLine());
                        int sizeB = int.Parse(Console.ReadLine());
                         figure = new Rectangle(sizeA, sizeB);
                        CorDraw drawFg = new CorDraw(figure);
                        drawFg.drawFigure();
                        break;

                }
               



            }
        }
    }
}