using AutoMapper;

namespace BlazorFlow.Mappers
{
    public class LookupProfile : Profile
    {
        public LookupProfile()
        {
            CreateMap<Data.Contact, Models.FlowAnswer>()
                .ConstructUsing(c => new Models.FlowAnswer(
                    c.GetType().Name,
                    c.ContactId.ToString(),
                    $"{c.FirstName} {c.LastName}",
                    $"{c.FirstName} {c.LastName}"
                ));
        }
    }
}
