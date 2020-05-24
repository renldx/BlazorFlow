using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Models
{
    public class UserFlowAnswer
    {
        public UserFlowAnswer(int flowNodeId, string[]? userFlowAnswerValue = null)
        {
            FlowNodeId = flowNodeId;
            UserFlowAnswerValue = userFlowAnswerValue;
        }
        
        public int UserFlowAnswerId { get; set; }
        public int FlowNodeId { get; set; }
        public string[]? UserFlowAnswerValue { get; set; }
        public bool IsStale { get; set; } = false;
    }
}
