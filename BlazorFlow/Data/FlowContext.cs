using System;
using Microsoft.EntityFrameworkCore;
using BlazorFlow.Enums;

namespace BlazorFlow.Data
{
    public class FlowContext : DbContext
    {
        public FlowContext(DbContextOptions<FlowContext> options) : base(options) {}
    
        public DbSet<Flow> Flows { get; set; } = null!;
        public DbSet<FlowNode> FlowNodes { get; set; } = null!;
        public DbSet<FlowLink> FlowLinks { get; set; } = null!;
        public DbSet<FlowLinkCondition> FlowLinkConditions { get; set; } = null!;
        public DbSet<FlowCondition> FlowConditions { get; set; } = null!;
        public DbSet<FlowQuestion> FlowQuestions { get; set; } = null!;
        public DbSet<FlowAnswer> FlowAnswers { get; set; } = null!;
        public DbSet<FlowNodeAnswer> FlowNodeAnswers { get; set; } = null!;
        public DbSet<UserFlow> UserFlows { get; set; } = null!;
        public DbSet<UserFlowNode> UserFlowNodes { get; set; } = null!;
        public DbSet<UserFlowAnswer> UserFlowAnswers { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<FlowNode>()
                .Property(n => n.FlowNodeType)
                .HasConversion(
                    v => v.ToString(),
                    v => (FlowValueType)Enum.Parse(typeof(FlowValueType), v));

            modelBuilder
                .Entity<FlowNode>()
                .Property(n => n.FlowNodeEntity)
                .HasConversion(
                    v => v.ToString(),
                    v => (FlowEntity)Enum.Parse(typeof(FlowEntity), v));

            modelBuilder
                .Entity<FlowCondition>()
                .Property(n => n.FlowConditionType)
                .HasConversion(
                    v => v.ToString(),
                    v => (FlowValueType)Enum.Parse(typeof(FlowValueType), v));

            modelBuilder
                .Entity<FlowCondition>()
                .Property(n => n.FlowConditionOperator)
                .HasConversion(
                    v => v.ToString(),
                    v => (FlowConditionOperator)Enum.Parse(typeof(FlowConditionOperator), v));

            modelBuilder
                .Entity<UserFlowAnswer>()
                .Property(u => u.UserFlowAnswerType)
                .HasConversion(
                    v => v.ToString(),
                    v => (FlowValueType)Enum.Parse(typeof(FlowValueType), v));

            // Composite keys for join tables

            modelBuilder
                .Entity<FlowNodeAnswer>()
                .HasKey(fna => new { fna.FlowNodeId, fna.FlowAnswerId });

            modelBuilder
                .Entity<FlowLinkCondition>()
                .HasKey(flc => new { flc.FlowLinkId, flc.FlowConditionId });

            // Seed Data

            modelBuilder
                .Entity<Flow>()
                .HasData(new Flow()
                {
                    FlowId = 1,
                    FlowVersion = 1
                });

            modelBuilder
                .Entity<FlowQuestion>()
                .HasData(new FlowQuestion[]
                {
                    new FlowQuestion()
                    {
                        FlowQuestionId = 1,
                        FlowQuestionCode = "START",
                        FlowQuestionTextEn = "Welcome! You're starting a new application.",
                        FlowQuestionTextFr = ""
                    },
                    new FlowQuestion()
                    {
                        FlowQuestionId = 2,
                        FlowQuestionCode = "SINGLERADIO",
                        FlowQuestionTextEn = "This is a single-choice question, in the form of radio buttons, representing primitive values.",
                        FlowQuestionTextFr = ""
                    },
                    new FlowQuestion()
                    {
                        FlowQuestionId = 3,
                        FlowQuestionCode = "SINGLESELECT",
                        FlowQuestionTextEn = "This is a single-choice question, in the form of a drop-down list, representing a lookup to an associated entity.",
                        FlowQuestionTextFr = ""
                    },
                    new FlowQuestion()
                    {
                        FlowQuestionId = 4,
                        FlowQuestionCode = "BADSINGLE",
                        FlowQuestionTextEn = "Invalid selection, try again.",
                        FlowQuestionTextFr = ""
                    },
                    new FlowQuestion()
                    {
                        FlowQuestionId = 5,
                        FlowQuestionCode = "NUMBER",
                        FlowQuestionTextEn = "This is a number range check, which needs to be in between 9000 and 10000.",
                        FlowQuestionTextFr = ""
                    },
                    new FlowQuestion()
                    {
                        FlowQuestionId = 6,
                        FlowQuestionCode = "BADNUMBER",
                        FlowQuestionTextEn = "Invalid number, try again.",
                        FlowQuestionTextFr = ""
                    },
                    new FlowQuestion()
                    {
                        FlowQuestionId = 7,
                        FlowQuestionCode = "MULTI",
                        FlowQuestionTextEn = "This is a multi-choice question, in the form of checkboxes.",
                        FlowQuestionTextFr = ""
                    },
                    new FlowQuestion()
                    {
                        FlowQuestionId = 8,
                        FlowQuestionCode = "BADMULTI",
                        FlowQuestionTextEn = "Invalid selections, try again.",
                        FlowQuestionTextFr = ""
                    },
                    new FlowQuestion()
                    {
                        FlowQuestionId = 9,
                        FlowQuestionCode = "DATE",
                        FlowQuestionTextEn = "This is a date check, which needs to be in the future from now.",
                        FlowQuestionTextFr = ""
                    },
                    new FlowQuestion()
                    {
                        FlowQuestionId = 10,
                        FlowQuestionCode = "BADDATE",
                        FlowQuestionTextEn = "Invalid date, try again.",
                        FlowQuestionTextFr = ""
                    },
                    new FlowQuestion()
                    {
                        FlowQuestionId = 11,
                        FlowQuestionCode = "TEXT",
                        FlowQuestionTextEn = "This is a text input box.",
                        FlowQuestionTextFr = ""
                    },
                    new FlowQuestion()
                    {
                        FlowQuestionId = 12,
                        FlowQuestionCode = "TEXTAREA",
                        FlowQuestionTextEn = "This is a paragraph input box.",
                        FlowQuestionTextFr = ""
                    },
                    new FlowQuestion()
                    {
                        FlowQuestionId = 13,
                        FlowQuestionCode = "END",
                        FlowQuestionTextEn = "You've completed the application. Thanks!",
                        FlowQuestionTextFr = ""
                    }
                });

            modelBuilder
                .Entity<FlowNode>()
                .HasData(new FlowNode[]
                {
                    new FlowNode()
                    {
                        FlowNodeId = 1,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowValueType.None,
                        FlowNodeEntity = FlowEntity.None,
                        FlowQuestionId = 1
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 2,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowValueType.Radio,
                        FlowNodeEntity = FlowEntity.None,
                        FlowQuestionId = 2
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 3,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowValueType.Select,
                        FlowNodeEntity = FlowEntity.Contact,
                        FlowQuestionId = 3
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 4,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowValueType.None,
                        FlowNodeEntity = FlowEntity.None,
                        FlowQuestionId = 4
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 5,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowValueType.Number,
                        FlowNodeEntity = FlowEntity.None,
                        FlowQuestionId = 5
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 6,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowValueType.None,
                        FlowNodeEntity = FlowEntity.None,
                        FlowQuestionId = 6
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 7,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowValueType.Checkbox,
                        FlowNodeEntity = FlowEntity.None,
                        FlowQuestionId = 7
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 8,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowValueType.None,
                        FlowNodeEntity = FlowEntity.None,
                        FlowQuestionId = 8
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 9,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowValueType.DateTime,
                        FlowNodeEntity = FlowEntity.None,
                        FlowQuestionId = 9
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 10,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowValueType.None,
                        FlowNodeEntity = FlowEntity.None,
                        FlowQuestionId = 10
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 11,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowValueType.Text,
                        FlowNodeEntity = FlowEntity.None,
                        FlowQuestionId = 11
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 12,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowValueType.TextArea,
                        FlowNodeEntity = FlowEntity.None,
                        FlowQuestionId = 12
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 13,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowValueType.None,
                        FlowNodeEntity = FlowEntity.None,
                        FlowQuestionId = 13
                    }
                });

            modelBuilder
                .Entity<FlowAnswer>()
                .HasData(new FlowAnswer[]
                {
                    new FlowAnswer()
                    {
                        FlowAnswerId = 1,
                        FlowAnswerCode = "YES",
                        FlowAnswerValue = "YES",
                        FlowAnswerTextEn = "Yes",
                        FlowAnswerTextFr = "Oui"
                    },
                    new FlowAnswer()
                    {
                        FlowAnswerId = 2,
                        FlowAnswerCode = "NO",
                        FlowAnswerValue = "NO",
                        FlowAnswerTextEn = "No",
                        FlowAnswerTextFr = "Non"
                    },
                    new FlowAnswer()
                    {
                        FlowAnswerId = 3,
                        FlowAnswerCode = "GOOD",
                        FlowAnswerValue = "GOOD",
                        FlowAnswerTextEn = "Good",
                        FlowAnswerTextFr = "Bon"
                    },
                    new FlowAnswer()
                    {
                        FlowAnswerId = 4,
                        FlowAnswerCode = "GREAT",
                        FlowAnswerValue = "GREAT",
                        FlowAnswerTextEn = "Great",
                        FlowAnswerTextFr = "Génial"
                    },
                    new FlowAnswer()
                    {
                        FlowAnswerId = 5,
                        FlowAnswerCode = "AMAZING",
                        FlowAnswerValue = "AMAZING",
                        FlowAnswerTextEn = "Amazing",
                        FlowAnswerTextFr = "Incroyable"
                    },
                    new FlowAnswer()
                    {
                        FlowAnswerId = 6,
                        FlowAnswerCode = "BAD",
                        FlowAnswerValue = "BAD",
                        FlowAnswerTextEn = "Bad",
                        FlowAnswerTextFr = "Mauv"
                    },
                });

            modelBuilder
                .Entity<FlowNodeAnswer>()
                .HasData(new FlowNodeAnswer[]
                {
                    new FlowNodeAnswer() { FlowNodeAnswerId = 1, FlowNodeId = 2, FlowAnswerId = 1 },
                    new FlowNodeAnswer() { FlowNodeAnswerId = 2, FlowNodeId = 2, FlowAnswerId = 2 },
                    new FlowNodeAnswer() { FlowNodeAnswerId = 3, FlowNodeId = 7, FlowAnswerId = 3 },
                    new FlowNodeAnswer() { FlowNodeAnswerId = 4, FlowNodeId = 7, FlowAnswerId = 4 },
                    new FlowNodeAnswer() { FlowNodeAnswerId = 5, FlowNodeId = 7, FlowAnswerId = 5 },
                    new FlowNodeAnswer() { FlowNodeAnswerId = 6, FlowNodeId = 7, FlowAnswerId = 6 }
                });

            modelBuilder
                .Entity<FlowLinkCondition>()
                .HasData(new FlowLinkCondition[]
                {
                    // Yes / No
                    new FlowLinkCondition() { FlowLinkConditionId = 1, FlowLinkId = 2, FlowConditionId = 1},

                    //  Between 9 and 10k
                    new FlowLinkCondition() { FlowLinkConditionId = 2, FlowLinkId = 5, FlowConditionId = 5 },
                    new FlowLinkCondition() { FlowLinkConditionId = 3, FlowLinkId = 5, FlowConditionId = 6 },

                    // Checkboxes
                    new FlowLinkCondition() { FlowLinkConditionId = 4, FlowLinkId = 7, FlowConditionId = 2 },
                    new FlowLinkCondition() { FlowLinkConditionId = 5, FlowLinkId = 7, FlowConditionId = 3 },
                    new FlowLinkCondition() { FlowLinkConditionId = 6, FlowLinkId = 7, FlowConditionId = 4 },

                    // Future Date
                    new FlowLinkCondition() { FlowLinkConditionId = 7, FlowLinkId = 9, FlowConditionId = 7 },
                });

            modelBuilder
                .Entity<FlowCondition>()
                .HasData(new FlowCondition[]
                {
                    new FlowCondition()
                    {
                        FlowConditionId = 1,
                        FlowConditionValue = "YES",
                        FlowConditionType = FlowValueType.Radio,
                        FlowConditionOperator = FlowConditionOperator.EqualTo
                    },
                    new FlowCondition()
                    {
                        FlowConditionId = 2,
                        FlowConditionValue = "GOOD",
                        FlowConditionType = FlowValueType.Checkbox,
                        FlowConditionOperator = FlowConditionOperator.EqualTo
                    },
                    new FlowCondition()
                    {
                        FlowConditionId = 3,
                        FlowConditionValue = "GREAT",
                        FlowConditionType = FlowValueType.Checkbox,
                        FlowConditionOperator = FlowConditionOperator.EqualTo
                    },
                    new FlowCondition()
                    {
                        FlowConditionId = 4,
                        FlowConditionValue = "AMAZING",
                        FlowConditionType = FlowValueType.Checkbox,
                        FlowConditionOperator = FlowConditionOperator.EqualTo
                    },
                    new FlowCondition()
                    {
                        FlowConditionId = 5,
                        FlowConditionValue = "9000",
                        FlowConditionType = FlowValueType.Number,
                        FlowConditionOperator = FlowConditionOperator.GreaterThan
                    },
                    new FlowCondition()
                    {
                        FlowConditionId = 6,
                        FlowConditionValue = "10000",
                        FlowConditionType = FlowValueType.Number,
                        FlowConditionOperator = FlowConditionOperator.LessThan
                    },
                    new FlowCondition()
                    {
                        FlowConditionId = 7,
                        FlowConditionValue = "2025-01-01",
                        FlowConditionType = FlowValueType.DateTime,
                        FlowConditionOperator = FlowConditionOperator.GreaterThanOrEqualTo
                    }
                });

            modelBuilder
                .Entity<FlowLink>()
                .HasData(new FlowLink[]
                {
                    new FlowLink()
                    {
                        FlowLinkId = 1,
                        FlowLinkVersion = 1,
                        FlowId = 1,
                        FlowNodePreviousId = 1,
                        FlowNodeNextId = 2
                    },
                    new FlowLink()
                    {
                        FlowLinkId = 2,
                        FlowLinkVersion = 1,
                        FlowId = 1,
                        FlowNodePreviousId = 2,
                        FlowNodeNextId = 3
                    },
                    new FlowLink()
                    {
                        FlowLinkId = 3,
                        FlowLinkVersion = 1,
                        FlowId = 1,
                        FlowNodePreviousId = 2,
                        FlowNodeNextId = 4
                    },
                    new FlowLink()
                    {
                        FlowLinkId = 4,
                        FlowLinkVersion = 1,
                        FlowId = 1,
                        FlowNodePreviousId = 3,
                        FlowNodeNextId = 5
                    },
                    new FlowLink()
                    {
                        FlowLinkId = 5,
                        FlowLinkVersion = 1,
                        FlowId = 1,
                        FlowNodePreviousId = 5,
                        FlowNodeNextId = 7
                    },
                    new FlowLink()
                    {
                        FlowLinkId = 6,
                        FlowLinkVersion = 1,
                        FlowId = 1,
                        FlowNodePreviousId = 5,
                        FlowNodeNextId = 6
                    },
                    new FlowLink()
                    {
                        FlowLinkId = 7,
                        FlowLinkVersion = 1,
                        FlowId = 1,
                        FlowNodePreviousId = 7,
                        FlowNodeNextId = 9
                    },
                    new FlowLink() 
                    {
                        FlowLinkId = 8,
                        FlowLinkVersion = 1,
                        FlowId = 1,
                        FlowNodePreviousId = 7,
                        FlowNodeNextId = 8
                    },
                    new FlowLink()
                    {
                        FlowLinkId = 9,
                        FlowLinkVersion = 1,
                        FlowId = 1,
                        FlowNodePreviousId = 9,
                        FlowNodeNextId = 11
                    },
                    new FlowLink()
                    {
                        FlowLinkId = 10,
                        FlowLinkVersion = 1,
                        FlowId = 1,
                        FlowNodePreviousId = 9,
                        FlowNodeNextId = 10
                    },
                    new FlowLink()
                    {
                        FlowLinkId = 11,
                        FlowLinkVersion = 1,
                        FlowId = 1,
                        FlowNodePreviousId = 11,
                        FlowNodeNextId = 12
                    },
                    new FlowLink()
                    {
                        FlowLinkId = 12,
                        FlowLinkVersion = 1,
                        FlowId = 1,
                        FlowNodePreviousId = 12,
                        FlowNodeNextId = 13
                    }
                });

            modelBuilder
                .Entity<Contact>()
                .HasData(new Contact[]
                {
                    new Contact()
                    {
                        ContactId = 1,
                        FirstName = "John",
                        LastName = "Doe",
                        DateOfBirth = DateTime.Now
                    },
                    new Contact()
                    {
                        ContactId = 2,
                        FirstName = "Eddie",
                        LastName = "Murphy",
                        DateOfBirth = DateTime.Now
                    },
                    new Contact()
                    {
                        ContactId = 3,
                        FirstName = "Jim",
                        LastName = "Carrey",
                        DateOfBirth = DateTime.Now
                    }
                });
        }
    }
}
