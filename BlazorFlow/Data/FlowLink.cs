using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuikGraph;

namespace BlazorFlow.Data
{
    public class FlowLink : Edge<FlowNode>
    {
        int FlowLinkId;
        public double FlowLinkVersion { get; set; }
        IFlowCondition? FlowCondition;

        public FlowLink(int flowLinkId, double flowLinkVersion, FlowNode fromFlowNode, FlowNode toFlowNode, IFlowCondition? flowCondition = null) : base(fromFlowNode, toFlowNode)
        {
            FlowLinkId = flowLinkId;
            FlowLinkVersion = flowLinkVersion;
            FlowCondition = flowCondition;
        }

        public bool IsAvailable()
        {
           return FlowCondition?.Evaluate() ?? true;
        }
    }
}
