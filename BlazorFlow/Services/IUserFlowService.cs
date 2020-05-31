using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorFlow.Models;

namespace BlazorFlow.Services
{
    public interface IUserFlowService
    {
        Task<Models.UserFlow> GetUserFlow(int userFlowId);
        Task<Models.UserFlow> CreateUserFlow(int userId, int flowId);
        Task AddUserFlowAnswer(Models.UserFlowNode userNode);
        Task UpdateUserFlowAnswer(Models.UserFlowNode userNode);
    }
}
