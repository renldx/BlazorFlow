using System.Collections.Generic;

namespace BlazorFlow.Data
{
    public class UserFlowNode
    {
        public int UserFlowNodeId { get; set; }
        public bool IsStale { get; set; } = false;

        public UserFlow UserFlow { get; set; } = null!;
        public FlowNode FlowNode { get; set; } = null!;
        public List<UserFlowAnswer> UserFlowAnswers { get; set; } = null!;
    }
}
