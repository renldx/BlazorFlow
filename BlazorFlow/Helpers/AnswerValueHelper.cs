using System;
using System.Collections.Generic;
using BlazorFlow.Data;
using BlazorFlow.Enums;
using BlazorFlow.Models;

namespace BlazorFlow.Helpers
{
    public static class AnswerValueHelper
    {
        public static List<Models.UserFlowAnswer> GetUserFlowAnswerModels(FlowValueType valueType, Pages.Application.Model model) => valueType switch
        {
            FlowValueType.None =>
                new List<Models.UserFlowAnswer>(),
            FlowValueType.Radio =>
                new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.StringValue!) },
            FlowValueType.Select =>
                new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.StringValue!) },
            FlowValueType.Number =>
                new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.NumberValue!) },
            FlowValueType.Checkbox =>
                HashSetToAnswers(model.CheckboxValues!),
            FlowValueType.DateTime =>
                new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.DateTimeValue!) },
            FlowValueType.Text =>
                new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.StringValue!) },
            FlowValueType.TextArea =>
                new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.StringValue!) },
            _ => throw new Exception()
        };

        // To improve
        public static List<Models.UserFlowAnswer> HashSetToAnswers(HashSetComparable<string> set)
        {
            var answerList = new List<Models.UserFlowAnswer>();

            foreach(var value in set)
            {
                answerList.Add(new Models.UserFlowAnswer(value));
            }

            return answerList;
        }
    }
}
