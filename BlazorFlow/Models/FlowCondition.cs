using System;

namespace BlazorFlow.Models
{
    public interface IFlowCondition
    {
        bool Evaluate();
    }

    public class FlowCondition<T> : IFlowCondition where T : IComparable
    {
        private readonly Func<T, T, bool> operation;
        private readonly T requiredValue;
        private T userValue;

        public FlowCondition(Func<T, T, bool> operation, T requiredValue)
        {
            this.operation = operation;
            this.requiredValue = requiredValue;
            userValue = default(T);
        }

        public void SetUserValue(T userValue)
        {
            this.userValue = userValue;
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
