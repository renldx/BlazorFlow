using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFlow.Data
{
    public interface IFlowCondition
    {
        public void SetUserValue<T>(T userValue) where T : IComparable;

        public bool Evaluate();
    }
}
