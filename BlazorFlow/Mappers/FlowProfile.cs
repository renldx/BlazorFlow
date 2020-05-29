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
                .ConstructUsing((l, c) => new Models.FlowLink(l.FlowLinkVersion,
                    c.Mapper.Map<Models.FlowNode>(l.FlowNodePrevious),
                    c.Mapper.Map<Models.FlowNode>(l.FlowNodeNext)));
        }
    }
}
