namespace BlazorFlow.Data
{
    public class UserFlowAnswerValues
    {
        public int UserFlowAnswerValueId { get; set; }
        public string UserFlowAnswerValue { get; set; } = null!;

        public UserFlowAnswer UserFlowAnswer { get; set; } = null!;
    }
}
