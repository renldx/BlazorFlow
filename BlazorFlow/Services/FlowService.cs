using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorFlow.Data;
using AutoMapper;

namespace BlazorFlow.Services
{
    public class FlowService
    {
        private readonly FlowContext context;
        private readonly IMapper mapper;

        public FlowService(FlowContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Models.Flow> GetFlow(int flowId)
        {
            var flow = await context.Flows.FindAsync(flowId);
            var flowModel = mapper.Map<Models.Flow>(flow);

            // To optimize
            var links = await context.FlowLinks
                .Include(n => n.FlowNodePrevious)
                .Include(n => n.FlowNodeNext)
                .Include(n => n.FlowLinkConditions)
                .ThenInclude(x => x.FlowCondition)
                .Where(n => n.FlowId == flow.FlowId)
                .ToListAsync();

            var linkModels = mapper.Map<List<Models.FlowLink>>(links);

            flowModel.AddVerticesAndEdgeRange(linkModels);

            return flowModel;
        }
    }
}
