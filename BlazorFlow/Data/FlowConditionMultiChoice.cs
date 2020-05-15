using System.Linq;

namespace BlazorFlow.Data
{
    public partial class FlowCondition
    {
        private string[]? requiredValues {get;set;}

        public FlowCondition(string[] requiredValues) {
            this.requiredValues = requiredValues;
        }

        public bool Evaluate(string[]? userValues) {
            if (requiredValues is {} rv) {
                foreach (var value in rv) {
                    if (userValues.Any(value.Contains) == false) {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
