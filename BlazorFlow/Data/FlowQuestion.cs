using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Data
{
    public class FlowQuestion
    {
        int FlowQuestionId;
        public string FlowQuestionCode { get; }
        public string FlowQuestionTextEn { get; }
        public string FlowQuestionTextFr { get; }

        public FlowQuestion(int flowQuestionId, string flowQuestionCode, string flowQuestionTextEn, string flowQuestionTextFr)
        {
            FlowQuestionId = flowQuestionId;
            FlowQuestionCode = flowQuestionCode;
            FlowQuestionTextEn = flowQuestionTextEn;
            FlowQuestionTextFr = flowQuestionTextFr;
        }
    }
}
