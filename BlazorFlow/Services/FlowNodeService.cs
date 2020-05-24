using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorFlow.Data;
using AutoMapper;

namespace BlazorFlow.Services
{
    public class FlowNodeService : IFlowNodeService
    {
        private readonly FlowContext context;
        private readonly IMapper mapper;

        public FlowNodeService(FlowContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<Models.FlowNode>> GetFlowNodes()
        {
            var nodes = await context.FlowNodes
                .ToListAsync();
            return mapper.Map<List<Models.FlowNode>>(nodes);
        }

        public async Task<Models.FlowNode> GetFlowNode(int flowNodeId)
        {
            var node = await context.FlowNodes
                .Include(n => n.FlowNodeAnswers)
                .ThenInclude(n => n.FlowAnswer)
                .FirstOrDefaultAsync(n => n.FlowNodeId == flowNodeId);
            return mapper.Map<Models.FlowNode>(node);
        }

        public async Task<Models.FlowNode> GetStartingFlowNode(int flowId)
        {
            var node = await context.FlowNodes
                .Include(n => n.FlowNodeAnswers)
                .ThenInclude(n => n.FlowAnswer)
                .SingleOrDefaultAsync(n => n.FlowId == flowId);
            return mapper.Map<Models.FlowNode>(node);
        }
    }
}
