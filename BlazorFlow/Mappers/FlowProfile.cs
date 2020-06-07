using System.Linq;
using AutoMapper;

namespace BlazorFlow.Mappers
{
    public class FlowProfile : Profile
    {
        public FlowProfile()
        {
            CreateMap<Data.Flow, Models.Flow>();
            CreateMap<Data.FlowQuestion, Models.FlowQuestion>();
            CreateMap<Data.FlowAnswer, Models.FlowAnswer>();

            CreateMap<Data.FlowNode, Models.FlowNode>()                
                .ForMember(m => m.FlowAnswers, opt => opt
                .MapFrom(d => d.FlowNodeAnswers
                .Select(s => s.FlowAnswer)));

            CreateMap<Data.FlowCondition, Models.FlowCondition>()
                .ConvertUsing<FlowConditionConverter>();

            CreateMap<Data.FlowLink, Models.FlowLink>()
                .ForCtorParam("fromFlowNode", opt => opt
                    .MapFrom(l => l.FlowNodePrevious))
                .ForCtorParam("toFlowNode", opt => opt
                    .MapFrom(l => l.FlowNodeNext))
                .ForCtorParam("flowConditions", opt => opt
                    .MapFrom(l => l.FlowLinkConditions
                    .Select(s => s.FlowCondition)));
        }
    }
}
