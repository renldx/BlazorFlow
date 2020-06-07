using System.Collections.Generic;
using BlazorFlow.Enums;

namespace BlazorFlow.Data
{
    public class FlowNode
    {
        public int FlowNodeId { get; set; }
        public double FlowNodeVersion { get; set; }

        public int FlowId { get; set; }
        public Flow Flow { get; set; } = null!;
        public int FlowQuestionId { get; set; }
        public FlowQuestion FlowQuestion { get; set; } = null!;
        public FlowValueType FlowNodeType { get; set; }
        public FlowEntity FlowNodeEntity { get; set; }
        public List<FlowNodeAnswer> FlowNodeAnswers { get; set; } = null!;
    }
}
