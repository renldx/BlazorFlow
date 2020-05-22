using System;
using System.Linq;

namespace BlazorFlow.Data
{
    public partial class FlowCondition
    {
        private readonly Func<DateTime, DateTime, bool>? dateTimeOperation;
        private readonly DateTime? requiredDateTime;

        // Second set of optional parameters used for ranges
        private readonly Func<DateTime, DateTime, bool>? optionalDateTimeOperation;
        private readonly DateTime? optionalDateTime;

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
