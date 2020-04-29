﻿using Proxy.ProtectionProxy;
using System;

namespace Proxy
{



    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new CarProxy(new Driver(12));
            car.Drive();
        }
    }
}
