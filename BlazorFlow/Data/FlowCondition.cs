namespace BlazorFlow.Data
{
    public class FlowCondition
    {
        public int FlowConditionId { get; set; }
        public string FlowConditionValue { get; set; } = null!;
        public FlowConditionOperator FlowConditionOperator { get; set; }
        public FlowValueType FlowConditionType { get; set; }
        
        public int FlowLinkConditionId { get; set; }
        public FlowLinkCondition FlowLinkCondition { get; set; } = null!;
    }
}
