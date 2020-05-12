using Observer.BidiractionalBinding;
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
            var p = new PropertyDependencies.Person();
            p.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine();
            };
        }
      
    }
}
