using System;
using System.Collections.Generic;
using System.Linq;
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
            if (FlowConditions.Any())
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
            else
            {
                return true;
            }
        }

        public bool IsAvailable(HashSet<string> userValues)
        {
            if (FlowConditions.Any())
            {
                var matchedFlowConditions = new List<FlowCondition>();

                foreach (var condition in FlowConditions)
                {
                    foreach (var userValue in userValues)
                    {
                        if (condition.Evaluate(userValue))
                        {
                            matchedFlowConditions.Add(condition);
                        }
                    }
                }

                return matchedFlowConditions.Count() >= FlowConditions.Count();
            }
            else
            {
                return true;
            }
        }

        public bool HasCondition()
        {
            return FlowConditions.Count > 0;
        }
    }
}
