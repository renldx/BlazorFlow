using BlazorFlow.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Data
{
    public class FlowCondition
    {
        readonly int? requiredInt;
        readonly Func<decimal, decimal, bool>? operation;
        readonly decimal? requiredDecimal;

        public FlowCondition(int requiredInt)
        {
            this.requiredInt = requiredInt;
        }

        public FlowCondition(Func<decimal, decimal, bool> operation, decimal requiredDecimal)
        {
            this.operation = operation;
            this.requiredDecimal = requiredDecimal;
        }

        public bool Evaluate(int? userInt = null, decimal? userDecimal = null)
        {
            if (userInt.HasValue && requiredInt.HasValue)
            {
                return userInt.Value == requiredInt;
            }
            else if (userDecimal.HasValue && requiredDecimal.HasValue && operation != null)
            {
                return operation(userDecimal.Value, requiredDecimal.Value);
            }

            return false;
        }
    }
}
