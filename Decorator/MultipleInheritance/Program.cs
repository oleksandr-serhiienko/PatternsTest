using System;

namespace Decorator.MultipleInheritance
{
    class Program
    {

        static void Main(string[] args)
        {
            var d = new Dragon();
            d.Crawl();
            d.Fly();

        }
    }
}
