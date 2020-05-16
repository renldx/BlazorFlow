using System;

namespace BlazorFlow.Data
{
    public partial class FlowCondition
    {
        private Func<decimal, decimal, bool>? operation;
        private decimal? requiredDecimal {get;set;}

        public FlowCondition(Func<decimal, decimal, bool> operation, decimal requiredDecimal) {
            this.operation = operation;
            this.requiredDecimal = requiredDecimal;
        }

        public bool Evaluate(decimal? userDecimal) {
            if (userDecimal is {} ud && operation is {} op && requiredDecimal is {} rd) {
                return op(ud, rd);
            }
            else {
                return false;
            }
        }
    }
}
