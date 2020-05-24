namespace BlazorFlow.Data
{
    public class FlowLink
    {
        public int FlowLinkId { get; set; }
        public double FlowLinkVersion { get; set; }

        public int FlowId { get; set; }
        public Flow Flow { get; set; } = null!;
        public int FlowNodePreviousId { get; set; }
        public FlowNode FlowNodePrevious { get; set; } = null!;
        public int FlowNodeNextId { get; set; }
        public FlowNode FlowNodeNext { get; set; } = null!;
        public int? FlowConditionId { get; set; }
        public FlowCondition? FlowCondition { get; set; }
    }
}
