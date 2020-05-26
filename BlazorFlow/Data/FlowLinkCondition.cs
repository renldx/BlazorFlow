using System.Collections.Generic;

namespace BlazorFlow.Data
{
    public class FlowLinkCondition
    {
        public int FlowLinkConditionId { get; set; }
        public List<FlowConditionValue> FlowConditionValues { get; set; } = null!;
    }
}
