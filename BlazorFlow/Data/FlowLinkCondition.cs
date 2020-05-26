using System.Collections.Generic;

namespace BlazorFlow.Data
{
    public class FlowLinkCondition
    {
        public int FlowLinkConditionId { get; set; }
        public List<FlowCondition> FlowConditions { get; set; } = null!;
    }
}
