using Observer.WeakEvents;
using System;


namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var button = new Button();
            var window = new Window(button);
            var windowref = new WeakReference(window);
            button.Fire();
            Console.WriteLine("setting window to null");
            window = null;

            FireGC();
        }

        private static void FireGC()
        {
            Console.WriteLine("statrting gc");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            Console.WriteLine("finished gc");
        }

        private static void CallDoctor(object sender, FallsillEventArgs e)
        {
            Console.WriteLine($"Doctor was cold to {e.Address}");
            
        }
    }
}
