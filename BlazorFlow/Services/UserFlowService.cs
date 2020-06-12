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
            var userFlowModel = mapper.Map<Models.UserFlow>(userFlowData);
            userFlowModel.UserFlowId = userFlowData.UserFlowId;
            return userFlowModel;
        }

        public async Task<Models.UserFlowNode> AddUserFlowNode(Models.UserFlowNode userNode)
        {
            var userNodeData = mapper.Map<UserFlowNode>(userNode);
            context.UserFlowNodes.Add(userNodeData);
            await context.SaveChangesAsync();
            userNode.UserFlowNodeId = userNodeData.UserFlowNodeId;
            return userNode;
        }

        public async Task<Models.UserFlowNode> UpdateUserFlowNode(Models.UserFlowNode userNode)
        {
            var userNodeData = await context.UserFlowNodes.FindAsync(userNode.UserFlowNodeId);
            userNodeData.UserFlowAnswers = mapper.Map<UserFlowNode>(userNode).UserFlowAnswers;
            userNodeData.IsStale = userNode.IsStale;
            await context.SaveChangesAsync();
            return userNode;
        }
    }
}
