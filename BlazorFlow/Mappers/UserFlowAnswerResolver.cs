using System;
using System.Collections.Generic;
using AutoMapper;

namespace BlazorFlow.Mappers
{
    public class UserFlowAnswerResolver : IValueResolver<Data.UserFlowNode, Models.UserFlowNode, List<IComparable>>
    {
        public List<IComparable> Resolve(Data.UserFlowNode source, Models.UserFlowNode destination, List<IComparable> member, ResolutionContext context)
        {
            return new List<IComparable>(){1};
        }
    }
}
