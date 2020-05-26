namespace BlazorFlow.Data
{
    public class FlowConditionValue
    {
        public int FlowConditionValueId { get; set; }
        public string FlowConditionValueString { get; set; } = null!;
        
        public int FlowLinkConditionId { get; set; }
        public FlowLinkCondition FlowLinkCondition { get; set; } = null!;
        public FlowConditionValueOperator FlowConditionValueOperator { get; set; }
    }
}
