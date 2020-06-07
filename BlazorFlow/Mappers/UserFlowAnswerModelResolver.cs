using System.Collections.Generic;
using AutoMapper;

namespace BlazorFlow.Mappers
{
    public class UserFlowAnswerModelResolver : IValueResolver<Models.UserFlowNode, Data.UserFlowNode, List<Data.UserFlowAnswer>>
    {
        public List<Data.UserFlowAnswer> Resolve(Models.UserFlowNode source, Data.UserFlowNode destination, List<Data.UserFlowAnswer> member, ResolutionContext context)
        {
            member = new List<Data.UserFlowAnswer>();

            foreach (var userFlowAnswer in source.UserFlowAnswers)
            {
                var userValueString = userFlowAnswer.UserFlowAnswerValue.ToString();
                var userValueType = userFlowAnswer.UserFlowAnswerType;

                var userFlowAnswerData = new Data.UserFlowAnswer() { UserFlowAnswerValue = userValueString!, UserFlowAnswerType = userValueType };
                member.Add(userFlowAnswerData);
            }

            return member;
        }
    }
}
