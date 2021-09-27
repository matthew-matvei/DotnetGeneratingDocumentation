namespace Contracts.Events
{
    public class DetailedSampleCreated : SampleCreated
    {
        public string DetailedDescription { get; set; }
        public new DetailedSampleInfo Sample { get; set; }
    }
}
