﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorFlow.Data;
using AutoMapper;

namespace BlazorFlow.Services
{
    // To optimize
    public class FlowService : IFlowService
    {
        private readonly FlowContext context;
        private readonly IMapper mapper;

        public FlowService(FlowContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Models.Flow> GetFlow(int flowId)
        {
            var flow = await context.Flows.FindAsync(flowId);
            var flowModel = mapper.Map<Models.Flow>(flow);

            var links = await context.FlowLinks
                .Include(l => l.FlowNodePrevious)
                .Include(l => l.FlowNodeNext)
                .Include(l => l.FlowLinkConditions)
                .ThenInclude(c => c.FlowCondition)
                .Where(l => l.FlowId == flow.FlowId)
                .ToListAsync();

            var linkModels = mapper.Map<List<Models.FlowLink>>(links);

            flowModel.AddVerticesAndEdgeRange(linkModels);

            return flowModel;
        }

        public Models.FlowQuestion GetFlowNodeQuestion(int questionId)
        {
            var question = context.FlowQuestions.Find(questionId);
            return mapper.Map<Models.FlowQuestion>(question);
        }

        public List<Models.FlowAnswer> GetFlowNodeAnswers(int nodeId)
        {
            var nodeAnswers = context.FlowNodeAnswers
                .Where(x => x.FlowNodeId == nodeId)
                .Select(x => x.FlowAnswer)
                .ToList();

            return mapper.Map<List<Models.FlowAnswer>>(nodeAnswers);
        }
    }
}
