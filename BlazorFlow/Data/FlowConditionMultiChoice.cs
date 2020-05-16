using System.Collections.Generic;
using System.Linq;

namespace BlazorFlow.Data
{
    public partial class FlowCondition
    {
        private HashSet<string>? requiredStrings {get;set;}

        public FlowCondition(HashSet<string> requiredStrings) {
            this.requiredStrings = requiredStrings;
        }

        public bool Evaluate(HashSet<string>? userStrings) {
            if (userStrings is {} us && requiredStrings is {} rs) {
                return us.SetEquals(rs);
            }
            else {
                return false;
            }
        }
    }
}
