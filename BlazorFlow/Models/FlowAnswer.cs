using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Models
{
    public class FlowAnswer
    {
        //int FlowAnswerId;
        public string FlowAnswerCode { get; }
        public string FlowAnswerValue { get; }
        public string FlowAnswerTextEn { get; }
        public string? FlowAnswerTextFr { get; }

        public FlowAnswer(string flowAnswerCode, string flowAnswerValue, string flowAnswerTextEn, string? flowAnswerTextFr = null)
        {
            FlowAnswerCode = flowAnswerCode;
            FlowAnswerValue = flowAnswerValue;
            FlowAnswerTextEn = flowAnswerTextEn;
            FlowAnswerTextFr = flowAnswerTextFr;
        }
    }
}
