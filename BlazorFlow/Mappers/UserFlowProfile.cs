using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace BlazorFlow.Mappers
{
    public class UserFlowProfile : Profile
    {
        public UserFlowProfile()
        {
            // Data => Models

            CreateMap<Data.UserFlow, Models.UserFlow>()
                .ForMember(m => m.UserFlowNodes, opt => opt
                .MapFrom(d => d.UserFlowNodes));

            CreateMap<Data.UserFlowNode, Models.UserFlowNode>()
                .ForMember(m => m.UserFlowAnswers, opt => opt
                .MapFrom<UserFlowAnswerDataResolver>());

            // Models => Data

            // To test
            CreateMap<Data.UserFlow, Models.UserFlow>()
                .ForMember(m => m.UserFlowNodes, opt => opt
                .MapFrom(d => d.UserFlowNodes))
                .ReverseMap();

            CreateMap<Models.UserFlowNode, Data.UserFlowNode>()
                .ForMember(m => m.UserFlowAnswers, opt => opt
                .MapFrom<UserFlowAnswerModelResolver>());
        }
    }
}
