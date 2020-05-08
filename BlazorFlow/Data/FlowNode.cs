using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuikGraph;

namespace BlazorFlow.Data
{
    public class FlowNode
    {
        public FlowNode (FlowQuestion flowQuestion, FlowNodeType flowNodeType, FlowAnswer[]? flowAnswer = null)
        {
            FlowQuestion = flowQuestion;
            FlowNodeType = flowNodeType;
            FlowAnswer = flowAnswer;
        }

        public int FlowNodeId { get; set; }
        public double FlowNodeVersion { get; set; }
        public FlowNodeType FlowNodeType { get; set; }
        public FlowQuestion FlowQuestion { get; set; }
        public FlowAnswer[]? FlowAnswer { get; set; }
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
