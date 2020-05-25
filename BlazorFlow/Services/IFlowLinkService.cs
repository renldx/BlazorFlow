using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorFlow.Services
{
    public interface IFlowLinkService
    {
        Task<Models.FlowLink> GetFlowLink(int linkId);

        Task<IEnumerable<Models.FlowLink>> GetFlowLinks(int flowId);
    }
}
