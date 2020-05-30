using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorFlow.Data;
using AutoMapper;

namespace BlazorFlow.Services
{
    public class UserFlowService
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
            var userFlow = await context.UserFlows.FindAsync(userFlowId) ?? new UserFlow();
            var userFlowModel = mapper.Map<Models.UserFlow>(userFlow);

            var userAnswers = await context.UserFlowNodes
                .Where(n => n.UserFlowId == userFlowId)
                .ToListAsync();

            var userAnswerModels = mapper.Map<List<Models.UserFlowAnswer>>(userAnswers);

            foreach(var userAnswerModel in userAnswerModels)
            {
                userFlowModel.UserFlowAnswers.Append(userAnswerModel);
            }

            return userFlowModel;
        }
    }
}
