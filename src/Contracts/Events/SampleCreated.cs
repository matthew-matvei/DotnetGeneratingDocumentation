using System;

namespace Contracts.Events
{
    public class SampleCreated
    {
        public DateTimeOffset ClientTimestamp { get; set; }
        public SampleInfo Sample { get; set; }
    }
}
