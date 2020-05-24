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

        public int FlowQuestionId { get; set; }
        public string FlowQuestionCode { get; set; }
        public string FlowQuestionTextEn { get; set; }
        public string? FlowQuestionTextFr { get; set; }
    }
}
