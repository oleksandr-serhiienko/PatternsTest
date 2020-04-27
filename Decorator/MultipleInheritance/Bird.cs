using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.MultipleInheritance
{
    public class Bird : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Soaring in the sky");
        }
    }
}
