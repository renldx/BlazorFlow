using System.Collections.Generic;

namespace BlazorFlow.Data
{
    public class UserFlowAnswer
    {
        public int UserFlowAnswerId { get; set; }
        public bool IsStale { get; set; } = false;

        public UserFlow UserFlow { get; set; } = null!;
        public FlowNode FlowNode { get; set; } = null!;
        public List<UserFlowAnswerValue> UserFlowAnswerValues { get; set; } = null!;
    }
}
