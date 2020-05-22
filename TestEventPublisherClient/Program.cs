using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventPublisher;
using Iit.EventPublisher;

namespace TestEventPublisherClient
{


    class Program
    {
        static void Main(string[] args)
        {
            var eventPublisher = new EventPublisherClass(null); // publisher

            var counter = new Counter(eventPublisher); // subscriber

            // Here, registering subscribers by passing eventPublisher to the subscriber class
            //counter.RegisterEvent();
            eventPublisher.RaiseEvent(new CounterDetails() { CounterId = 1, CounterName = " C1" }); 
            // Raise some event with some data in this case, CounterDetails

            eventPublisher.RaiseEvent(new CounterDetails() { CounterId = 2, CounterName = " C2" });
            counter.DeRegisterEvents();
        }
    }
}
