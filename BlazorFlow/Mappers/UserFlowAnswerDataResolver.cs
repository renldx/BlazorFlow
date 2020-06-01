using System;
using System.Collections.Generic;
using AutoMapper;
using BlazorFlow.Enums;

namespace BlazorFlow.Mappers
{
    public class UserFlowAnswerDataResolver : IValueResolver<Data.UserFlowNode, Models.UserFlowNode, List<Models.UserFlowAnswer>>
    {
        public List<Models.UserFlowAnswer> Resolve(Data.UserFlowNode source, Models.UserFlowNode destination, List<Models.UserFlowAnswer> member, ResolutionContext context)
        {
            member = new List<Models.UserFlowAnswer>();

            foreach (var userFlowAnswer in source.UserFlowAnswers)
            {
                var userValueString = userFlowAnswer.UserFlowAnswerValue;
                var userValueType = userFlowAnswer.UserFlowAnswerType;

                IComparable userValue = userValueType switch
                {
                    FlowValueType.Number => decimal.Parse(userValueString),
                    FlowValueType.DateTime => DateTime.Parse(userValueString),
                    FlowValueType.Radio => userValueString,
                    FlowValueType.Select => userValueString,
                    FlowValueType.Checkbox => userValueString,
                    FlowValueType.Text => userValueString,
                    FlowValueType.TextArea => userValueString,
                    _ => throw new Exception()
                };

                var userFlowAnswerModel = new Models.UserFlowAnswer(userValue, userValueType);
                member.Add(userFlowAnswerModel);
            }

            return member;
        }
    }
}
