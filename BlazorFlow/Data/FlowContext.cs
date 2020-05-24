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

            // Seed Data

            modelBuilder
                .Entity<Flow>()
                .HasData(new Flow()
                {
                    FlowId = 1,
                    FlowVersion = 1
                });

            modelBuilder
                .Entity<FlowNode>()
                .HasData(new FlowNode[] {
                    new FlowNode() {
                        FlowNodeId = 1,
                        FlowNodeVersion = 1,
                        FlowNodeType = FlowNodeType.none,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestion = new FlowQuestion("START", "Welcome! You're starting a new application.", "")
                        {
                            FlowQuestionId = 1
                        }
                    },
                    new FlowNode() {
                        FlowNodeId = 2,
                        FlowNodeVersion = 1,
                        FlowNodeType = FlowNodeType.radio,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestion = new FlowQuestion("SINGLERADIO", "This is a single-choice question, in the form of radio buttons, representing primitive values.", "")
                        {
                            FlowQuestionId = 2
                        }
                    },
                    new FlowNode() {
                        FlowNodeId = 3,
                        FlowNodeVersion = 1,
                        FlowNodeType = FlowNodeType.select,
                        FlowNodeEntity = FlowNodeEntity.contact,
                        FlowQuestion = new FlowQuestion("SINGLESELECT", "This is a single-choice question, in the form of a drop-down list, representing a lookup to an associated entity.", "")
                        {
                            FlowQuestionId = 3
                        }
                    },
                    new FlowNode() {
                        FlowNodeId = 4,
                        FlowNodeVersion = 1,
                        FlowNodeType = FlowNodeType.none,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestion = new FlowQuestion("BADSINGLE", "Invalid selection, try again.", "")
                        {
                            FlowQuestionId = 4
                        }
                    },
                    new FlowNode() {
                        FlowNodeId = 5,
                        FlowNodeVersion = 1,
                        FlowNodeType = FlowNodeType.number,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestion = new FlowQuestion("NUMBER", "This is a number range check, which needs to be in between 9000 and 10000.", "")
                        {
                            FlowQuestionId = 5
                        }
                    },
                    new FlowNode() {
                        FlowNodeId = 6,
                        FlowNodeVersion = 1,
                        FlowNodeType = FlowNodeType.none,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestion = new FlowQuestion("BADNUMBER", "Invalid number, try again.", "")
                        {
                            FlowQuestionId = 6
                        }
                    },
                    new FlowNode() {
                        FlowNodeId = 7,
                        FlowNodeVersion = 1,
                        FlowNodeType = FlowNodeType.checkbox,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestion = new FlowQuestion("MULTI", "This is a multi-choice question, in the form of checkboxes.", "")
                        {
                            FlowQuestionId = 7
                        }
                    },
                    new FlowNode() {
                        FlowNodeId = 8,
                        FlowNodeVersion = 1,
                        FlowNodeType = FlowNodeType.none,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestion = new FlowQuestion("BADMULTI", "Invalid selections, try again.", "")
                        {
                            FlowQuestionId = 8
                        }
                    },
                    new FlowNode() {
                        FlowNodeId = 9,
                        FlowNodeVersion = 1,
                        FlowNodeType = FlowNodeType.datetime,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestion = new FlowQuestion("DATE", "This is a date check, which needs to be in the future from now.", "")
                        {
                            FlowQuestionId = 9
                        }
                    },
                    new FlowNode() {
                        FlowNodeId = 10,
                        FlowNodeVersion = 1,
                        FlowNodeType = FlowNodeType.none,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestion = new FlowQuestion("BADDATE", "Invalid date, try again.", "")
                        {
                            FlowQuestionId = 10
                        }
                    },
                    new FlowNode() {
                        FlowNodeId = 11,
                        FlowNodeVersion = 1,
                        FlowNodeType = FlowNodeType.text,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestion = new FlowQuestion("TEXT", "This is a text input box.", "")
                        {
                            FlowQuestionId = 11
                        }
                    },
                    new FlowNode() {
                        FlowNodeId = 12,
                        FlowNodeVersion = 1,
                        FlowNodeType = FlowNodeType.textarea,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestion = new FlowQuestion("TEXTAREA", "This is a paragraph input box.", "")
                        {
                            FlowQuestionId = 12
                        }
                    },
                    new FlowNode() {
                        FlowNodeId = 13,
                        FlowNodeVersion = 1,
                        FlowNodeType = FlowNodeType.none,
                        FlowNodeEntity = FlowNodeEntity.none,
                        FlowQuestion = new FlowQuestion("END", "You've completed the application. Thanks!", "")
                        {
                            FlowQuestionId = 13
                        }
                    }
                });

            modelBuilder
                .Entity<FlowAnswer>()
                .HasData(new FlowAnswer[]
                {
                    new FlowAnswer("YES", "YES", "Yes", "") { FlowAnswerId = 1 },
                    new FlowAnswer("NO", "NO", "No", "") { FlowAnswerId = 2 },
                    new FlowAnswer("GOOD", "GOOD", "Good", "") { FlowAnswerId = 3 },
                    new FlowAnswer("GREAT", "GREAT", "Great", "") { FlowAnswerId = 4 },
                    new FlowAnswer("AMAZING", "AMAZING", "Amazing", "") { FlowAnswerId = 5 },
                    new FlowAnswer("BAD", "BAD", "Bad", "") { FlowAnswerId = 6 },
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
                    new FlowCondition() {
                        FlowConditionId = 1,
                        FlowConditionValues = new List<FlowConditionValue>()
                        {
                            new FlowConditionValue("YES") {
                                FlowConditionValueId = 1
                            }
                        }
                    },
                    new FlowCondition() {
                        FlowConditionId = 2,
                        FlowConditionValues = new List<FlowConditionValue>()
                        {
                            new FlowConditionValue("GOOD") {
                                FlowConditionValueId = 2
                            },
                            new FlowConditionValue("GREAT") {
                                FlowConditionValueId = 3
                            },
                            new FlowConditionValue("AMAZING") {
                                FlowConditionValueId = 4
                            }
                        }
                    },
                    new FlowCondition() {
                        FlowConditionId = 3,
                        FlowConditionValues = new List<FlowConditionValue>()
                        {
                            new FlowConditionValue("9000") {
                                FlowConditionValueId = 5,
                                FlowConditionValueOperator = FlowConditionValueOperator.GreaterThan
                            },
                            new FlowConditionValue("10000") {
                                FlowConditionValueId = 6,
                                FlowConditionValueOperator = FlowConditionValueOperator.LessThan
                            }
                        }
                    },
                    new FlowCondition() {
                        FlowConditionId = 4,
                        FlowConditionValues = new List<FlowConditionValue>()
                        {
                            new FlowConditionValue("2025-01-01") {
                                FlowConditionValueId = 7,
                                FlowConditionValueOperator = FlowConditionValueOperator.GreaterThanOrEqualTo
                            }
                        }
                    }
                });
        }
    }
}
