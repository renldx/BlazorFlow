namespace BlazorFlow.Data
{
    public class FlowNodeAnswer
    {
        public int FlowNodeAnswerId { get; set; }

        public int FlowNodeId { get; set; }
        public FlowNode FlowNode { get; set; } = null!;
        public int FlowAnswerId { get; set; }
        public FlowAnswer FlowAnswer { get; set; } = null!;
    }
}
