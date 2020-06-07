using System.Collections.Generic;
using BlazorFlow.Enums;
using BlazorFlow.Helpers;

namespace BlazorFlow.Data
{
    public class FlowCondition
    {
        public int FlowConditionId { get; set; }
        public string FlowConditionValue { get; set; } = null!;
        public FlowConditionOperator FlowConditionOperator { get; set; }
        public FlowValueType FlowConditionType { get; set; }
        
        public List<FlowLinkCondition> FlowLinkConditions { get; set; } = null!;
    }
}
