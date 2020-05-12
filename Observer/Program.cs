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
            var product = new Product { Name = "Book" };
            var window = new BidiractionalBinding.Window { ProductName = "Book" };

            using var binding = new BidiractionalBinding.BdiireactionalBinding(
                product, () => product.Name, window, () => window.ProductName
            );

            product.Name = "SmartBook";

            Console.WriteLine(window);
            Console.WriteLine(product);

        }
      
    }
}
