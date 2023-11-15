//path: Schema\StreamAgentRequest.cs

namespace Neurocache.Gateway.Schema
{
    public class StreamAgentRequest
    {
        public string? InstanceId { get; set; }
        public string? OutputLevel { get; set; }

        public void Deconstruct(out string instanceId, out string outputLevel)
        {
            instanceId = InstanceId ?? "";
            outputLevel = OutputLevel ?? "";
        }
    }
}