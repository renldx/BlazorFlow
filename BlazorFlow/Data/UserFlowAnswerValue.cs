namespace BlazorFlow.Data
{
    public class UserFlowAnswerValue
    {
        public int UserFlowAnswerValueId { get; set; }
        public string UserFlowAnswerValueString { get; set; } = null!;

        public UserFlowAnswer UserFlowAnswer { get; set; } = null!;
    }
}
