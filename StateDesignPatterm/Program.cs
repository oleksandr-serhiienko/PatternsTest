using System;

namespace StateDesignPatterm
{
    class Program
    {

        static void Main(string[] args)
        {
            var ls = new Switch();
            ls.On();
            ls.Off();
            ls.Off();
        }
    }
}
