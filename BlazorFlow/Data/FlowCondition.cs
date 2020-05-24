using System.Collections.Generic;

namespace BlazorFlow.Data
{
    public class FlowCondition
    {
        public int FlowConditionId { get; set; }
        public List<FlowConditionValue> FlowConditionValues { get; set; } = null!;
    }
}
