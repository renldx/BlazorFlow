using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuikGraph;

namespace BlazorFlow.Data
{
    public class FlowNode
    {
        public FlowNode (int flowNodeId, double flowNodeVersion, FlowQuestion flowQuestion, FlowNodeType flowNodeType, FlowAnswer[]? flowAnswers = null)
        {
            FlowNodeId = flowNodeId;
            FlowNodeVersion = flowNodeVersion;
            FlowQuestion = flowQuestion;
            FlowNodeType = flowNodeType;
            FlowAnswers = flowAnswers;
        }

        public int FlowNodeId { get; set; }
        public double FlowNodeVersion { get; set; }
        public FlowNodeType FlowNodeType { get; set; }
        public FlowQuestion FlowQuestion { get; set; }
        public FlowAnswer[]? FlowAnswers { get; set; }
    }

    public enum FlowNodeType
    {
        none,
        checkbox,
        date,
        dropdown,
        radio,
        number,
        text
    }
}
