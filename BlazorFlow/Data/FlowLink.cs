namespace BlazorFlow.Data
{
    public class FlowLink
    {
        public int FlowLinkId { get; set; }
        public double FlowLinkVersion { get; set; }

        public Flow Flow { get; set; } = null!;
        public FlowNode FlowNodePrevious { get; set; } = null!;
        public FlowNode FlowNodeNext { get; set; } = null!;
        public FlowCondition FlowCondition { get; set; } = null!;
    }
}
