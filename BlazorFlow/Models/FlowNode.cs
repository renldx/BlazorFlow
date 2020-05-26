using System.Collections.Generic;

namespace BlazorFlow.Models
{
    public class FlowNode
    {
        public FlowNode (int flowNodeId, double flowNodeVersion, FlowQuestion flowQuestion, FlowValueType flowNodeType = FlowValueType.None, FlowNodeEntity flowNodeEntity = FlowNodeEntity.None, List<FlowAnswer> flowAnswers = null!)
        {
            FlowNodeId = flowNodeId;
            FlowNodeVersion = flowNodeVersion;
            FlowQuestion = flowQuestion;
            FlowNodeType = flowNodeType;
            FlowNodeEntity = flowNodeEntity;
            FlowAnswers = flowAnswers;
        }

        public int FlowNodeId { get; set; }
        public double FlowNodeVersion { get; set; }
        public FlowValueType FlowNodeType { get; set; }
        public FlowNodeEntity FlowNodeEntity { get; set; }
        public FlowQuestion FlowQuestion { get; set; }
        public List<FlowAnswer> FlowAnswers { get; set; }
    }
}
