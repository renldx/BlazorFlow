using System;
using System.Collections.Generic;
using BlazorFlow.Data;
using BlazorFlow.Enums;
using BlazorFlow.Models;

namespace BlazorFlow.Helpers
{
    public static class AnswerValueHelper
    {
        // Should change to defaults of type?
        public static List<Models.UserFlowAnswer> GetUserFlowAnswerModels(FlowValueType valueType, Pages.Application.Model model) => valueType switch
        {
            FlowValueType.None =>
                new List<Models.UserFlowAnswer>(),
            FlowValueType.Radio =>
                new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.StringValue ?? string.Empty, valueType) },
            FlowValueType.Select =>
                new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.StringValue ?? string.Empty, valueType) },
            FlowValueType.Number =>
                new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.NumberValue ?? 0, valueType) },
            FlowValueType.Checkbox =>
                HashSetToAnswers(model.CheckboxValues ?? new HashSet<string>(), valueType),
            FlowValueType.DateTime =>
                new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.DateTimeValue, valueType) },
            FlowValueType.Text =>
                new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.StringValue ?? string.Empty, valueType) },
            FlowValueType.TextArea =>
                new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.StringValue ?? string.Empty, valueType) },
            _ => throw new Exception()
        };

        // Don't save answers when values are empty / null
        public static List<Models.UserFlowAnswer> HashSetToAnswers(HashSet<string> set, FlowValueType valueType)
        {
            var answerList = new List<Models.UserFlowAnswer>();

            foreach(var value in set)
            {
                answerList.Add(new Models.UserFlowAnswer(value, valueType));
            }

            return answerList;
        }
    }
}
