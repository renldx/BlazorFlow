using System.Collections.Generic;

namespace BlazorFlow.Models
{
    public class UserFlow
    {
        public int UserFlowId { get; set; }
        public int FlowId { get; }
        public int UserId { get; }
        public LinkedList<UserFlowAnswer> UserFlowAnswers { get; set; } = null!;
    }
}
