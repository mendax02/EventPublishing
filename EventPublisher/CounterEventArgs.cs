using EventPublisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iit.EventPublisher
{
    public class CounterEventArgs : EventArgs
    {
        public int CounterId { get; }
        public string CounterName { get; }
        public CounterEventArgs(CounterDetails cd)
        {
            CounterId = cd.CounterId;
            CounterName = cd.CounterName;
        }
    }
}
