using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuikGraph;
using System.ComponentModel.DataAnnotations;

namespace BlazorFlow.Data
{
    public class Flow : AdjacencyGraph<FlowNode, FlowLink>
    {
        [Key]
        public int FlowId { get; set; }
        [Required]
        public double FlowVersion { get; set; }
        
        public Flow(double flowVersion)
        {
            FlowVersion = flowVersion;
        }
    }
}
