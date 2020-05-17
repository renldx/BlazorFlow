using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuikGraph;

namespace BlazorFlow.Data
{
    public class FlowNode
    {
        public int FlowNodeId { get; }
        public double FlowNodeVersion { get; }
        public FlowNodeType FlowNodeType { get; }
        public FlowQuestion FlowQuestion { get; }
        public FlowAnswer[]? FlowAnswers { get; }

        public FlowNode (int flowNodeId, double flowNodeVersion, FlowQuestion flowQuestion, FlowNodeType flowNodeType, FlowAnswer[]? flowAnswers = null)
        {
            FlowNodeId = flowNodeId;
            FlowNodeVersion = flowNodeVersion;
            FlowQuestion = flowQuestion;
            FlowNodeType = flowNodeType;
            FlowAnswers = flowAnswers;
        }
    }

    public enum FlowNodeType
    {
        none,
        radio,
        select,
        number,
        checkbox,
        datetime,
        text,
        textarea
    }
}
