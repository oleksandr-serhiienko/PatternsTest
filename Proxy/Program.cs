
using Proxy.CompositeProxy;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICar car = new CarProxy(new Driver(12));
            //car.Drive();

            //var c = new Creature();
            //c.Agility = 10;
            // AoS
            var createrues = new Proxy.CompositeProxy.Creatrue[100];
            foreach (var c in createrues)
            {
                c.X++;
            }
            var creatures2 = new Creatures(100); // SoA
            foreach (Creatures.CreatureProxy c in creatures2)
            {
                c.X++;
            }

        }
    }
}
