﻿using System;
using System.Windows;

namespace RectangleIntersection
{
    internal class Size
    {
        private int v1;
        private int v2;

        public Size(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public static implicit operator System.Windows.Size(Size v)
        {
            throw new NotImplementedException();
        }
    }
}