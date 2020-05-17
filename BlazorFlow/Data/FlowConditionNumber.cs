using System;

namespace BlazorFlow.Data
{
    public partial class FlowCondition
    {
        private Func<decimal, decimal, bool>? decimalOperation;
        private decimal? requiredDecimal {get;set;}

        public FlowCondition(Func<decimal, decimal, bool> decimalOperation, decimal requiredDecimal) {
            this.decimalOperation = decimalOperation;
            this.requiredDecimal = requiredDecimal;
        }

        public bool Evaluate(decimal? userDecimal) {
            if (userDecimal is {} ud && decimalOperation is {} op && requiredDecimal is {} rd) {
                return op(ud, rd);
            }
            else {
                return false;
            }
        }
    }
}
