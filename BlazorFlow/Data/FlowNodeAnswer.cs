using System.Collections.Generic;

namespace BlazorFlow.Data
{
    public class FlowNodeAnswer
    {
        public int FlowNodeAnswerId { get; set; }
        public int FlowNodeId { get; set; }
        public int FlowAnswerId { get; set; }

        public FlowNode FlowNode { get; set; } = null!;
        public FlowAnswer FlowAnswer { get; set; } = null!;
    }
}
