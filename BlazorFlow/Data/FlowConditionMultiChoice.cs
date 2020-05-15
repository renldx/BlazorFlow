using System.Linq;

namespace BlazorFlow.Data
{
    public class FlowConditionMultiChoice : IFlowCondition
    {
        private string[] requiredValues {get;set;}
        private string[]? userValues {get;set;}

        public FlowConditionMultiChoice(string[] requiredValues) {
            this.requiredValues = requiredValues;
        }

        public void SetUserValue(string[] userValues) {
            this.userValues = userValues;
        }

        public bool Evaluate() {
            foreach (var value in requiredValues) {
                if (userValues.Any(value.Contains) == false) {
                    return false;
                }
            }

            return true;
        }
    }
}
