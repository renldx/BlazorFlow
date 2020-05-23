using System.Collections.Generic;
using System.Linq;

namespace BlazorFlow.Models
{
    public partial class FlowCondition
    {
        private readonly HashSet<string>? requiredStrings;

        public FlowCondition(HashSet<string> requiredStrings)
        {
            this.requiredStrings = requiredStrings;
        }

        public bool Evaluate(HashSet<string>? userStrings)
        {
            if (userStrings is {} us && requiredStrings is {} rs)
            {
                return us.SetEquals(rs);
            }
            else
            {
                return false;
            }
        }
    }
}
