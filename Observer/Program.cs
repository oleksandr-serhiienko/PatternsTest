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

            product.PropertyChanged += (sender, eventArgs) =>
            {
                if (eventArgs.PropertyName == "Name")
                {
                    Console.WriteLine("Name changed in Product");
                    window.ProductName = product.Name;
                }
            };

            window.PropertyChanged += (sender, eventArgs) =>
            {
                if (eventArgs.PropertyName == "ProductName")
                {
                    Console.WriteLine("Name is changed in Window");
                    product.Name = window.ProductName;
                }
            };

            product.Name = "SmartBook";
            Console.WriteLine(window);
            Console.WriteLine(product);

        }
      
    }
}
