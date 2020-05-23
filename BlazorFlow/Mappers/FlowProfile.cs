using AutoMapper;

namespace BlazorFlow.Mappers
{
    public class FlowProfile : Profile
    {
        public FlowProfile() {
            CreateMap<Data.Flow, Models.Flow>();
        }
    }
}
