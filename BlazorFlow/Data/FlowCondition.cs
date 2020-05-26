namespace BlazorFlow.Data
{
    public class FlowCondition
    {
        public int FlowConditionId { get; set; }
        public string FlowConditionValue { get; set; } = null!;
        public FlowValueType FlowConditionType { get; set; }
        public FlowConditionOperator FlowConditionOperator { get; set; }
        
        public int FlowLinkConditionId { get; set; }
        public FlowLinkCondition FlowLinkCondition { get; set; } = null!;
    }
}
