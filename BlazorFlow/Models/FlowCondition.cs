using System;

namespace BlazorFlow.Models
{
    public interface IFlowCondition
    {
        bool Evaluate();
    }

    public class FlowCondition<T, U> : IFlowCondition where T : IComparable where U : IComparable
    {
        private readonly Func<T, T, bool> operation;
        private readonly T requiredValue;
        private T userValue = default(T);

        public FlowCondition(Func<T, T, bool> operation, T requiredValue)
        {
            this.operation = operation;
            this.requiredValue = requiredValue;
        }

        public bool Evaluate()
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
