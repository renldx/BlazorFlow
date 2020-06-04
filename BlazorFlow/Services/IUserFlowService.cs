using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorFlow.Models;

namespace BlazorFlow.Services
{
    public interface IUserFlowService
    {
        Task<Models.UserFlow> GetUserFlow(int userFlowId);
        Task<Models.UserFlow> CreateUserFlow(int userId, int flowId);
        Task<Models.UserFlowNode> AddUserFlowNode(Models.UserFlowNode userNode);
        Task<Models.UserFlowNode> UpdateUserFlowNode(Models.UserFlowNode userNode);
    }
}
