using System;
using System.Collections.Generic;
using MoreLinq;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Draw();
            Draw();

        }

        public static void Draw()
        {
            foreach (var vo in vectorObject)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    adapter.ForEach(DrawPoint);
                }
            }
        }

        private static readonly List<VectorObject> vectorObject = new List<VectorObject>()
                    {
                        new Rectangle(1, 1, 10, 10),
                        new Rectangle(6, 6, 3, 3)
                    };

        public static void DrawPoint(Point p)
        {
            Console.Write(".");
        }
    }
}
