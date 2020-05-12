using Observer.IObserverObservable;
using Observer.WeakEvents;
using System;
using System.Runtime.InteropServices;

namespace Observer
{
    class Program 
    {
        static void Main(string[] args)
        {
            var market = new Market.Market();
            market.PriceAdded += (sender, f) =>
            {
                Console.WriteLine($"We got a price of {f}");
            };
            market.AddPrice(123);
        }
      
    }
}
