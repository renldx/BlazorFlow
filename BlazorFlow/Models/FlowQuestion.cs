namespace BlazorFlow.Models
{
    public class FlowQuestion
    {
        public FlowQuestion(string flowQuestionCode, string flowQuestionTextEn, string? flowQuestionTextFr = null)
        {
            FlowQuestionCode = flowQuestionCode;
            FlowQuestionTextEn = flowQuestionTextEn;
            FlowQuestionTextFr = flowQuestionTextFr;
        }

        public int FlowQuestionId { get; }
        public string FlowQuestionCode { get; }
        public string FlowQuestionTextEn { get; }
        public string? FlowQuestionTextFr { get; }
    }
}
