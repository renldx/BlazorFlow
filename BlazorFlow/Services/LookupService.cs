using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorFlow.Data;
using BlazorFlow.Enums;
using AutoMapper;

namespace BlazorFlow.Services
{
    public class LookupService : ILookupService
    {
        private readonly FlowContext context;
        private readonly IMapper mapper;

        public LookupService(FlowContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public List<Models.FlowAnswer> GetLookupValues(FlowEntity entity) => entity switch
        {
            FlowEntity.Contact => GetContacts(),
            _ => throw new NotImplementedException()
        };

        private List<Models.FlowAnswer> GetContacts()
        {
            var contacts = context.Contacts.ToList();
            return mapper.Map<List<Models.FlowAnswer>>(contacts);
        }
    }
}
