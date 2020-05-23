using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using BlazorFlow.Data;
using BlazorFlow.Models;
using BlazorFlow.Enums;
using BlazorFlow.Helpers;

namespace BlazorFlow.Services
{
    public class FlowService : IFlowService
    {
        private readonly FlowContext context;
        private readonly IMapper mapper;

        public FlowService(FlowContext context, IMapper mapper) {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Models.Flow> GetFlow(int flowId)
        {
            var flow = await context.Flows.FindAsync(flowId);
            return mapper.Map<Models.Flow>(flow);
        }

        Models.Flow BuildFlow()
        {
            var flowQuestions = BuildFlowQuestions();
            var flowAnswers = BuildFlowAnswers();

            Models.Flow flow = new Models.Flow();

            var node1 = new Models.FlowNode(1, 1, flowQuestions.First(x => x.FlowQuestionCode == "START"));
            var node2 = new Models.FlowNode(2, 1, flowQuestions.First(x => x.FlowQuestionCode == "SINGLERADIO"), FlowNodeType.radio, FlowNodeEntity.none, new Models.FlowAnswer[] { flowAnswers[0], flowAnswers[1] });
            var node3 = new Models.FlowNode(3, 1, flowQuestions.First(x => x.FlowQuestionCode == "SINGLESELECT"), FlowNodeType.select, FlowNodeEntity.contact);
            var node4 = new Models.FlowNode(4, 1, flowQuestions.First(x => x.FlowQuestionCode == "BADSINGLE"));
            var node5 = new Models.FlowNode(5, 1, flowQuestions.First(x => x.FlowQuestionCode == "NUMBER"), FlowNodeType.number);
            var node6 = new Models.FlowNode(6, 1, flowQuestions.First(x => x.FlowQuestionCode == "BADNUMBER"));
            var node7 = new Models.FlowNode(7, 1, flowQuestions.First(x => x.FlowQuestionCode == "MULTI"), FlowNodeType.checkbox, FlowNodeEntity.none, new Models.FlowAnswer[] { flowAnswers[2], flowAnswers[3], flowAnswers[4], flowAnswers[5] });
            var node8 = new Models.FlowNode(8, 1, flowQuestions.First(x => x.FlowQuestionCode == "BADMULTI"));
            var node9 = new Models.FlowNode(9, 1, flowQuestions.First(x => x.FlowQuestionCode == "DATE"), FlowNodeType.datetime);
            var node10 = new Models.FlowNode(10, 1, flowQuestions.First(x => x.FlowQuestionCode == "BADDATE"));
            var node11 = new Models.FlowNode(11, 1, flowQuestions.First(x => x.FlowQuestionCode == "TEXT"), FlowNodeType.text);
            var node12 = new Models.FlowNode(12, 1, flowQuestions.First(x => x.FlowQuestionCode == "TEXTAREA"), FlowNodeType.textarea);
            var node13 = new Models.FlowNode(13, 1, flowQuestions.First(x => x.FlowQuestionCode == "END"));

            var cond1 = new Models.FlowCondition("YES");
            var cond2 = new Models.FlowCondition(OperationHelper.GreaterThanOrEqualTo<decimal>(), 9000, OperationHelper.LessThanOrEqualTo<decimal>(), 10000);
            var cond3 = new Models.FlowCondition(new HashSet<string> { "GOOD", "GREAT", "AMAZING" });
            var cond4 = new Models.FlowCondition(OperationHelper.GreaterThan<DateTime>(), DateTime.Now);

            var link1 = new Models.FlowLink(1, node1, node2);
            var link2 = new Models.FlowLink(1, node2, node3, cond1);
            var link3 = new Models.FlowLink(1, node2, node4);
            var link4 = new Models.FlowLink(1, node3, node5);
            var link5 = new Models.FlowLink(1, node5, node7, cond2);
            var link6 = new Models.FlowLink(1, node5, node6);
            var link7 = new Models.FlowLink(1, node7, node9, cond3);
            var link8 = new Models.FlowLink(1, node7, node8);
            var link9 = new Models.FlowLink(1, node9, node11, cond4);
            var link10 = new Models.FlowLink(1, node9, node10);
            var link11 = new Models.FlowLink(1, node11, node12);
            var link12 = new Models.FlowLink(1, node12, node13);

            flow.AddVertex(node1);
            flow.AddVertex(node2);
            flow.AddVertex(node3);
            flow.AddVertex(node4);
            flow.AddVertex(node5);
            flow.AddVertex(node6);
            flow.AddVertex(node7);
            flow.AddVertex(node8);
            flow.AddVertex(node9);
            flow.AddVertex(node10);
            flow.AddVertex(node11);
            flow.AddVertex(node12);
            flow.AddVertex(node13);

            flow.AddEdge(link1);
            flow.AddEdge(link2);
            flow.AddEdge(link3);
            flow.AddEdge(link4);
            flow.AddEdge(link5);
            flow.AddEdge(link6);
            flow.AddEdge(link7);
            flow.AddEdge(link8);
            flow.AddEdge(link9);
            flow.AddEdge(link10);
            flow.AddEdge(link11);
            flow.AddEdge(link12);

            return flow;
        }

        Models.FlowQuestion[] BuildFlowQuestions()
        {
            return new Models.FlowQuestion[]
            {
                new Models.FlowQuestion("START", "Welcome! You're starting a new application."),
                new Models.FlowQuestion("SINGLERADIO", "This is a single-choice question, in the form of radio buttons, representing primitive values."),
                new Models.FlowQuestion("SINGLESELECT", "This is a single-choice question, in the form of a drop-down list, representing a lookup to an associated entity."),
                new Models.FlowQuestion("BADSINGLE", "Invalid selection, try again."),
                new Models.FlowQuestion("NUMBER", "This is a number range check, which needs to be in between 9000 and 10000."),
                new Models.FlowQuestion("BADNUMBER", "Invalid number, try again."),
                new Models.FlowQuestion("MULTI", "This is a multi-choice question, in the form of checkboxes."),
                new Models.FlowQuestion("BADMULTI", "Invalid selections, try again."),
                new Models.FlowQuestion("DATE", "This is a date check, which needs to be in the future from now."),
                new Models.FlowQuestion("BADDATE", "Invalid date, try again."),
                new Models.FlowQuestion("TEXT", "This is a text input box."),
                new Models.FlowQuestion("TEXTAREA", "This is a paragraph input box."),
                new Models.FlowQuestion("END", "You've completed the application. Thanks!")
            };
        }

        Models.FlowAnswer[] BuildFlowAnswers()
        {
            return new Models.FlowAnswer[]
            {
                new Models.FlowAnswer("YES", "YES", "Yes"),
                new Models.FlowAnswer("NO", "NO", "No"),
                new Models.FlowAnswer("GOOD", "GOOD", "Good"),
                new Models.FlowAnswer("GREAT", "GREAT", "Great"),
                new Models.FlowAnswer("AMAZING", "AMAZING", "Amazing"),
                new Models.FlowAnswer("BAD", "BAD", "Bad"),
            };
        }
    }
}
