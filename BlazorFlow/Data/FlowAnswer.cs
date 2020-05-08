using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Data
{
    public class FlowAnswer
    {
        public int FlowAnswerId { get; set; }
        public string? FlowAnswerCode { get; set; }
        public string? FlowAnswerValue { get; set; }
        public string? FlowAnswerTextEn { get; set; }
        public string? FlowAnswerTextFr { get; set; }
    }
}
