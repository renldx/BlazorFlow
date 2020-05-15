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

            Flow flow = new Flow(1, flowVersion);

            var node1 = new FlowNode(1, 1, flowQuestions.First(x => x.FlowQuestionCode == "START"), FlowNodeType.none);
            var node2 = new FlowNode(2, 1, flowQuestions.First(x => x.FlowQuestionCode == "RUREADY"), FlowNodeType.singleChoice, new FlowAnswer[] { flowAnswers[0], flowAnswers[1] });
            var node3 = new FlowNode(3, 1, flowQuestions.First(x => x.FlowQuestionCode == "NOTREADY"), FlowNodeType.none);
            var node4 = new FlowNode(4, 1, flowQuestions.First(x => x.FlowQuestionCode == "2RUMBLE"), FlowNodeType.numberCompare);
            var node5 = new FlowNode(5, 1, flowQuestions.First(x => x.FlowQuestionCode == "NOTENOUGH"), FlowNodeType.none);
            var node6 = new FlowNode(6, 1, flowQuestions.First(x => x.FlowQuestionCode == "END"), FlowNodeType.none);

            var cond1 = new FlowCondition(new string[] { "NO" });
            var cond2 = new FlowCondition(new string[] { "YES" });
            var cond3 = new FlowCondition(OperationHelper.LessThan<decimal>(), 9000);
            var cond4 = new FlowCondition(OperationHelper.GreaterThanOrEqualTo<decimal>(), 9000);

            var link1 = new FlowLink(1, 1, node1, node2);
            var link2 = new FlowLink(2, 1, node2, node3, cond1);
            var link3 = new FlowLink(3, 1, node2, node4, cond2);
            var link4 = new FlowLink(4, 1, node4, node5, cond3);
            var link5 = new FlowLink(5, 1, node4, node6, cond4);

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
                new FlowQuestion(1, "START", "Welcome! You're starting a new application.", ""),
                new FlowQuestion(2, "RUREADY", "Are you ready to rumble?", ""),
                new FlowQuestion(3, "NOTREADY", "You must be able ready to rumble to continue.", ""),
                new FlowQuestion(4, "2RUMBLE", "How many times have you rumbled?", ""),
                new FlowQuestion(5, "NOTENOUGH", "You must have rumbled at least 9000 times to continue.", ""),
                new FlowQuestion(6, "END", "Done! Now go away.", "")
            };
        }

        FlowAnswer[] BuildFlowAnswers()
        {
            return new FlowAnswer[]
            {
                new FlowAnswer(1, "YES", "YES", "Yes", "Oui"),
                new FlowAnswer(2, "NO", "NO", "No", "Non")
            };
        }
    }
}
