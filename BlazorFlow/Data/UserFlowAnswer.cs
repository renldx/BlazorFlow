using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Data
{
    public class UserFlowAnswer
    {
        public UserFlowAnswer(int userFlowAnswerId, int flowNodeId)
        {
            UserFlowAnswerId = userFlowAnswerId;
            FlowNodeId = flowNodeId;
        }

        public UserFlowAnswer(int userFlowAnswerId, int flowNodeId, int userFlowAnswerInt) : this(userFlowAnswerId, flowNodeId)
        {
            UserFlowAnswerInt = userFlowAnswerInt;
        }

        public UserFlowAnswer(int userFlowAnswerId, int flowNodeId, decimal userFlowAnswerDecimal) : this(userFlowAnswerId, flowNodeId)
        {
            UserFlowAnswerDecimal = userFlowAnswerDecimal;
        }

        public int UserFlowAnswerId { get; set; }
        public int FlowNodeId { get; set; }
        public int? UserFlowAnswerInt { get; set; }
        public decimal? UserFlowAnswerDecimal { get; set; }
    }
}
