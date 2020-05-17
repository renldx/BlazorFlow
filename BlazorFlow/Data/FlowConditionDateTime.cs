using System;
using System.Linq;

namespace BlazorFlow.Data
{
    public partial class FlowCondition
    {
        private Func<DateTime, DateTime, bool>? datetimeOperation;
        private DateTime? requiredDateTime {get;set;}

        public FlowCondition(Func<DateTime, DateTime, bool> datetimeOperation, DateTime requiredDateTime) {
            this.datetimeOperation = datetimeOperation;
            this.requiredDateTime = requiredDateTime;
        }

        public bool Evaluate(DateTime? userDateTime) {
            if (userDateTime is {} udt && datetimeOperation is {} op && requiredDateTime is {} rdt) {
                return op(udt, rdt);
            }

            return false;
        }
    }
}
