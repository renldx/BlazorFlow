namespace BlazorFlow.Data
{
    public class FlowConditionValue
    {
        public FlowConditionValue(string flowConditionValueString)
        {
            FlowConditionValueString = flowConditionValueString;
        }

        public int FlowConditionValueId { get; set; }
        public string FlowConditionValueString { get; set; }

        public FlowCondition FlowCondition { get; set; } = null!;
    }
}
