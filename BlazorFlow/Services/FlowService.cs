using System.Linq;
using System.Threading.Tasks;
using BlazorFlow.Helpers;

namespace BlazorFlow.Data
{
    public class FlowService
    {
        public Task<Flow> GetFlow(int flowVersion)
        {
            return Task.FromResult(BuildFlow(flowVersion));
        }

        Flow BuildFlow(int flowVersion)
        {
            var flowQuestions = BuildFlowQuestions();
            var flowAnswers = BuildFlowAnswers();

            Flow flow = new Flow(flowVersion);

            var node1 = new FlowNode(flowQuestions.First(x => x.FlowQuestionCode == "START"), FlowNodeType.none);
            var node2 = new FlowNode(flowQuestions.First(x => x.FlowQuestionCode == "RUREADY"), FlowNodeType.radio, new FlowAnswer[] { flowAnswers[0], flowAnswers[1] });
            var node3 = new FlowNode(flowQuestions.First(x => x.FlowQuestionCode == "NOTREADY"), FlowNodeType.none);
            var node4 = new FlowNode(flowQuestions.First(x => x.FlowQuestionCode == "2RUMBLE"), FlowNodeType.number);
            var node5 = new FlowNode(flowQuestions.First(x => x.FlowQuestionCode == "NOTENOUGH"), FlowNodeType.none);
            var node6 = new FlowNode(flowQuestions.First(x => x.FlowQuestionCode == "END"), FlowNodeType.none);

            var cond1 = new FlowCondition(0);
            var cond2 = new FlowCondition(1);
            var cond3 = new FlowCondition(OperationHelper.LessThan<decimal>(), 9000);
            var cond4 = new FlowCondition(OperationHelper.GreaterThanOrEqualTo<decimal>(), 9000);

            var link1 = new FlowLink(node1, node2);
            var link2 = new FlowLink(node2, node3, cond1);
            var link3 = new FlowLink(node2, node4, cond2);
            var link4 = new FlowLink(node4, node5, cond3);
            var link5 = new FlowLink(node4, node6, cond4);

            flow.AddVertex(node1);
            flow.AddVertex(node2);
            flow.AddVertex(node3);
            flow.AddVertex(node4);
            flow.AddVertex(node5);
            flow.AddVertex(node6);

            flow.AddEdge(link1);
            flow.AddEdge(link2);
            flow.AddEdge(link3);
            flow.AddEdge(link4);
            flow.AddEdge(link5);

            return flow;
        }

        FlowQuestion[] BuildFlowQuestions()
        {
            return new FlowQuestion[]
            {
                new FlowQuestion()
                {
                    FlowQuestionCode = "START",
                    FlowQuestionTextEn = "Welcome! You're starting a new application."
                },
                new FlowQuestion()
                {
                    FlowQuestionCode = "RUREADY",
                    FlowQuestionTextEn = "Are you ready to rumble?"
                },
                new FlowQuestion()
                {
                    FlowQuestionCode = "NOTREADY",
                    FlowQuestionTextEn = "You must be able ready to rumble to continue."
                },
                new FlowQuestion()
                {
                    FlowQuestionCode = "2RUMBLE",
                    FlowQuestionTextEn = "How many times have you rumbled?",
                },
                new FlowQuestion()
                {
                    FlowQuestionCode = "NOTENOUGH",
                    FlowQuestionTextEn = "You must have rumbled at least 9000 times to continue."
                },
                new FlowQuestion()
                {
                    FlowQuestionCode = "END",
                    FlowQuestionTextEn = "Done! Now go away."
                }
            };
        }

        FlowAnswer[] BuildFlowAnswers()
        {
            return new FlowAnswer[]
            {
                new FlowAnswer()
                {
                    FlowAnswerCode = "YES",
                    FlowAnswerTextEn = "Yes",
                    FlowAnswerValue = "1"
                },
                new FlowAnswer()
                {
                    FlowAnswerCode = "NO",
                    FlowAnswerTextEn = "No",
                    FlowAnswerValue = "0"
                }
            };
        }
    }
}
