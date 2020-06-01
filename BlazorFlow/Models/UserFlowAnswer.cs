using System;
using BlazorFlow.Enums;

namespace BlazorFlow.Models
{
    public class UserFlowAnswer
    {
        public UserFlowAnswer(IComparable userFlowAnswerValue, FlowValueType userFlowAnswerType)
        {
            UserFlowAnswerValue = userFlowAnswerValue;
            UserFlowAnswerType = userFlowAnswerType;
        }

        //public int UserFlowAnswerId { get; set; }

        public IComparable UserFlowAnswerValue { get; set; } = null!;
        public FlowValueType UserFlowAnswerType { get; set; }
    }
}
