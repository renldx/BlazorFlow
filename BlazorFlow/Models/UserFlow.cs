using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Models
{
    public class UserFlow
    {
        //int UserFlowId;
        public int FlowId { get; }
        public int UserId { get; }
        public LinkedList<UserFlowAnswer> UserFlowAnswers { get; }

        public UserFlow(int flowId, int userId)
        {
            FlowId = flowId;
            UserId = userId;
            UserFlowAnswers = new LinkedList<UserFlowAnswer>();
        }
    }
}
