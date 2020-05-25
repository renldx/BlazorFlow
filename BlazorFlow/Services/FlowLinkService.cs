using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorFlow.Data;
using AutoMapper;

namespace BlazorFlow.Services
{
    public class FlowLinkService
    {
        private readonly FlowContext context;
        private readonly IMapper mapper;

        public FlowLinkService(FlowContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Models.FlowLink> GetFlowLink(int linkId)
        {
            var link = await context.FlowLinks.FindAsync(linkId);
            return mapper.Map<Models.FlowLink>(link);
        }

        public async Task<IEnumerable<Models.FlowLink>> GetFlowLinks(int flowId)
        {
            var links = await context.FlowLinks
                .Where(l => l.FlowId == flowId)
                .ToListAsync();
            return mapper.Map<List<Models.FlowLink>>(links);
        }
    }
}
