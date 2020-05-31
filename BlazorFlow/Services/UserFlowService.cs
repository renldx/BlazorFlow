using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorFlow.Data;
using AutoMapper;

namespace BlazorFlow.Services
{
    public class UserFlowService : IUserFlowService
    {
        private readonly FlowContext context;
        private readonly IMapper mapper;

        public UserFlowService(FlowContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Models.UserFlow> GetUserFlow(int userFlowId)
        {
            var userFlow = await context.UserFlows.FindAsync(userFlowId);
            var userFlowModel = mapper.Map<Models.UserFlow>(userFlow);

            var userNodes = await context.UserFlowNodes
                .Where(n => n.UserFlowId == userFlowId)
                .ToListAsync();

            var userNodeModels = mapper.Map<List<Models.UserFlowNode>>(userNodes);

            foreach(var userNodeModel in userNodeModels)
            {
                userFlowModel.UserFlowNodes.Append(userNodeModel);
            }

            return userFlowModel;
        }

        public async Task<Models.UserFlow> CreateUserFlow(int userId, int flowId)
        {
            var userFlowData = new UserFlow() { UserFlowId = 1, UserId = userId, FlowId = flowId };
            context.UserFlows.Add(userFlowData);
            await context.SaveChangesAsync();
            return mapper.Map<Models.UserFlow>(userFlowData);
        }

        public async Task AddUserFlowAnswer(Models.UserFlowNode userNode)
        {
            var userNodeData = mapper.Map<UserFlowNode>(userNode);
            context.UserFlowNodes.Add(userNodeData);
            await context.SaveChangesAsync();
        }

        public async Task UpdateUserFlowAnswer(Models.UserFlowNode userNode)
        {
            var userNodeData = mapper.Map<UserFlowNode>(userNode);
            context.Entry(userNodeData).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
