﻿using System;
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
    }
}
