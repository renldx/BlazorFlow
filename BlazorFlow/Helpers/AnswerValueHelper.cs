using System;
using System.Collections.Generic;
using BlazorFlow.Enums;
using BlazorFlow.Models;

namespace BlazorFlow.Helpers
{
    public static class AnswerValueHelper
    {
        public static List<UserFlowAnswer> GetUserFlowAnswers(FlowValueType valueType, Pages.Application.Model model) => valueType switch
        {
            FlowValueType.None =>
                new List<UserFlowAnswer>(),
            FlowValueType.Radio =>
                new List<UserFlowAnswer> { new UserFlowAnswer(model.StringValue!) },
            FlowValueType.Select =>
                new List<UserFlowAnswer> { new UserFlowAnswer(model.StringValue!) },
            FlowValueType.Number =>
                new List<UserFlowAnswer> { new UserFlowAnswer(model.NumberValue!) },
            FlowValueType.Checkbox =>
                HashSetToAnswers(model.CheckboxValues!),
            FlowValueType.DateTime =>
                new List<UserFlowAnswer> { new UserFlowAnswer(model.DateTimeValue!) },
            FlowValueType.Text =>
                new List<UserFlowAnswer> { new UserFlowAnswer(model.StringValue!) },
            FlowValueType.TextArea =>
                new List<UserFlowAnswer> { new UserFlowAnswer(model.StringValue!) },
            _ => throw new Exception()
        };

        // To improve
        public static List<UserFlowAnswer> HashSetToAnswers(HashSetComparable<string> set)
        {
            var answerList = new List<UserFlowAnswer>();

            foreach(var value in set)
            {
                answerList.Add(new UserFlowAnswer(value));
            }

            return answerList;
        }
    }
}
