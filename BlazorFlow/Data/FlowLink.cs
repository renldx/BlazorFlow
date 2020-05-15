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
        public FlowCondition? FlowCondition { get; }

        public FlowLink(int flowLinkId, double flowLinkVersion, FlowNode fromFlowNode, FlowNode toFlowNode, FlowCondition? flowCondition = null) : base(fromFlowNode, toFlowNode)
        {
            FlowLinkId = flowLinkId;
            FlowLinkVersion = flowLinkVersion;
            FlowCondition = flowCondition;
        }
    }
}
