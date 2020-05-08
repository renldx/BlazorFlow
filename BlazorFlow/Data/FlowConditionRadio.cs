using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Data
{
    public class FlowConditionRadio : IFlowCondition
    {
        readonly bool requiredValue;
        bool? userValue;

        public FlowConditionRadio(bool requiredValue)
        {
            this.requiredValue = requiredValue;
        }

        public void SetUserValue<T>(T userValue) where T : IComparable
        {
            this.userValue = userValue as bool?;
        }

        public bool Evaluate()
        {
            if (userValue.HasValue)
            {
                return userValue.Value == requiredValue;
            }

            return false;
        }
    }
}
