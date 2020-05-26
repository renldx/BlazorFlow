using System;

namespace BlazorFlow.Models
{
    public interface IFlowCondition {}

    public class FlowCondition<T> : IFlowCondition where T : IComparable
    {
        private readonly Func<T, T, bool> operation;
        private readonly T requiredValue;

        public FlowCondition(Func<T, T, bool> operation, T requiredValue)
        {
            this.operation = operation;
            this.requiredValue = requiredValue;
        }

        public bool Evaluate(T userValue)
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
