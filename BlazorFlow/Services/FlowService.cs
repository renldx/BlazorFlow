
using System.Threading.Tasks;
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
            return mapper.Map<Models.Flow>(flow);
        }
    }
}
