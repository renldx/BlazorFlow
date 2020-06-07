using System.Collections.Generic;

namespace BlazorFlow.Data
{
    public class FlowLinkCondition
    {
        public int FlowLinkConditionId { get; set; }

        public int FlowLinkId { get; set; }
        public  FlowLink FlowLink { get; set; } = null!;
        public int FlowConditionId { get; set; }
        public FlowCondition FlowCondition { get; set; } = null!;
    }
}
