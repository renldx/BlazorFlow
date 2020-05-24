using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorFlow.Data
{
    public class FlowContext : DbContext
    {
        public FlowContext(DbContextOptions<FlowContext> options) : base(options) {}
    
        public DbSet<Flow> Flows { get; set; } = null!;
        public DbSet<FlowNode> FlowNodes { get; set; } = null!;
        public DbSet<FlowLink> FlowLinks { get; set; } = null!;
        public DbSet<FlowCondition> FlowConditions { get; set; } = null!;
        public DbSet<FlowConditionValue> FlowConditionValues { get; set; } = null!;
        public DbSet<FlowQuestion> FlowQuestions { get; set; } = null!;
        public DbSet<FlowAnswer> FlowAnswers { get; set; } = null!;
        public DbSet<FlowNodeAnswer> FlowNodeAnswers { get; set; } = null!;
        public DbSet<UserFlow> UserFlows { get; set; } = null!;
        public DbSet<UserFlowAnswer> UserFlowAnswers { get; set; } = null!;
        public DbSet<UserFlowAnswerValue> UserFlowAnswerValues { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            modelBuilder
                .Entity<FlowConditionValue>()
                .Property(n => n.FlowConditionValueOperator)
                .HasConversion(
                    v => v.ToString(),
                    v => (FlowConditionValueOperator)Enum.Parse(typeof(FlowConditionValueOperator), v));

            modelBuilder
                .Entity<FlowNodeAnswer>()
                .HasKey(fna => new { fna.FlowNodeId, fna.FlowAnswerId });

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
                        FlowNodeType = FlowNodeType.none,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestionId = 1
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 2,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowNodeType.radio,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestionId = 2
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 3,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowNodeType.select,
                        FlowNodeEntity = FlowNodeEntity.contact,
                        FlowQuestionId = 3
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 4,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowNodeType.none,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestionId = 4
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 5,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowNodeType.number,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestionId = 5
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 6,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowNodeType.none,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestionId = 6
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 7,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowNodeType.checkbox,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestionId = 7
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 8,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowNodeType.none,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestionId = 8
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 9,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowNodeType.datetime,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestionId = 9
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 10,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowNodeType.none,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestionId = 10
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 11,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowNodeType.text,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestionId = 11
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 12,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowNodeType.textarea,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestionId = 12
                    },
                    new FlowNode()
                    {
                        FlowNodeId = 13,
                        FlowNodeVersion = 1,
                        FlowId = 1,
                        FlowNodeType = FlowNodeType.none,
                        FlowNodeEntity = FlowNodeEntity.none,
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
                .Entity<FlowCondition>()
                .HasData(new FlowCondition[]
                {
                    new FlowCondition() { FlowConditionId = 1 },
                    new FlowCondition() { FlowConditionId = 2 },
                    new FlowCondition() { FlowConditionId = 3 },
                    new FlowCondition() { FlowConditionId = 4 }
                });

            modelBuilder
                .Entity<FlowConditionValue>()
                .HasData(new FlowConditionValue[]
                {
                    new FlowConditionValue()
                    {
                        FlowConditionValueId = 1,
                        FlowConditionValueString = "YES",
                        FlowConditionId = 1
                    },
                    new FlowConditionValue()
                    {
                        FlowConditionValueId = 2,
                        FlowConditionValueString = "GOOD",
                        FlowConditionId = 2
                    },
                    new FlowConditionValue()
                    {
                        FlowConditionValueId = 3,
                        FlowConditionValueString = "GREAT",
                        FlowConditionId = 2
                    },
                    new FlowConditionValue()
                    {
                        FlowConditionValueId = 4,
                        FlowConditionValueString = "AMAZING",
                        FlowConditionId = 2
                    },
                    new FlowConditionValue()
                    {
                        FlowConditionValueId = 5,
                        FlowConditionValueString = "9000",
                        FlowConditionId = 3,
                        FlowConditionValueOperator = FlowConditionValueOperator.GreaterThan
                    },
                    new FlowConditionValue()
                    {
                        FlowConditionValueId = 6,
                        FlowConditionValueString = "10000",
                        FlowConditionId = 3,
                        FlowConditionValueOperator = FlowConditionValueOperator.LessThan
                    },
                    new FlowConditionValue()
                    {
                        FlowConditionValueId = 7,
                        FlowConditionValueString = "2025-01-01",
                        FlowConditionId = 4,
                        FlowConditionValueOperator = FlowConditionValueOperator.GreaterThanOrEqualTo
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
                        FlowNodeNextId = 3,
                        FlowConditionId = 1
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
                        FlowNodeNextId = 7,
                        FlowConditionId = 2
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
                        FlowNodeNextId = 9,
                        FlowConditionId = 3
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
                        FlowNodeNextId = 11,
                        FlowConditionId = 4
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
                    new Contact() {
                        ContactId = 1,
                        FirstName = "John",
                        LastName = "Doe",
                        DateOfBirth = DateTime.Now
                    },
                    new Contact() {
                        ContactId = 2,
                        FirstName = "Eddie",
                        LastName = "Murphy",
                        DateOfBirth = DateTime.Now
                    },
                    new Contact() {
                        ContactId = 3,
                        FirstName = "Jim",
                        LastName = "Carrey",
                        DateOfBirth = DateTime.Now
                    }
                });
        }
    }
}
