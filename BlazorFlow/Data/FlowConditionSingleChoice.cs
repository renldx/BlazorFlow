using System.Linq;

namespace BlazorFlow.Data
{
    public partial class FlowCondition
    {
        private string? requiredString {get;set;}

        public FlowCondition(string requiredString) {
            this.requiredString = requiredString;
        }

        public bool Evaluate(string? userString) {
            if (userString is {} us && requiredString is {} rs) {
                return us == rs;
            }

            return false;
        }
    }
}
