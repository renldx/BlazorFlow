using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Data
{
    public class FlowAnswer
    {
        int FlowAnswerId;
        public string FlowAnswerCode { get; }
        public string FlowAnswerValue { get; }
        public string FlowAnswerTextEn { get; }
        public string FlowAnswerTextFr { get; }

        public FlowAnswer(int flowAnswerId, string flowAnswerCode, string flowAnswerValue, string flowAnswerTextEn, string flowAnswerTextFr)
        {
            FlowAnswerId = flowAnswerId;
            FlowAnswerCode = flowAnswerCode;
            FlowAnswerValue = flowAnswerValue;
            FlowAnswerTextEn = flowAnswerTextEn;
            FlowAnswerTextFr = flowAnswerTextFr;
        }
    }
}
