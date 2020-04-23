using System;
using System.Collections.Generic;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


        }

        private static readonly List<VectorObject> vectorObject = new List<VectorObject>()
                    {
                        new Rectangle(1, 1, 10, 10),
                        new Rectangle(6, 6, 3, 3)
                    };

        public static void DrawPoint(Point p)
        {
            Console.WriteLine(".");
        }
    }
}
