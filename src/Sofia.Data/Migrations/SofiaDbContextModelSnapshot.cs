﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sofia.Data.Contexts;

namespace Sofia.Data.Migrations
{
    [DbContext(typeof(SofiaDbContext))]
    partial class SofiaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sofia.Data.Commit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ContributorId");

                    b.Property<DateTimeOffset>("DateTime");

                    b.Property<string>("Sha");

                    b.Property<long>("SubscriptionId");

                    b.HasKey("Id");

                    b.HasIndex("ContributorId");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("Commits");
                });

            modelBuilder.Entity("Sofia.Data.Models.Candidate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GitHubLogin");

                    b.Property<int>("PullRequestNumber");

                    b.Property<int>("Rank");

                    b.Property<string>("RecommenderType")
                        .IsRequired();

                    b.Property<long>("SubscriptionId");

                    b.Property<DateTimeOffset>("SuggestionDateTime");

                    b.HasKey("Id");

                    b.HasIndex("PullRequestNumber");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("Sofia.Data.Models.Contribution", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityId");

                    b.Property<string>("ContributionType")
                        .IsRequired();

                    b.Property<string>("ContributorEmail");

                    b.Property<string>("ContributorGithubLogin");

                    b.Property<long>("ContributorId");

                    b.Property<string>("ContributorName");

                    b.Property<DateTimeOffset?>("DateTime");

                    b.Property<long>("FileId");

                    b.Property<long>("SubscriptionId");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("ContributorId");

                    b.HasIndex("FileId");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("Contributions");
                });

            modelBuilder.Entity("Sofia.Data.Models.Contributor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CanonicalName");

                    b.Property<string>("GitHubLogin");

                    b.Property<long>("SubscriptionId");

                    b.HasKey("Id");

                    b.HasIndex("CanonicalName");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("Contributors");
                });

            modelBuilder.Entity("Sofia.Data.Models.File", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CanonicalName");

                    b.Property<long>("SubscriptionId");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Sofia.Data.Models.FileHistory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ContributionId");

                    b.Property<string>("FileHistoryType")
                        .IsRequired();

                    b.Property<long>("FileId");

                    b.Property<string>("OldPath");

                    b.Property<string>("Path");

                    b.Property<long>("SubscriptionId");

                    b.HasKey("Id");

                    b.HasIndex("ContributionId");

                    b.HasIndex("FileId");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("FileHistories");
                });

            modelBuilder.Entity("Sofia.Data.Models.PullRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Number");

                    b.Property<int>("NumberOfFiles");

                    b.Property<string>("PullRequestAnalyzeStatus")
                        .IsRequired();

                    b.Property<string>("PullRequestInfo");

                    b.Property<long>("SubscriptionId");

                    b.HasKey("Id");

                    b.HasIndex("Number");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("PullRequests");
                });

            modelBuilder.Entity("Sofia.Data.Models.Subscription", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Branch")
                        .IsRequired();

                    b.Property<string>("GitHubRepositoryUrl");

                    b.Property<long>("InstallationId");

                    b.Property<int>("IssueNumber");

                    b.Property<string>("LastPullRequestGithubCursor");

                    b.Property<string>("LocalRepositoryPath");

                    b.Property<string>("Owner");

                    b.Property<string>("Repo");

                    b.Property<long>("RepositoryId");

                    b.Property<string>("ScanningStatus")
                        .IsRequired();

                    b.Property<DateTime>("SubscriptionDateTime");

                    b.HasKey("Id");

                    b.HasAlternateKey("RepositoryId", "Branch");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Sofia.Data.Models.SubscriptionEvent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndDateTime");

                    b.Property<DateTime>("StartDateTime");

                    b.Property<long>("SubscriptionId");

                    b.Property<int>("SubscriptionStatus");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("SubscriptionEvents");
                });

            modelBuilder.Entity("Sofia.Data.Commit", b =>
                {
                    b.HasOne("Sofia.Data.Models.Contributor", "Contributor")
                        .WithMany()
                        .HasForeignKey("ContributorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sofia.Data.Models.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sofia.Data.Models.Candidate", b =>
                {
                    b.HasOne("Sofia.Data.Models.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sofia.Data.Models.Contribution", b =>
                {
                    b.HasOne("Sofia.Data.Models.Contributor", "Contributor")
                        .WithMany("Contributions")
                        .HasForeignKey("ContributorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sofia.Data.Models.File", "File")
                        .WithMany("Contributions")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sofia.Data.Models.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sofia.Data.Models.Contributor", b =>
                {
                    b.HasOne("Sofia.Data.Models.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sofia.Data.Models.File", b =>
                {
                    b.HasOne("Sofia.Data.Models.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sofia.Data.Models.FileHistory", b =>
                {
                    b.HasOne("Sofia.Data.Models.Contribution", "Contribution")
                        .WithMany()
                        .HasForeignKey("ContributionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sofia.Data.Models.File", "File")
                        .WithMany("FileHistories")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sofia.Data.Models.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sofia.Data.Models.PullRequest", b =>
                {
                    b.HasOne("Sofia.Data.Models.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sofia.Data.Models.SubscriptionEvent", b =>
                {
                    b.HasOne("Sofia.Data.Models.Subscription", "Subscription")
                        .WithMany("SubscriptionEvents")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
