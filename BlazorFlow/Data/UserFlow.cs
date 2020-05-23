using System.Collections.Generic;

namespace BlazorFlow.Data
{
    public class UserFlow
    {
        public int UserFlowId { get; set; }
        public int UserId { get; set; }

        public Flow Flow { get; set; } = null!;
        public List<UserFlowAnswer> UserFlowAnswers { get; set; } = null!;
    }
}
