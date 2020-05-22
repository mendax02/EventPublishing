using EventPublisher;
using System;

namespace Iit.EventPublisher
{

    public class EventPublisherClass
    {
        public event EventHandler<CounterEventArgs> CounterEvent;
        public string EventName { get; set; } = "EventPublisher";

        public EventPublisherClass(string eventName)
        {
            if (eventName != null)
                EventName = eventName;
            //OnCounterEvent();
        }

        public void RaiseEvent(CounterDetails cd)
        {
            OnCounterEvent(cd);
        }

        protected virtual void OnCounterEvent(CounterDetails cd)
        {
            var counterEvent = CounterEvent;
            if (counterEvent != null)
            {
                CounterEventArgs counterEventArgs = new CounterEventArgs(cd);
                counterEvent(this, counterEventArgs);
            }
        }

    }
}
