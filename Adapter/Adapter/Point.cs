using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Point
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y; 
            }
        }

        protected bool Equals(Point other)
        {
            return X == other.X && Y == other.Y;
        }
    }
}
