using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.NewFolder
{
    public class EventBroker : IObservable<PlayerEvent>
    {
        

        public IDisposable Subscribe(IObserver<PlayerEvent> observer)
        {
            throw new NotImplementedException();
        }
    }
}
