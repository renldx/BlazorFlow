using System.Collections.Generic;

namespace BlazorFlow.Data
{
    public class FlowQuestion
    {
        public int FlowQuestionId { get; set; }
        public string FlowQuestionCode { get; set; } = null!;
        public string FlowQuestionTextEn { get; set; } = null!;
        public string FlowQuestionTextFr { get; set; } = null!;

        public List<FlowNode> FlowNodes { get; set; } = null!;
    }
}
