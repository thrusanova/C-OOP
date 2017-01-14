using System;
using System.Collections.Generic;

namespace RectangleIntersection
{
    public class Rectangle
    {
        public string ID;
        public double width;
        public double height;
        public double x;
        public double y;
        public Rectangle(string ID, double width, double height, double x, double y)
        {
            this.ID = ID;
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }
        public bool intersects(Rectangle other)
        {
            if (this.x + this.width < other.x || other.x + other.width < this.x ||
                    this.y + this.height < other.y || other.y + other.height < this.y)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            var dict = new Dictionary<string,Rectangle>();
            int numbers = int.Parse(nums[0]);
            int intersNumbers = int.Parse(nums[1]);
            for (int i = 0; i < numbers; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string id = inputs[0];
                double width = double.Parse(inputs[1]);
                double height = double.Parse(inputs[2]);
                double x = double.Parse(inputs[3]);
                double y = double.Parse(inputs[4]);
                var rect = new Rectangle(id, width, height, x, y);
                dict.Add(id, rect);
            }
            for (int i = 0; i < intersNumbers; i++)
            {
                string [] ids = Console.ReadLine().Split(' ');
                string firstId = ids[0];
                string secondId = ids[1];
                Rectangle first = dict[firstId];
                Rectangle second = dict[secondId];
                var res = first.intersects(second)== true ? "true" : "false";
                Console.WriteLine(res); 
            }
        }
    }
}
