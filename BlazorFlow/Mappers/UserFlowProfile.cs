using System.Linq;
using AutoMapper;

namespace BlazorFlow.Mappers
{
    public class UserFlowProfile : Profile
    {
        public UserFlowProfile()
        {
            CreateMap<Data.UserFlow, Models.UserFlow>()
                .ForMember(m => m.UserFlowAnswers, opt => opt
                .MapFrom(d => d.UserFlowNodes));

            CreateMap<Data.UserFlowNode, Models.UserFlowAnswer>()
                .ForMember(m => m.UserFlowAnswerValue, opt => opt
                .MapFrom(d => d.UserFlowAnswers
                .Select(s => s.UserFlowAnswerValue)));
        }
    }
}
