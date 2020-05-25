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

            CreateMap<Data.FlowLink, Models.FlowLink>();
        }
    }
}
