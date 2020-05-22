using System;

namespace Iit.EventPublisher
{
    public class Counter
    {
        private readonly EventPublisherClass eventPublisher;

        public int Count { get; set; } = 0;

        public Counter(EventPublisherClass eventPublisher1)
        {
            eventPublisher = eventPublisher1 ?? throw new NotImplementedException();
            RegisterEvent();

            //DeRegisterEvents();

        }

        public void DeRegisterEvents()
        {
            eventPublisher.CounterEvent -= OnCounterEvent;
            eventPublisher.CounterEvent -= OnCounterEvent2;
        }

        public void RegisterEvent()
        {
            if (eventPublisher != null)
            {
                eventPublisher.CounterEvent += OnCounterEvent;
                eventPublisher.CounterEvent += OnCounterEvent2;

            }
        }

        private void OnCounterEvent(object sender, CounterEventArgs e)
        {
            Console.WriteLine($"Count Number {Count}");

        }

        private void OnCounterEvent2(object sender, CounterEventArgs e)
        {
            var getType = sender.GetType();
            string senderName = null;
            if (getType.Name == "EventPublisher") senderName = ((EventPublisherClass)sender).EventName;


            //var senderObject = sender as EventPublisher;
            Count += e.CounterId;
            Console.WriteLine($"Sender {senderName ?? "Default Value"}, Count Name {e.CounterName}, Counter Id: { e.CounterId}");
            Count++;
        }
    }
}