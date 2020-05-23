using BlazorFlow.Enums;

namespace BlazorFlow.Models
{
    public class FlowNode
    {
        public int FlowNodeId;
        public double FlowNodeVersion { get; }
        public FlowNodeType FlowNodeType { get; }
        public FlowNodeEntity FlowNodeEntity { get; }
        public FlowQuestion FlowQuestion { get; }
        public FlowAnswer[]? FlowAnswers { get; }

        public FlowNode (int flowNodeId, double flowNodeVersion, FlowQuestion flowQuestion, FlowNodeType flowNodeType = FlowNodeType.none, FlowNodeEntity flowNodeEntity = FlowNodeEntity.none, FlowAnswer[]? flowAnswers = null)
        {
            FlowNodeId = flowNodeId;
            FlowNodeVersion = flowNodeVersion;
            FlowQuestion = flowQuestion;
            FlowNodeType = flowNodeType;
            FlowNodeEntity = flowNodeEntity;
            FlowAnswers = flowAnswers;
        }
    }
}
