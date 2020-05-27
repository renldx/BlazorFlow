using System.Collections.Generic;
using QuikGraph;

namespace BlazorFlow.Models
{
    public class FlowLink : Edge<FlowNode>
    {
        public FlowLink(double flowLinkVersion, FlowNode fromFlowNode, FlowNode toFlowNode, List<IFlowCondition> flowConditions = null!) : base(fromFlowNode, toFlowNode)
        {
            FlowLinkVersion = flowLinkVersion;
            FlowConditions = flowConditions;
        }

        public int FlowLinkId { get; set; }
        public double FlowLinkVersion { get; set; }
        public List<IFlowCondition> FlowConditions { get; set; }

        public bool IsAvailable() {
            foreach (var condition in FlowConditions)
            {
                if (condition.Evaluate() == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
