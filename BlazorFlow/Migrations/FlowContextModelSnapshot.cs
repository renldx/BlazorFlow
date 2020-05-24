﻿// <auto-generated />
using System;
using BlazorFlow.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlazorFlow.Migrations
{
    [DbContext(typeof(FlowContext))]
    partial class FlowContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("BlazorFlow.Data.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("BlazorFlow.Data.Flow", b =>
                {
                    b.Property<int>("FlowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("FlowVersion")
                        .HasColumnType("double precision");

                    b.HasKey("FlowId");

                    b.ToTable("Flows");

                    b.HasData(
                        new
                        {
                            FlowId = 1,
                            FlowVersion = 1.0
                        });
                });

            modelBuilder.Entity("BlazorFlow.Data.FlowAnswer", b =>
                {
                    b.Property<int>("FlowAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FlowAnswerCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FlowAnswerTextEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FlowAnswerTextFr")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FlowAnswerValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("FlowAnswerId");

                    b.ToTable("FlowAnswers");

                    b.HasData(
                        new
                        {
                            FlowAnswerId = 1,
                            FlowAnswerCode = "YES",
                            FlowAnswerTextEn = "Yes",
                            FlowAnswerTextFr = "Oui",
                            FlowAnswerValue = "YES"
                        },
                        new
                        {
                            FlowAnswerId = 2,
                            FlowAnswerCode = "NO",
                            FlowAnswerTextEn = "No",
                            FlowAnswerTextFr = "Non",
                            FlowAnswerValue = "NO"
                        },
                        new
                        {
                            FlowAnswerId = 3,
                            FlowAnswerCode = "GOOD",
                            FlowAnswerTextEn = "Good",
                            FlowAnswerTextFr = "Bon",
                            FlowAnswerValue = "GOOD"
                        },
                        new
                        {
                            FlowAnswerId = 4,
                            FlowAnswerCode = "GREAT",
                            FlowAnswerTextEn = "Great",
                            FlowAnswerTextFr = "Génial",
                            FlowAnswerValue = "GREAT"
                        },
                        new
                        {
                            FlowAnswerId = 5,
                            FlowAnswerCode = "AMAZING",
                            FlowAnswerTextEn = "Amazing",
                            FlowAnswerTextFr = "Incroyable",
                            FlowAnswerValue = "AMAZING"
                        },
                        new
                        {
                            FlowAnswerId = 6,
                            FlowAnswerCode = "BAD",
                            FlowAnswerTextEn = "Bad",
                            FlowAnswerTextFr = "Mauv",
                            FlowAnswerValue = "BAD"
                        });
                });

            modelBuilder.Entity("BlazorFlow.Data.FlowCondition", b =>
                {
                    b.Property<int>("FlowConditionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.HasKey("FlowConditionId");

                    b.ToTable("FlowConditions");

                    b.HasData(
                        new
                        {
                            FlowConditionId = 1
                        },
                        new
                        {
                            FlowConditionId = 2
                        },
                        new
                        {
                            FlowConditionId = 3
                        },
                        new
                        {
                            FlowConditionId = 4
                        });
                });

            modelBuilder.Entity("BlazorFlow.Data.FlowConditionValue", b =>
                {
                    b.Property<int>("FlowConditionValueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("FlowConditionId")
                        .HasColumnType("integer");

                    b.Property<string>("FlowConditionValueOperator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FlowConditionValueString")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("FlowConditionValueId");

                    b.HasIndex("FlowConditionId");

                    b.ToTable("FlowConditionValues");

                    b.HasData(
                        new
                        {
                            FlowConditionValueId = 1,
                            FlowConditionId = 1,
                            FlowConditionValueOperator = "None",
                            FlowConditionValueString = "YES"
                        },
                        new
                        {
                            FlowConditionValueId = 2,
                            FlowConditionId = 2,
                            FlowConditionValueOperator = "None",
                            FlowConditionValueString = "GOOD"
                        },
                        new
                        {
                            FlowConditionValueId = 3,
                            FlowConditionId = 2,
                            FlowConditionValueOperator = "None",
                            FlowConditionValueString = "GREAT"
                        },
                        new
                        {
                            FlowConditionValueId = 4,
                            FlowConditionId = 2,
                            FlowConditionValueOperator = "None",
                            FlowConditionValueString = "AMAZING"
                        },
                        new
                        {
                            FlowConditionValueId = 5,
                            FlowConditionId = 3,
                            FlowConditionValueOperator = "GreaterThan",
                            FlowConditionValueString = "9000"
                        },
                        new
                        {
                            FlowConditionValueId = 6,
                            FlowConditionId = 3,
                            FlowConditionValueOperator = "LessThan",
                            FlowConditionValueString = "10000"
                        },
                        new
                        {
                            FlowConditionValueId = 7,
                            FlowConditionId = 4,
                            FlowConditionValueOperator = "GreaterThanOrEqualTo",
                            FlowConditionValueString = "2025-01-01"
                        });
                });

            modelBuilder.Entity("BlazorFlow.Data.FlowLink", b =>
                {
                    b.Property<int>("FlowLinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("FlowConditionId")
                        .HasColumnType("integer");

                    b.Property<int>("FlowId")
                        .HasColumnType("integer");

                    b.Property<double>("FlowLinkVersion")
                        .HasColumnType("double precision");

                    b.Property<int>("FlowNodeNextId")
                        .HasColumnType("integer");

                    b.Property<int>("FlowNodePreviousId")
                        .HasColumnType("integer");

                    b.HasKey("FlowLinkId");

                    b.HasIndex("FlowConditionId");

                    b.HasIndex("FlowId");

                    b.HasIndex("FlowNodeNextId");

                    b.HasIndex("FlowNodePreviousId");

                    b.ToTable("FlowLinks");

                    b.HasData(
                        new
                        {
                            FlowLinkId = 1,
                            FlowId = 1,
                            FlowLinkVersion = 1.0,
                            FlowNodeNextId = 2,
                            FlowNodePreviousId = 1
                        },
                        new
                        {
                            FlowLinkId = 2,
                            FlowConditionId = 1,
                            FlowId = 1,
                            FlowLinkVersion = 1.0,
                            FlowNodeNextId = 3,
                            FlowNodePreviousId = 2
                        },
                        new
                        {
                            FlowLinkId = 3,
                            FlowId = 1,
                            FlowLinkVersion = 1.0,
                            FlowNodeNextId = 4,
                            FlowNodePreviousId = 2
                        },
                        new
                        {
                            FlowLinkId = 4,
                            FlowId = 1,
                            FlowLinkVersion = 1.0,
                            FlowNodeNextId = 5,
                            FlowNodePreviousId = 3
                        },
                        new
                        {
                            FlowLinkId = 5,
                            FlowConditionId = 2,
                            FlowId = 1,
                            FlowLinkVersion = 1.0,
                            FlowNodeNextId = 7,
                            FlowNodePreviousId = 5
                        },
                        new
                        {
                            FlowLinkId = 6,
                            FlowId = 1,
                            FlowLinkVersion = 1.0,
                            FlowNodeNextId = 6,
                            FlowNodePreviousId = 5
                        },
                        new
                        {
                            FlowLinkId = 7,
                            FlowConditionId = 3,
                            FlowId = 1,
                            FlowLinkVersion = 1.0,
                            FlowNodeNextId = 9,
                            FlowNodePreviousId = 7
                        },
                        new
                        {
                            FlowLinkId = 8,
                            FlowId = 1,
                            FlowLinkVersion = 1.0,
                            FlowNodeNextId = 8,
                            FlowNodePreviousId = 7
                        },
                        new
                        {
                            FlowLinkId = 9,
                            FlowConditionId = 4,
                            FlowId = 1,
                            FlowLinkVersion = 1.0,
                            FlowNodeNextId = 11,
                            FlowNodePreviousId = 9
                        },
                        new
                        {
                            FlowLinkId = 10,
                            FlowId = 1,
                            FlowLinkVersion = 1.0,
                            FlowNodeNextId = 10,
                            FlowNodePreviousId = 9
                        },
                        new
                        {
                            FlowLinkId = 11,
                            FlowId = 1,
                            FlowLinkVersion = 1.0,
                            FlowNodeNextId = 12,
                            FlowNodePreviousId = 11
                        },
                        new
                        {
                            FlowLinkId = 12,
                            FlowId = 1,
                            FlowLinkVersion = 1.0,
                            FlowNodeNextId = 13,
                            FlowNodePreviousId = 12
                        });
                });

            modelBuilder.Entity("BlazorFlow.Data.FlowNode", b =>
                {
                    b.Property<int>("FlowNodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("FlowId")
                        .HasColumnType("integer");

                    b.Property<string>("FlowNodeEntity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FlowNodeType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("FlowNodeVersion")
                        .HasColumnType("double precision");

                    b.Property<int>("FlowQuestionId")
                        .HasColumnType("integer");

                    b.HasKey("FlowNodeId");

                    b.HasIndex("FlowId");

                    b.HasIndex("FlowQuestionId");

                    b.ToTable("FlowNodes");

                    b.HasData(
                        new
                        {
                            FlowNodeId = 1,
                            FlowId = 1,
                            FlowNodeEntity = "none",
                            FlowNodeType = "none",
                            FlowNodeVersion = 1.0,
                            FlowQuestionId = 1
                        },
                        new
                        {
                            FlowNodeId = 2,
                            FlowId = 1,
                            FlowNodeEntity = "none",
                            FlowNodeType = "radio",
                            FlowNodeVersion = 1.0,
                            FlowQuestionId = 2
                        },
                        new
                        {
                            FlowNodeId = 3,
                            FlowId = 1,
                            FlowNodeEntity = "contact",
                            FlowNodeType = "select",
                            FlowNodeVersion = 1.0,
                            FlowQuestionId = 3
                        },
                        new
                        {
                            FlowNodeId = 4,
                            FlowId = 1,
                            FlowNodeEntity = "none",
                            FlowNodeType = "none",
                            FlowNodeVersion = 1.0,
                            FlowQuestionId = 4
                        },
                        new
                        {
                            FlowNodeId = 5,
                            FlowId = 1,
                            FlowNodeEntity = "none",
                            FlowNodeType = "number",
                            FlowNodeVersion = 1.0,
                            FlowQuestionId = 5
                        },
                        new
                        {
                            FlowNodeId = 6,
                            FlowId = 1,
                            FlowNodeEntity = "none",
                            FlowNodeType = "none",
                            FlowNodeVersion = 1.0,
                            FlowQuestionId = 6
                        },
                        new
                        {
                            FlowNodeId = 7,
                            FlowId = 1,
                            FlowNodeEntity = "none",
                            FlowNodeType = "checkbox",
                            FlowNodeVersion = 1.0,
                            FlowQuestionId = 7
                        },
                        new
                        {
                            FlowNodeId = 8,
                            FlowId = 1,
                            FlowNodeEntity = "none",
                            FlowNodeType = "none",
                            FlowNodeVersion = 1.0,
                            FlowQuestionId = 8
                        },
                        new
                        {
                            FlowNodeId = 9,
                            FlowId = 1,
                            FlowNodeEntity = "none",
                            FlowNodeType = "datetime",
                            FlowNodeVersion = 1.0,
                            FlowQuestionId = 9
                        },
                        new
                        {
                            FlowNodeId = 10,
                            FlowId = 1,
                            FlowNodeEntity = "none",
                            FlowNodeType = "none",
                            FlowNodeVersion = 1.0,
                            FlowQuestionId = 10
                        },
                        new
                        {
                            FlowNodeId = 11,
                            FlowId = 1,
                            FlowNodeEntity = "none",
                            FlowNodeType = "text",
                            FlowNodeVersion = 1.0,
                            FlowQuestionId = 11
                        },
                        new
                        {
                            FlowNodeId = 12,
                            FlowId = 1,
                            FlowNodeEntity = "none",
                            FlowNodeType = "textarea",
                            FlowNodeVersion = 1.0,
                            FlowQuestionId = 12
                        },
                        new
                        {
                            FlowNodeId = 13,
                            FlowId = 1,
                            FlowNodeEntity = "none",
                            FlowNodeType = "none",
                            FlowNodeVersion = 1.0,
                            FlowQuestionId = 13
                        });
                });

            modelBuilder.Entity("BlazorFlow.Data.FlowNodeAnswer", b =>
                {
                    b.Property<int>("FlowNodeAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("FlowAnswerId")
                        .HasColumnType("integer");

                    b.Property<int>("FlowNodeId")
                        .HasColumnType("integer");

                    b.HasKey("FlowNodeAnswerId");

                    b.HasIndex("FlowAnswerId");

                    b.HasIndex("FlowNodeId");

                    b.ToTable("FlowNodeAnswers");

                    b.HasData(
                        new
                        {
                            FlowNodeAnswerId = 1,
                            FlowAnswerId = 1,
                            FlowNodeId = 2
                        },
                        new
                        {
                            FlowNodeAnswerId = 2,
                            FlowAnswerId = 2,
                            FlowNodeId = 2
                        },
                        new
                        {
                            FlowNodeAnswerId = 3,
                            FlowAnswerId = 3,
                            FlowNodeId = 7
                        },
                        new
                        {
                            FlowNodeAnswerId = 4,
                            FlowAnswerId = 4,
                            FlowNodeId = 7
                        },
                        new
                        {
                            FlowNodeAnswerId = 5,
                            FlowAnswerId = 5,
                            FlowNodeId = 7
                        },
                        new
                        {
                            FlowNodeAnswerId = 6,
                            FlowAnswerId = 6,
                            FlowNodeId = 7
                        });
                });

            modelBuilder.Entity("BlazorFlow.Data.FlowQuestion", b =>
                {
                    b.Property<int>("FlowQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FlowQuestionCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FlowQuestionTextEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FlowQuestionTextFr")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("FlowQuestionId");

                    b.ToTable("FlowQuestions");

                    b.HasData(
                        new
                        {
                            FlowQuestionId = 1,
                            FlowQuestionCode = "START",
                            FlowQuestionTextEn = "Welcome! You're starting a new application.",
                            FlowQuestionTextFr = ""
                        },
                        new
                        {
                            FlowQuestionId = 2,
                            FlowQuestionCode = "SINGLERADIO",
                            FlowQuestionTextEn = "This is a single-choice question, in the form of radio buttons, representing primitive values.",
                            FlowQuestionTextFr = ""
                        },
                        new
                        {
                            FlowQuestionId = 3,
                            FlowQuestionCode = "SINGLESELECT",
                            FlowQuestionTextEn = "This is a single-choice question, in the form of a drop-down list, representing a lookup to an associated entity.",
                            FlowQuestionTextFr = ""
                        },
                        new
                        {
                            FlowQuestionId = 4,
                            FlowQuestionCode = "BADSINGLE",
                            FlowQuestionTextEn = "Invalid selection, try again.",
                            FlowQuestionTextFr = ""
                        },
                        new
                        {
                            FlowQuestionId = 5,
                            FlowQuestionCode = "NUMBER",
                            FlowQuestionTextEn = "This is a number range check, which needs to be in between 9000 and 10000.",
                            FlowQuestionTextFr = ""
                        },
                        new
                        {
                            FlowQuestionId = 6,
                            FlowQuestionCode = "BADNUMBER",
                            FlowQuestionTextEn = "Invalid number, try again.",
                            FlowQuestionTextFr = ""
                        },
                        new
                        {
                            FlowQuestionId = 7,
                            FlowQuestionCode = "MULTI",
                            FlowQuestionTextEn = "This is a multi-choice question, in the form of checkboxes.",
                            FlowQuestionTextFr = ""
                        },
                        new
                        {
                            FlowQuestionId = 8,
                            FlowQuestionCode = "BADMULTI",
                            FlowQuestionTextEn = "Invalid selections, try again.",
                            FlowQuestionTextFr = ""
                        },
                        new
                        {
                            FlowQuestionId = 9,
                            FlowQuestionCode = "DATE",
                            FlowQuestionTextEn = "This is a date check, which needs to be in the future from now.",
                            FlowQuestionTextFr = ""
                        },
                        new
                        {
                            FlowQuestionId = 10,
                            FlowQuestionCode = "BADDATE",
                            FlowQuestionTextEn = "Invalid date, try again.",
                            FlowQuestionTextFr = ""
                        },
                        new
                        {
                            FlowQuestionId = 11,
                            FlowQuestionCode = "TEXT",
                            FlowQuestionTextEn = "This is a text input box.",
                            FlowQuestionTextFr = ""
                        },
                        new
                        {
                            FlowQuestionId = 12,
                            FlowQuestionCode = "TEXTAREA",
                            FlowQuestionTextEn = "This is a paragraph input box.",
                            FlowQuestionTextFr = ""
                        },
                        new
                        {
                            FlowQuestionId = 13,
                            FlowQuestionCode = "END",
                            FlowQuestionTextEn = "You've completed the application. Thanks!",
                            FlowQuestionTextFr = ""
                        });
                });

            modelBuilder.Entity("BlazorFlow.Data.UserFlow", b =>
                {
                    b.Property<int>("UserFlowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("FlowId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("UserFlowId");

                    b.HasIndex("FlowId");

                    b.ToTable("UserFlows");
                });

            modelBuilder.Entity("BlazorFlow.Data.UserFlowAnswer", b =>
                {
                    b.Property<int>("UserFlowAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("FlowNodeId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsStale")
                        .HasColumnType("boolean");

                    b.Property<int>("UserFlowId")
                        .HasColumnType("integer");

                    b.HasKey("UserFlowAnswerId");

                    b.HasIndex("FlowNodeId");

                    b.HasIndex("UserFlowId");

                    b.ToTable("UserFlowAnswers");
                });

            modelBuilder.Entity("BlazorFlow.Data.UserFlowAnswerValue", b =>
                {
                    b.Property<int>("UserFlowAnswerValueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("UserFlowAnswerId")
                        .HasColumnType("integer");

                    b.Property<string>("UserFlowAnswerValueString")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserFlowAnswerValueId");

                    b.HasIndex("UserFlowAnswerId");

                    b.ToTable("UserFlowAnswerValues");
                });

            modelBuilder.Entity("BlazorFlow.Data.FlowConditionValue", b =>
                {
                    b.HasOne("BlazorFlow.Data.FlowCondition", "FlowCondition")
                        .WithMany("FlowConditionValues")
                        .HasForeignKey("FlowConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorFlow.Data.FlowLink", b =>
                {
                    b.HasOne("BlazorFlow.Data.FlowCondition", "FlowCondition")
                        .WithMany()
                        .HasForeignKey("FlowConditionId");

                    b.HasOne("BlazorFlow.Data.Flow", "Flow")
                        .WithMany("FlowLinks")
                        .HasForeignKey("FlowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorFlow.Data.FlowNode", "FlowNodeNext")
                        .WithMany()
                        .HasForeignKey("FlowNodeNextId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorFlow.Data.FlowNode", "FlowNodePrevious")
                        .WithMany()
                        .HasForeignKey("FlowNodePreviousId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorFlow.Data.FlowNode", b =>
                {
                    b.HasOne("BlazorFlow.Data.Flow", "Flow")
                        .WithMany("FlowNodes")
                        .HasForeignKey("FlowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorFlow.Data.FlowQuestion", "FlowQuestion")
                        .WithMany("FlowNodes")
                        .HasForeignKey("FlowQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorFlow.Data.FlowNodeAnswer", b =>
                {
                    b.HasOne("BlazorFlow.Data.FlowAnswer", "FlowAnswer")
                        .WithMany()
                        .HasForeignKey("FlowAnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorFlow.Data.FlowNode", "FlowNode")
                        .WithMany()
                        .HasForeignKey("FlowNodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorFlow.Data.UserFlow", b =>
                {
                    b.HasOne("BlazorFlow.Data.Flow", "Flow")
                        .WithMany()
                        .HasForeignKey("FlowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorFlow.Data.UserFlowAnswer", b =>
                {
                    b.HasOne("BlazorFlow.Data.FlowNode", "FlowNode")
                        .WithMany()
                        .HasForeignKey("FlowNodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorFlow.Data.UserFlow", "UserFlow")
                        .WithMany("UserFlowAnswers")
                        .HasForeignKey("UserFlowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorFlow.Data.UserFlowAnswerValue", b =>
                {
                    b.HasOne("BlazorFlow.Data.UserFlowAnswer", "UserFlowAnswer")
                        .WithMany("UserFlowAnswerValues")
                        .HasForeignKey("UserFlowAnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
