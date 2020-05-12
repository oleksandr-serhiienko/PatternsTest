using Observer.IObserverObservable;
using Observer.WeakEvents;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Observer
{
    class Program 
    {
        static void Main(string[] args)
        {
            var market = new Market.Market();
            market.Prices.ListChanged += (sender, EventArgs) =>
            {
                if (EventArgs.ListChangedType == ListChangedType.ItemAdded)
                {
                    float price = ((BindingList<float>)sender)[EventArgs.NewIndex];
                    Console.WriteLine($"Biniding list has a price of {price}");
                }
            };
        }
      
    }
}
