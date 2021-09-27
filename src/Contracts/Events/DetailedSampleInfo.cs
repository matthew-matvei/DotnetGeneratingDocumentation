namespace Contracts.Events
{
    public class DetailedSampleInfo : SampleInfo
    {
        /// <value>
        /// The only custom property of this model, everything else comes from the
        /// underlying <see cref="SampleInfo"/>.
        /// </value>
        public string ExtraSampleInformation { get; set; }
    }
}
