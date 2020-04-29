using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.ProtectionProxy
{
     public class Car : ICar
     {
         public void Drive()
         {
             Console.WriteLine("Car is driving");
         }
     }
}
