using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Line
    {
        public Point Start, End;
        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Start != null ? Start.GetHashCode() : 0) * 397) ^ (End != null ? End.GetHashCode() : 0);
            }
        }

        protected bool Equals(Line other)
        {
            return Start == other.Start && End == other.End;
        }
    }
}
