namespace Contracts.Events
{
    /// <summary>
    /// Demonstrates documentation for a derived type.
    /// </summary>
    /// <remarks>
    /// We can show the inherited properties, and filter out <see cref="System.Object"/>
    /// base methods
    /// </remarks>
    public class DetailedSampleCreated : SampleCreated
    {
        public string DetailedDescription { get; set; }

        /// <value>A detailed version of <see cref="SampleInfo"/>.</value>
        public new DetailedSampleInfo Sample { get; set; }
    }
}
