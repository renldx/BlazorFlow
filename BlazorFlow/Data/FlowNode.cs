using System.Collections.Generic;

namespace BlazorFlow.Data
{
    public class FlowNode
    {
        public int FlowNodeId { get; set; }
        public double FlowNodeVersion { get; set; }

        public Flow Flow { get; set; } = null!;
        public FlowNodeType FlowNodeType { get; set; }
        public FlowNodeEntity FlowNodeEntity { get; set; }
        public FlowQuestion FlowQuestion { get; set; } = null!;
        public List<FlowAnswer> FlowAnswers { get; set; } = null!;
    }
}
