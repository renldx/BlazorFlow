using System.Collections.Generic;

namespace BlazorFlow.Data
{
    public class Flow
    {
        public int FlowId { get; set; }
        public double FlowVersion { get; set; }

        public List<FlowNode> FlowNodes { get; set; } = null!;
        public List<FlowLink> FlowLinks { get; set; } = null!;
    }
}
