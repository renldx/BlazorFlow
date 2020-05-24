namespace BlazorFlow.Data
{
    public class FlowConditionValue
    {
        public int FlowConditionValueId { get; set; }
        public string FlowConditionValueString { get; set; } = null!;
        
        public int FlowConditionId { get; set; }
        public FlowCondition FlowCondition { get; set; } = null!;
        public FlowConditionValueOperator FlowConditionValueOperator { get; set; }
    }
}
