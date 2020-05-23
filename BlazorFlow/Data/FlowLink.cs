namespace BlazorFlow.Data
{
    public class FlowLink
    {
        public int FlowLinkId { get; set; }
        public double FlowLinkVersion { get; set; }
        public Flow Flow { get; set; } = null!;
        public FlowNode? FlowNodePrevious { get; set; }
        public FlowNode? FlowNodeNext { get; set; }
        public FlowCondition? FlowCondition { get; set; }
    }
}
