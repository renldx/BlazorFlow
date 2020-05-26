namespace BlazorFlow.Data
{
    public class UserFlowAnswer
    {
        public int UserFlowAnswerId { get; set; }
        public string UserFlowAnswerValue { get; set; } = null!;

        public UserFlowNode UserFlowNode { get; set; } = null!;
    }
}
