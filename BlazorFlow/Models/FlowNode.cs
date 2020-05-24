namespace BlazorFlow.Models
{
    public class FlowNode
    {
        public FlowNode (int flowNodeId, double flowNodeVersion, FlowQuestion flowQuestion, FlowNodeType flowNodeType = FlowNodeType.None, FlowNodeEntity flowNodeEntity = FlowNodeEntity.None, FlowAnswer[]? flowAnswers = null)
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
        public FlowNodeType FlowNodeType { get; set; }
        public FlowNodeEntity FlowNodeEntity { get; set; }
        public FlowQuestion FlowQuestion { get; set; }
        public FlowAnswer[]? FlowAnswers { get; set; }
    }
}
