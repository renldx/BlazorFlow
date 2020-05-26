using System.Linq;
using AutoMapper;

namespace BlazorFlow.Mappers
{
    public class FlowProfile : Profile
    {
        public FlowProfile()
        {
            CreateMap<Data.Flow, Models.Flow>();

            CreateMap<Data.FlowNode, Models.FlowNode>()
                .ForMember(fnm => fnm.FlowAnswers, opt => opt
                .MapFrom(fnd => fnd.FlowNodeAnswers
                .Select(fna => fna.FlowAnswer.FlowAnswerValue)
                .ToArray()));

            CreateMap<Data.FlowLink, Models.FlowLink>()
                .ConstructUsing((l, c) => new Models.FlowLink(l.FlowLinkVersion,
                    c.Mapper.Map<Models.FlowNode>(l.FlowNodePrevious),
                    c.Mapper.Map<Models.FlowNode>(l.FlowNodeNext),
                    c.Mapper.Map<Models.FlowCondition>(l.FlowCondition)));
        
            CreateMap<Data.FlowCondition, Models.FlowCondition>();
        }
    }
}
