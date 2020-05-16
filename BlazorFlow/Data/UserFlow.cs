using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Data
{
    public class UserFlow
    {
        int UserFlowId;
        public int FlowId { get; }
        public int UserId { get; }
        public LinkedList<UserFlowAnswer> UserFlowAnswers { get; }

        public UserFlow(int userFlowId, int flowId, int userId)
        {
            UserFlowId = userFlowId;
            FlowId = flowId;
            UserId = userId;
            UserFlowAnswers = new LinkedList<UserFlowAnswer>();
        }
    }
}
