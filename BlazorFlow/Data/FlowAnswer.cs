namespace BlazorFlow.Data
{
    public class FlowAnswer
    {
        public FlowAnswer(string flowAnswerCode, string flowAnswerValue, string flowAnswerTextEn, string flowAnswerTextFr)
        {
            FlowAnswerCode = flowAnswerCode;
            FlowAnswerValue = flowAnswerValue;
            FlowAnswerTextEn = flowAnswerTextEn;
            FlowAnswerTextFr = flowAnswerTextFr;
        }

        public int FlowAnswerId { get; set; }
        public string FlowAnswerCode { get; set; }
        public string FlowAnswerValue { get; set; }
        public string FlowAnswerTextEn { get; set; }
        public string FlowAnswerTextFr { get; set; }
    }
}
