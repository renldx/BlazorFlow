using System;

namespace BlazorFlow.Data
{
    public partial class FlowCondition
    {
        private Func<decimal, decimal, bool>? operation;
        private decimal? requiredValue {get;set;}

        public FlowCondition(Func<decimal, decimal, bool> operation, decimal requiredValue) {
            this.operation = operation;
            this.requiredValue = requiredValue;
        }

        public bool Evaluate(decimal userValue) {
            if (operation is {} op && requiredValue is {} rv) {
                return op(userValue, rv);
            }
            else {
                return false;
            }
        }
    }
}
