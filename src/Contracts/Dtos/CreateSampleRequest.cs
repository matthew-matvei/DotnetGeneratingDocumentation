namespace Contracts.Dtos
{
    /// <summary>
    /// Represents a request to create a sample.
    /// </summary>
    public class CreateSampleRequest
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
