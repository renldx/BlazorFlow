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
                string.IsNullOrEmpty(model.StringValue) ?
                    new List<Models.UserFlowAnswer>() :
                    new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.StringValue, valueType) },
            FlowValueType.Select =>
                string.IsNullOrEmpty(model.StringValue) ?
                    new List<Models.UserFlowAnswer>() :
                    new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.StringValue, valueType) },
            FlowValueType.Number =>
                model.NumberValue.HasValue ?
                    new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.NumberValue, valueType) } :
                    new List<Models.UserFlowAnswer>(),
            FlowValueType.Checkbox =>
                HashSetToAnswers(model.CheckboxValues ?? new HashSet<string>(), valueType),
            FlowValueType.DateTime =>
                new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.DateTimeValue, valueType) },
            FlowValueType.Text =>
                string.IsNullOrEmpty(model.StringValue) ?
                    new List<Models.UserFlowAnswer>() :
                    new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.StringValue ?? string.Empty, valueType) },
            FlowValueType.TextArea =>
                string.IsNullOrEmpty(model.StringValue) ?
                    new List<Models.UserFlowAnswer>() :
                    new List<Models.UserFlowAnswer> { new Models.UserFlowAnswer(model.StringValue ?? string.Empty, valueType) },
            _ => throw new Exception("Unsupported node type.")
        };

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
