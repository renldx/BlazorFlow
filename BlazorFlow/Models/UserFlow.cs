using System.Collections.Generic;

namespace BlazorFlow.Models
{
    public class UserFlow
    {
        public int UserFlowId { get; set; }
        public int FlowId { get; set; }
        public int UserId { get; set; }
        public LinkedList<UserFlowAnswer> UserFlowAnswers { get; set; } = null!;
    }
}
