using System;

namespace BlazorFlow.Data
{
    public class FlowConditionNumberCompare : IFlowCondition
    {
        private Func<decimal, decimal, bool> operation;
        private decimal requiredValue {get;set;}
        private decimal? userValue {get;set;}

        public FlowConditionNumberCompare(Func<decimal, decimal, bool> operation, decimal requiredValue) {
            this.operation = operation;
            this.requiredValue = requiredValue;
        }

        public void SetUserValue(decimal userValue) {
            this.userValue = userValue;
        }

        public bool Evaluate() {
            if (userValue is {} uv) {
                return operation(uv, requiredValue);
            }
            else {
                return false;
            }
        }
    }
}
