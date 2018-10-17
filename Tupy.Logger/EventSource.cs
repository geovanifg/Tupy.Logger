using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tupy.Jobs;

namespace Tupy.Logger
{
    public class EventSource
    {
        public string Name { get; set; }
        public int MinimumRetention { get; set; }
        public FrequencyOptions RetentionPeriodoType { get; set; }

        internal Task RemoveBefore(DateTime expiration)
        {
            throw new NotImplementedException();
        }

        //public List<EventEntry> GetEntries()
        //{

        //}
    }
}
