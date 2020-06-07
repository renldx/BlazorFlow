using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorFlow.Models;

namespace BlazorFlow.Services
{
    public interface IFlowService
    {
        Task<Models.Flow> GetFlow(int flowId);
        Models.FlowQuestion GetFlowNodeQuestion(int questionId);
        List<Models.FlowAnswer> GetFlowNodeAnswers(int nodeId);
    }
}
