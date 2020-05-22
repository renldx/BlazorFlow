using System.Threading.Tasks;
using BlazorFlow.Data;

namespace BlazorFlow.Services
{
    public interface IFlowService
    {
        Task<Flow> GetFlow(double flowVersion);
    }
}
