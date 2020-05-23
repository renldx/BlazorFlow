namespace BlazorFlow.Models
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

        public int FlowAnswerId { get; }
        public string FlowAnswerCode { get; }
        public string FlowAnswerValue { get; }
        public string FlowAnswerTextEn { get; }
        public string FlowAnswerTextFr { get; }
    }
}
