using System.Collections.Generic;
using BlazorFlow.Enums;

namespace BlazorFlow.Models
{
    public class FlowNode
    {
        public FlowNode (int flowNodeId, double flowNodeVersion, FlowQuestion flowQuestion, FlowValueType flowNodeType = FlowValueType.None, FlowEntity flowNodeEntity = FlowEntity.None, List<FlowAnswer> flowAnswers = null!)
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
        public FlowEntity FlowNodeEntity { get; set; }
        public int FlowQuestionId { get; set; }
        public FlowQuestion FlowQuestion { get; set; }
        public List<FlowAnswer> FlowAnswers { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is {} existing && existing is FlowNode)
            {
                FlowNode n = (FlowNode)obj;
                return n.FlowNodeId == FlowNodeId;
            }
            else 
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return FlowNodeId;
        }
    }
}
