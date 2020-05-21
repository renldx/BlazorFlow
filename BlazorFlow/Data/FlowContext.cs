using System.Data.Entity;

namespace BlazorFlow.Data
{
    public class FlowContext : DbContext
    {
        public FlowContext() : base(nameOrConnectionString: "PostgreSQL")
        {

        }
    }
}
