using System;

namespace Contracts.Events
{
    /// <summary>
    /// Represents the creation of an example.
    /// </summary>
    public class SampleCreated
    {
        /// <summary>
        /// When the sample was created, according to the service that processed the creation.
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The domain-neutral info about the sample at the time it was created.
        /// </summary>
        /// <remarks>Since the <see cref="Events"/> namespace acts as an anti-corruption
        /// layer, <see cref="Sample"/>'s properties may differ slightly from the representation
        /// internal to this service.</remarks>
        public SampleInfo Sample { get; set; }
    }
}
