namespace BlazorFlow.Data
{
    public class FlowCondition
    {
        public int FlowConditionId { get; set; }
        public string FlowConditionValue { get; set; } = null!;
        
        public int FlowLinkConditionId { get; set; }
        public FlowLinkCondition FlowLinkCondition { get; set; } = null!;
        public FlowConditionOperator FlowConditionOperator { get; set; }
    }
}
