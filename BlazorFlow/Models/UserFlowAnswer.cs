using System;
using BlazorFlow.Enums;

namespace BlazorFlow.Models
{
    public class UserFlowAnswer : IEquatable<UserFlowAnswer>
    {
        public UserFlowAnswer(IComparable userFlowAnswerValue, FlowValueType userFlowAnswerType)
        {
            UserFlowAnswerValue = userFlowAnswerValue;
            UserFlowAnswerType = userFlowAnswerType;
        }

        public int UserFlowAnswerId { get; set; }

        public IComparable UserFlowAnswerValue { get; set; } = null!;
        public FlowValueType UserFlowAnswerType { get; set; }

        public bool Equals(UserFlowAnswer? userFlowAnswer)
        {
            if (userFlowAnswer is {} existing)
            {
                return existing.UserFlowAnswerValue == UserFlowAnswerValue && existing.UserFlowAnswerType == UserFlowAnswerType;
            }
            
            return false;
        }
    }
}
