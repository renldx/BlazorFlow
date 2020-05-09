using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuikGraph;

namespace BlazorFlow.Data
{
    public class Flow : AdjacencyGraph<FlowNode, FlowLink>
    {
        public Flow(int flowId, double flowVersion)
        {
            FlowId = flowId;
            FlowVersion = flowVersion;
        }
        public int FlowId { get; set; }
        public double FlowVersion { get; set; }
    }
}
