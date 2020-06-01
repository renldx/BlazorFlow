using System;

namespace BlazorFlow.Models
{
    public class UserFlowAnswer
    {
        public UserFlowAnswer(IComparable userFlowAnswerValue)
        {
            UserFlowAnswerValue = userFlowAnswerValue;
        }

        //public int UserFlowAnswerId { get; set; }

        public IComparable UserFlowAnswerValue { get; set; } = null!;
    }
}
