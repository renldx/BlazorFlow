using System;
using System.Collections.Generic;
using AutoMapper;
using BlazorFlow.Data;

namespace BlazorFlow.Mappers
{
    public class UserFlowAnswerResolver : IValueResolver<Data.UserFlowNode, Models.UserFlowNode, List<Models.UserFlowAnswer>>
    {
        public List<Models.UserFlowAnswer> Resolve(Data.UserFlowNode source, Models.UserFlowNode destination, List<Models.UserFlowAnswer> member, ResolutionContext context)
        {
            member = new List<Models.UserFlowAnswer>();

            foreach (var userFlowAnswer in source.UserFlowAnswers)
            {
                var userValueString = userFlowAnswer.UserFlowAnswerValue;
                var userValueType = userFlowAnswer.UserFlowAnswerType;

                // To move into helper
                IComparable userValue = userValueType switch
                {
                    FlowValueType.Radio => int.Parse(userFlowAnswer.UserFlowAnswerValue),
                    FlowValueType.Select => int.Parse(userFlowAnswer.UserFlowAnswerValue),
                    FlowValueType.Number => decimal.Parse(userValueString),
                    FlowValueType.DateTime => DateTime.Parse(userValueString),
                    FlowValueType.Checkbox => userValueType.ToString(),
                    FlowValueType.Text => userValueType.ToString(),
                    FlowValueType.TextArea => userValueType.ToString(),
                    _ => throw new Exception()
                };

                var userFlowAnswerModel = new Models.UserFlowAnswer(userValue);
                member.Add(userFlowAnswerModel);
            }

            return member;
        }
    }
}
