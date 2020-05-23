using System.Threading.Tasks;
using BlazorFlow.Models;

namespace BlazorFlow.Services
{
    public interface IFlowService
    {
        Task<Flow> GetFlow(int flowId);
    }
}
