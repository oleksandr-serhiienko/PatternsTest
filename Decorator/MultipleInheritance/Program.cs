using System;

namespace Decorator.MultipleInheritance
{
    class Program
    {

        static void Main1(string[] args)
        {
            var d = new Dragon();
            d.Crawl();
            d.Fly();

        }
    }
}
