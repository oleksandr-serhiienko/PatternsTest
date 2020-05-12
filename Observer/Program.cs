using Observer.IObserverObservable;
using Observer.WeakEvents;
using System;
using System.Runtime.InteropServices;

namespace Observer
{
    class Program : IObserver<Event>
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            var person = new IObserverObservable.Person();
            var sub = person.Subscribe(this);

            person.FallIll();
        }

        public void OnCompleted() {}

        public void OnError(Exception error) {}

        public void OnNext(Event value)
        {
            if(value is FallsIllEvent args)
                Console.WriteLine($"A doctor is req at {args.Adress}");
        }
    }
}
