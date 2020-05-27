using System;

namespace BlazorFlow.Models
{
    public class FlowCondition
    {
        private readonly Func<IComparable, IComparable, bool> operation;
        private readonly IComparable requiredValue;

        public FlowCondition(Func<IComparable, IComparable, bool> operation, IComparable requiredValue)
        {
            this.operation = operation;
            this.requiredValue = requiredValue;
        }

        public int FlowConditionId { get; set; }

        public bool Evaluate(IComparable userValue)
        {
            if (userValue is {} uv && operation is {} op && requiredValue is {} rv)
            {
                return op(uv, rv);
            }
            else {
                return false;
            }
        }
    }
}
