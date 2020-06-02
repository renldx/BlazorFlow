using System;
using System.Collections.Generic;
using QuikGraph;

namespace BlazorFlow.Models
{
    public class FlowLink : Edge<FlowNode>
    {
        public FlowLink(double flowLinkVersion, FlowNode fromFlowNode, FlowNode toFlowNode, List<FlowCondition> flowConditions = null!) : base(fromFlowNode, toFlowNode)
        {
            FlowLinkVersion = flowLinkVersion;
            FlowConditions = flowConditions;
        }

        public int FlowLinkId { get; set; }
        public double FlowLinkVersion { get; set; }
        List<FlowCondition> FlowConditions { get; set; }

        public bool IsAvailable(IComparable userValue)
        {
            foreach (var condition in FlowConditions)
            {
                if (condition.Evaluate(userValue) == false)
                {
                    return false;
                }
            }

            return true;
        }

        public bool HasCondition()
        {
            return FlowConditions.Count > 0;
        }
    }
}
