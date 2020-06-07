using System.Collections.Generic;

namespace BlazorFlow.Data
{
    public class UserFlow
    {
        public int UserFlowId { get; set; }
        public int UserId { get; set; }

        public int FlowId { get; set; }
        public Flow Flow { get; set; } = null!;
        public List<UserFlowNode> UserFlowNodes { get; set; } = null!;
    }
}
