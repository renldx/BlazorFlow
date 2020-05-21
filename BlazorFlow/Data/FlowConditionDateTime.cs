using System;
using System.Linq;

namespace BlazorFlow.Data
{
    public partial class FlowCondition
    {
        private Func<DateTime, DateTime, bool>? dateTimeOperation;
        private DateTime? requiredDateTime;

        // Second set of optional parameters used for ranges
        private Func<DateTime, DateTime, bool>? optionalDateTimeOperation;
        private DateTime? optionalDateTime;

        public FlowCondition(Func<DateTime, DateTime, bool> dateTimeOperation, DateTime requiredDateTime, Func<DateTime, DateTime, bool>? optionalDateTimeOperation = null, DateTime? optionalDateTime = null)
        {
            this.dateTimeOperation = dateTimeOperation;
            this.requiredDateTime = requiredDateTime;
            this.optionalDateTimeOperation = optionalDateTimeOperation;
            this.optionalDateTime = optionalDateTime;
        }

        public bool Evaluate(DateTime? userDateTime)
        {
            if (userDateTime is {} udt && dateTimeOperation is {} dtop && requiredDateTime is {} rdt)
            {
                if (optionalDateTimeOperation is {} odtop && optionalDateTime is {} odt)
                {
                    return dtop(udt, rdt) && odtop(udt, odt);
                }
                else
                {
                    return dtop(udt, rdt);
                }
            }

            return false;
        }
    }
}
