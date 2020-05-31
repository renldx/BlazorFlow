using System;

namespace BlazorFlow.Models
{
    public class UserFlowAnswer
    {
        public int UserFlowAnswerId { get; set; }

        public IComparable UserFlowAnswerValue { get; set; } = null!;
    }
}
