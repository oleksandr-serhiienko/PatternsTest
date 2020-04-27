using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.MultipleInheritance
{
    public class Lizzard : ILizzard
    {
        public void Crawl()
        {
            Console.WriteLine("Crawling in the dirt");
        }
    }
}
