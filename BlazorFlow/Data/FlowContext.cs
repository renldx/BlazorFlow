using Microsoft.EntityFrameworkCore;

namespace BlazorFlow.Data
{
    public class FlowContext : DbContext
    {
        public FlowContext(DbContextOptions<FlowContext> options) : base(options) {}
    
        public DbSet<Flow> Flows { get; set; } = null!;
        public DbSet<FlowNode> FlowNodes { get; set; } = null!;
        public DbSet<FlowLink> FlowLink { get; set; } = null!;
        public DbSet<FlowCondition> FlowConditions { get; set; } = null!;
        public DbSet<FlowQuestion> FlowQuestions { get; set; } = null!;
        public DbSet<FlowAnswer> FlowAnswers { get; set; } = null!;
        public DbSet<UserFlow> UserFlows { get; set; } = null!;
        public DbSet<UserFlowAnswer> UserFlowAnswers { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;
    }
}
