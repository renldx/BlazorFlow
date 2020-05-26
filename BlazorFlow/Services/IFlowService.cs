using System.Threading.Tasks;

namespace BlazorFlow.Services
{
    public interface IFlowService
    {
        Task<Models.Flow> GetFlow(int flowId);

        Task<Models.Flow> GetFlowGraph(int flowId);
    }
}
