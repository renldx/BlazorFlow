using System;
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
        public DbSet<FlowConditionValue> FlowConditionValues { get; set; } = null!;
        public DbSet<FlowQuestion> FlowQuestions { get; set; } = null!;
        public DbSet<FlowAnswer> FlowAnswers { get; set; } = null!;
        public DbSet<UserFlow> UserFlows { get; set; } = null!;
        public DbSet<UserFlowAnswer> UserFlowAnswers { get; set; } = null!;
        public DbSet<UserFlowAnswerValue> UserFlowAnswerValues { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder
            //     .Entity<Flow>()
            //     .HasMany(f => f.FlowNodes)
            //     .WithOne(n => n.Flow)
            //     .IsRequired(false);

            // modelBuilder
            //     .Entity<Flow>()
            //     .HasMany(f => f.FlowNodes)
            //     .WithOne(n => n.Flow)
            //     .IsRequired(false);

            modelBuilder
                .Entity<FlowNode>()
                .Property(n => n.FlowNodeType)
                .HasConversion(
                    v => v.ToString(),
                    v => (FlowNodeType)Enum.Parse(typeof(FlowNodeType), v));

            modelBuilder
                .Entity<FlowNode>()
                .Property(n => n.FlowNodeEntity)
                .HasConversion(
                    v => v.ToString(),
                    v => (FlowNodeEntity)Enum.Parse(typeof(FlowNodeEntity), v));
        }
    }
}
