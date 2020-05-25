using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorFlow.Data;
using AutoMapper;

namespace BlazorFlow.Services
{
    public class FlowNodeService
    {
        private readonly FlowContext context;
        private readonly IMapper mapper;

        public FlowNodeService(FlowContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Models.FlowNode> GetFlowNode(int flowNodeId)
        {
            var node = await context.FlowNodes.FindAsync(flowNodeId);
            return mapper.Map<Models.FlowNode>(node);
        }

        public async Task<List<Models.FlowNode>> GetFlowNodes(int flowId)
        {
            var nodes = await context.FlowNodes
                .Where(n => n.FlowId == flowId)
                .Include(n => n.FlowNodeAnswers)
                .ThenInclude(n => n.FlowAnswer)
                .ToListAsync();
            return mapper.Map<List<Models.FlowNode>>(nodes);
        }
    }
}
