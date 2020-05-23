using QuikGraph;

namespace BlazorFlow.Models
{
    public class Flow : AdjacencyGraph<FlowNode, FlowLink>
    {
        public int FlowId { get; set; }
        public double FlowVersion { get; set; }
    }
}
