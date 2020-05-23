using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuikGraph;

namespace BlazorFlow.Models
{
    public class FlowLink : Edge<FlowNode>
    {
        //int FlowLinkId;
        public double FlowLinkVersion { get; }
        public FlowCondition? FlowCondition { get; }

        public FlowLink(double flowLinkVersion, FlowNode fromFlowNode, FlowNode toFlowNode, FlowCondition? flowCondition = null) : base(fromFlowNode, toFlowNode)
        {
            FlowLinkVersion = flowLinkVersion;
            FlowCondition = flowCondition;
        }
    }
}
