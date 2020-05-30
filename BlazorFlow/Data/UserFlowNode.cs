using System.Collections.Generic;

namespace BlazorFlow.Data
{
    public class UserFlowNode
    {
        public int UserFlowNodeId { get; set; }
        public bool IsStale { get; set; } = false;

        public int UserFlowId { get; set; }
        public UserFlow UserFlow { get; set; } = null!;
        public int FlowNodeId { get; set; }
        public FlowNode FlowNode { get; set; } = null!;
        public List<UserFlowAnswer> UserFlowAnswers { get; set; } = null!;
    }
}
