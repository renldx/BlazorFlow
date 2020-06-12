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

        public bool IsAvailable(IComparable? userValue)
        {
            if (FlowConditions.Any() && userValue is {} existing)
            {
                foreach (var condition in FlowConditions)
                {
                    if (condition.Evaluate(existing) == false)
                    {
                        return false;
                    }
                }

                return true;
            }
            else if (FlowConditions.Any() && userValue is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Currently selecting all checkboxes will work unless specifically adding a condition to keep "bad" unselected
        public bool IsAvailable(HashSet<string>? userValues)
        {
            // Theres a condition and user answer
            if (FlowConditions.Any() && userValues is {} existing)
            {
                var matchedFlowConditions = new List<FlowCondition>();

                foreach (var condition in FlowConditions)
                {
                    foreach (var userValue in existing)
                    {
                        if (condition.Evaluate(userValue))
                        {
                            matchedFlowConditions.Add(condition);
                        }
                    }
                }

                return matchedFlowConditions.Count() >= FlowConditions.Count();
            }
            // Theres a condition but no user answer
            else if (FlowConditions.Any() && userValues is null)
            {
                return false;
            }
            // Theres no condition
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
