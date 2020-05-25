using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorFlow.Services
{
    public interface IFlowNodeService
    {
        Task<Models.FlowNode> GetFlowNode(int flowNodeId);

        Task<List<Models.FlowNode>> GetFlowNodes(int flowId);
    }
}
