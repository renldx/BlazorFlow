using System.Linq;
using AutoMapper;

namespace BlazorFlow.Mappers
{
    public class UserFlowProfile : Profile
    {
        public UserFlowProfile()
        {
            CreateMap<Data.UserFlow, Models.UserFlow>()
                .ForMember(m => m.UserFlowNodes, opt => opt
                .MapFrom(d => d.UserFlowNodes));

            CreateMap<Data.UserFlowNode, Models.UserFlowNode>()
                .ForMember(m => m.UserFlowAnswers, opt => opt
                .MapFrom(d => d.UserFlowAnswers
                .Select(s => s.UserFlowAnswerValue)));

            CreateMap<Models.UserFlowNode, Data.UserFlowNode>()
                .ConvertUsing<UserFlowNodeConverter>();
        }
    }
}
