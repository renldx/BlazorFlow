namespace BlazorFlow.Data
{
    public class FlowAnswer
    {
        public int FlowAnswerId { get; set; }
        public string FlowAnswerCode { get; set; } = null!;
        public string FlowAnswerValue { get; set; } = null!;
        public string FlowAnswerTextEn { get; set; } = null!;
        public string FlowAnswerTextFr { get; set; } = null!;
    }
}
