using Microsoft.EntityFrameworkCore;

namespace BlazorFlow.Data
{
    public class FlowContext : DbContext
    {
        public FlowContext(DbContextOptions<FlowContext> options) : base(options) {}
    
        public DbSet<Flow> Flows {get; set; } = null!;
    }
}
