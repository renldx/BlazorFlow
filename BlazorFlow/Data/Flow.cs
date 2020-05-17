using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuikGraph;

namespace BlazorFlow.Data
{
    public class Flow : AdjacencyGraph<FlowNode, FlowLink>
    {
        //int FlowId;
        public double FlowVersion { get; }
        
        public Flow(double flowVersion)
        {
            FlowVersion = flowVersion;
        }
    }
}
