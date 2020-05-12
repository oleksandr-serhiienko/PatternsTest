using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Fallsill += CallDoctor;
            person.CatchACold();
            person.Fallsill -= CallDoctor;
        }

        private static void CallDoctor(object sender, FallsillEventArgs e)
        {
            Console.WriteLine($"Doctor was cold to {e.Address}");
        }
    }
}
