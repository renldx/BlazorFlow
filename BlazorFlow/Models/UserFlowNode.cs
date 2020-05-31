using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Models
{
    public class UserFlowNode
    {
        public UserFlowNode(int userFlowId, int flowNodeId, List<IComparable> userFlowAnswers)
        {
            UserFlowId = userFlowId;
            FlowNodeId = flowNodeId;
            UserFlowAnswers = userFlowAnswers;
        }
        
        public int UserFlowNodeId { get; set; }
        public int UserFlowId { get; set; }
        public int FlowNodeId { get; set; }
        public List<IComparable> UserFlowAnswers { get; set; }
        public bool IsStale { get; set; } = false;
    }
}
