using System;
using TemplateMethod.GAme;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var chess = new Chess(2);
            chess.Run();
        }
    }
}
