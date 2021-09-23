using System;

namespace Contracts.Dtos
{
    /// <summary>
    /// Represents the response of querying a single sample.
    /// </summary>
    public class GetSampleResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
