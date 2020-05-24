using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorFlow.Models;

namespace BlazorFlow.Services
{
    public interface IFlowNodeService
    {
        Task<List<FlowNode>> GetFlowNodes();

        Task<FlowNode> GetFlowNode(int nodeId);

        Task<FlowNode> GetStartingFlowNode(int flowId);
    }
}
