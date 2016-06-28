using System;
using System.Windows;

namespace RectangleIntersection
{
    public class Point
    {
        private int x;
        private int y;

        public Point(int v1, int v2)
        {
            this.x = v1;
            this.y = v2;
        }

        public static implicit operator System.Windows.Point(Point v)
        {
            throw new NotImplementedException();
        }
    }
}