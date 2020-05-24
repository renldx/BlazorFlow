using System.Collections.Generic;

namespace BlazorFlow.Data
{
    public class FlowQuestion
    {
        public FlowQuestion(string flowQuestionCode, string flowQuestionTextEn, string flowQuestionTextFr) 
        {
            FlowQuestionCode = flowQuestionCode;
            FlowQuestionTextEn = flowQuestionTextEn;
            FlowQuestionTextFr = flowQuestionTextFr;
        }

        public int FlowQuestionId { get; set; }
        public string FlowQuestionCode { get; set; }
        public string FlowQuestionTextEn { get; set; }
        public string FlowQuestionTextFr { get; set; }

        public List<FlowNode> FlowNodes { get; set; } = null!;
    }
}
