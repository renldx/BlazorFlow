using QuikGraph;

namespace BlazorFlow.Models
{
    public class FlowLink : Edge<FlowNode>
    {
        public FlowLink(double flowLinkVersion, FlowNode fromFlowNode, FlowNode toFlowNode, FlowCondition? flowCondition = null) : base(fromFlowNode, toFlowNode)
        {
            FlowLinkVersion = flowLinkVersion;
            FlowCondition = flowCondition;
        }

        public int FlowLinkId { get; set; }
        public double FlowLinkVersion { get; }
        public FlowCondition? FlowCondition { get; }
    }
}
