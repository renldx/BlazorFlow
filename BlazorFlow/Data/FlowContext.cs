using Microsoft.EntityFrameworkCore;

namespace BlazorFlow.Data
{
    public class FlowContext : DbContext
    {
        public DbSet<Flow> Flows { get; set; } = null!;
    }
}
