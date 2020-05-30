using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Models
{
    public class UserFlowNode
    {
        public UserFlowNode(int flowNodeId, List<string> userFlowAnswerValue)
        {
            FlowNodeId = flowNodeId;
            UserFlowAnswerValue = userFlowAnswerValue;
        }
        
        public int UserFlowAnswerId { get; set; }
        public int FlowNodeId { get; set; }
        public List<string> UserFlowAnswerValue { get; set; }
        public bool IsStale { get; set; } = false;
    }
}
