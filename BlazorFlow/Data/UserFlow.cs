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

        public UserFlow(int flowId, int userId)
        {
            FlowId = flowId;
            UserId = userId;
        }
    }
}
