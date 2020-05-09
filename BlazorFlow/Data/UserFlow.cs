using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Data
{
    public class UserFlow
    {
        public int UserFlowId { get; set; }
        public int FlowId { get; set; }
        public int UserId { get; set; }
        public LinkedList<LinkedListNode<UserFlowAnswer>> UserFlowAnswers { get; set; }

        public UserFlow(int userFlowId, int flowId, int userId)
        {
            UserFlowId = userFlowId;
            FlowId = flowId;
            UserId = userId;
            UserFlowAnswers = new LinkedList<LinkedListNode<UserFlowAnswer>>();
        }
    }
}
