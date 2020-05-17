using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Data
{
    public class UserFlowAnswer
    {
        int UserFlowAnswerId;
        public int FlowNodeId { get; }
        public string[]? UserFlowAnswerValue { get; set; }
        public bool isStale { get; set; } = false;

        public UserFlowAnswer(int userFlowAnswerId, int flowNodeId, string[]? userFlowAnswerValue = null)
        {
            UserFlowAnswerId = userFlowAnswerId;
            FlowNodeId = flowNodeId;
            UserFlowAnswerValue = userFlowAnswerValue;
        }
    }
}
