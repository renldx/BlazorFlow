using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuikGraph;

namespace BlazorFlow.Data
{
    public class FlowLink : Edge<FlowNode>
    {
        public readonly FlowCondition? FlowCondition;

        public FlowLink(int flowLinkId, FlowNode fromFlowNode, FlowNode toFlowNode, FlowCondition? flowCondition = null) : base(fromFlowNode, toFlowNode)
        {
            FlowLinkId = flowLinkId;
            FlowCondition = flowCondition;
        }

        public int FlowLinkId { get; set; }
        public double FlowLinkVersion { get; set; }

        //public bool IsAvailable()
        //{
        //    return FlowCondition?.Evaluate() ?? true;
        //}
    }
}
