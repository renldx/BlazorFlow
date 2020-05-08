using BlazorFlow.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Data
{
    public class FlowConditionNumber : IFlowCondition
    {
        readonly Func<decimal, decimal, bool> operation;
        readonly decimal requiredValue;
        decimal? userValue;

        public FlowConditionNumber(Func<decimal, decimal, bool> operation, decimal requiredValue)
        {
            this.operation = operation;
            this.requiredValue = requiredValue;
        }

        public void SetUserValue<T>(T userValue) where T : IComparable
        {
            this.userValue = userValue as decimal?;
        }

        public bool Evaluate()
        {
            if (userValue.HasValue)
            {
                return operation(userValue.Value, requiredValue);
            }

            return false;
        }
    }
}
