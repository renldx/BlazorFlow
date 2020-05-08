using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Data
{
    public class UserFlowAnswer
    {
        public int UserFlowAnswerId { get; set; }
        public int FlowNodeId { get; set; }
        public string? UserFlowAnswerValue { get; set; }
    }
}
