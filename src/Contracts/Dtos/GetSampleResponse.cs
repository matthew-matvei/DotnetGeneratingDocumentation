using System;

namespace Contracts.Dtos
{
    public class GetSampleResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
