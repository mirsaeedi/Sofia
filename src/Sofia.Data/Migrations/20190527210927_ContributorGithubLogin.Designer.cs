﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sophia.Data.Contexts;

namespace Sophia.Data.Migrations
{
    [DbContext(typeof(SophiaDbContext))]
    [Migration("20190527210927_ContributorGithubLogin")]
    partial class ContributorGithubLogin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sophia.Data.Models.Contribution", b =>
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

                    b.HasIndex("ContributorId");

                    b.HasIndex("FileId");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("Contributions");
                });

            modelBuilder.Entity("Sophia.Data.Models.Contributor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CanonicalName");

                    b.Property<string>("GitHubLogin");

                    b.Property<long>("SubscriptionId");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("Contributors");
                });

            modelBuilder.Entity("Sophia.Data.Models.File", b =>
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

            modelBuilder.Entity("Sophia.Data.Models.FileHistory", b =>
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

            modelBuilder.Entity("Sophia.Data.Models.PullRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Number");

                    b.Property<string>("PullRequestAnalyzeStatus")
                        .IsRequired();

                    b.Property<string>("PullRequestInfo");

                    b.Property<string>("PullRequestStatus")
                        .IsRequired();

                    b.Property<long?>("SubscriptionId");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("PullRequests");
                });

            modelBuilder.Entity("Sophia.Data.Models.Subscription", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Branch");

                    b.Property<string>("GitHubRepositoryUrl");

                    b.Property<long>("InstallationId");

                    b.Property<int>("IssueNumber");

                    b.Property<DateTimeOffset?>("LastRefreshDateTime");

                    b.Property<string>("LocalRepositoryPath");

                    b.Property<string>("Owner");

                    b.Property<string>("Repo");

                    b.Property<long>("RepositoryId");

                    b.Property<DateTime>("SubscriptionDateTime");

                    b.Property<string>("SubscriptionStatus")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Sophia.Data.Models.SubscriptionEvent", b =>
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

            modelBuilder.Entity("Sophia.Data.Models.Contribution", b =>
                {
                    b.HasOne("Sophia.Data.Models.Contributor", "Contributor")
                        .WithMany("Contributions")
                        .HasForeignKey("ContributorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sophia.Data.Models.File", "File")
                        .WithMany("Contributions")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sophia.Data.Models.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sophia.Data.Models.Contributor", b =>
                {
                    b.HasOne("Sophia.Data.Models.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sophia.Data.Models.File", b =>
                {
                    b.HasOne("Sophia.Data.Models.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sophia.Data.Models.FileHistory", b =>
                {
                    b.HasOne("Sophia.Data.Models.Contribution", "Contribution")
                        .WithMany()
                        .HasForeignKey("ContributionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sophia.Data.Models.File", "File")
                        .WithMany("FileHistories")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sophia.Data.Models.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sophia.Data.Models.PullRequest", b =>
                {
                    b.HasOne("Sophia.Data.Models.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId");
                });

            modelBuilder.Entity("Sophia.Data.Models.SubscriptionEvent", b =>
                {
                    b.HasOne("Sophia.Data.Models.Subscription", "Subscription")
                        .WithMany("SubscriptionEvents")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
