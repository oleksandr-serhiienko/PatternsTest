using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.IObserverObservable
{
    public class Person : IObservable<Event>
    {

        private readonly HashSet<Subscription> subscriptions = new HashSet<Subscription>(); 
        public IDisposable Subscribe(IObserver<Event> observer)
        {
            var subscription = new Subscription(this, observer);
            subscriptions.Add(subscription);
            return subscription;
        }

        public void FallIll()
        {
            foreach (var s in subscriptions)
            {
                s.Observer.OnNext(new FallsIllEvent { Adress = "dfefe"});
            }
        }

        private class Subscription : IDisposable
        {
            private readonly Person person;
            public IObserver<Event> Observer;

            public Subscription(Person person, IObserver<Event> observer)
            {
                this.person = person;
                Observer = observer;
            }
            public void Dispose()
            {
                person.subscriptions.Remove(this);
            }
        }
    }
}
