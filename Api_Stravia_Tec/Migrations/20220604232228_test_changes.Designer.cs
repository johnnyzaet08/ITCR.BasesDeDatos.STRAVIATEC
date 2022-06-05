﻿// <auto-generated />
using System;
using Api_Stravia_Tec.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api_Stravia_Tec.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220604232228_test_changes")]
    partial class test_changes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ActivityAthlete", b =>
                {
                    b.Property<int>("Activitiesid")
                        .HasColumnType("int");

                    b.Property<int>("Athletesid")
                        .HasColumnType("int");

                    b.HasKey("Activitiesid", "Athletesid");

                    b.HasIndex("Athletesid");

                    b.ToTable("ActivityAthlete");
                });

            modelBuilder.Entity("ActivityGroup", b =>
                {
                    b.Property<int>("Activitiesid")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("Activitiesid", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("ActivityGroup");
                });

            modelBuilder.Entity("ActivityOrganizer", b =>
                {
                    b.Property<int>("Activitiesid")
                        .HasColumnType("int");

                    b.Property<int>("OrganizersId")
                        .HasColumnType("int");

                    b.HasKey("Activitiesid", "OrganizersId");

                    b.HasIndex("OrganizersId");

                    b.ToTable("ActivityOrganizer");
                });

            modelBuilder.Entity("Api_Stravia_Tec.Activity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("ActivityTypeid")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isChallengeRace")
                        .HasColumnType("bit");

                    b.Property<string>("mileage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("route")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("ActivityTypeid");

                    b.HasIndex("CategoryId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Api_Stravia_Tec.ActivityType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ActivityTypes");
                });

            modelBuilder.Entity("Api_Stravia_Tec.Athlete", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("birth_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("current_age")
                        .HasColumnType("int");

                    b.Property<string>("fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Athletes");
                });

            modelBuilder.Entity("Api_Stravia_Tec.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Api_Stravia_Tec.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Activityid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("activityTypeid")
                        .HasColumnType("int");

                    b.Property<bool>("isPrivate")
                        .HasColumnType("bit");

                    b.Property<string>("period")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Activityid");

                    b.HasIndex("activityTypeid");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("Api_Stravia_Tec.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Administrator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Api_Stravia_Tec.Organizer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("RouteId")
                        .HasColumnType("int");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("birth_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lName1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lName2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RouteId");

                    b.ToTable("Organizers");
                });

            modelBuilder.Entity("Api_Stravia_Tec.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("activityTypeid")
                        .HasColumnType("int");

                    b.Property<string>("bank_accounts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("categoryId")
                        .HasColumnType("int");

                    b.Property<int>("cost")
                        .HasColumnType("int");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isPrivate")
                        .HasColumnType("bit");

                    b.Property<string>("route")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("activityTypeid");

                    b.HasIndex("categoryId");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("Api_Stravia_Tec.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("destiny")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("CategoryOrganizer", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("OrganizersId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "OrganizersId");

                    b.HasIndex("OrganizersId");

                    b.ToTable("CategoryOrganizer");
                });

            modelBuilder.Entity("ChallengeOrganizer", b =>
                {
                    b.Property<int>("ChallengesId")
                        .HasColumnType("int");

                    b.Property<int>("OrganizersId")
                        .HasColumnType("int");

                    b.HasKey("ChallengesId", "OrganizersId");

                    b.HasIndex("OrganizersId");

                    b.ToTable("ChallengeOrganizer");
                });

            modelBuilder.Entity("GroupOrganizer", b =>
                {
                    b.Property<int>("GroupsId")
                        .HasColumnType("int");

                    b.Property<int>("OrganizersId")
                        .HasColumnType("int");

                    b.HasKey("GroupsId", "OrganizersId");

                    b.HasIndex("OrganizersId");

                    b.ToTable("GroupOrganizer");
                });

            modelBuilder.Entity("OrganizerRace", b =>
                {
                    b.Property<int>("OrganizersId")
                        .HasColumnType("int");

                    b.Property<int>("RacesId")
                        .HasColumnType("int");

                    b.HasKey("OrganizersId", "RacesId");

                    b.HasIndex("RacesId");

                    b.ToTable("OrganizerRace");
                });

            modelBuilder.Entity("ActivityAthlete", b =>
                {
                    b.HasOne("Api_Stravia_Tec.Activity", null)
                        .WithMany()
                        .HasForeignKey("Activitiesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Stravia_Tec.Athlete", null)
                        .WithMany()
                        .HasForeignKey("Athletesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ActivityGroup", b =>
                {
                    b.HasOne("Api_Stravia_Tec.Activity", null)
                        .WithMany()
                        .HasForeignKey("Activitiesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Stravia_Tec.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ActivityOrganizer", b =>
                {
                    b.HasOne("Api_Stravia_Tec.Activity", null)
                        .WithMany()
                        .HasForeignKey("Activitiesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Stravia_Tec.Organizer", null)
                        .WithMany()
                        .HasForeignKey("OrganizersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api_Stravia_Tec.Activity", b =>
                {
                    b.HasOne("Api_Stravia_Tec.ActivityType", null)
                        .WithMany("Activities")
                        .HasForeignKey("ActivityTypeid");

                    b.HasOne("Api_Stravia_Tec.Category", "Category")
                        .WithMany("Activity")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Api_Stravia_Tec.Challenge", b =>
                {
                    b.HasOne("Api_Stravia_Tec.Activity", null)
                        .WithMany("Challenges")
                        .HasForeignKey("Activityid");

                    b.HasOne("Api_Stravia_Tec.ActivityType", "activityType")
                        .WithMany("Challenges")
                        .HasForeignKey("activityTypeid");

                    b.Navigation("activityType");
                });

            modelBuilder.Entity("Api_Stravia_Tec.Organizer", b =>
                {
                    b.HasOne("Api_Stravia_Tec.Route", null)
                        .WithMany("Organizers")
                        .HasForeignKey("RouteId");
                });

            modelBuilder.Entity("Api_Stravia_Tec.Race", b =>
                {
                    b.HasOne("Api_Stravia_Tec.ActivityType", "activityType")
                        .WithMany("Race")
                        .HasForeignKey("activityTypeid");

                    b.HasOne("Api_Stravia_Tec.Category", "category")
                        .WithMany("Races")
                        .HasForeignKey("categoryId");

                    b.Navigation("activityType");

                    b.Navigation("category");
                });

            modelBuilder.Entity("Api_Stravia_Tec.Route", b =>
                {
                    b.HasOne("Api_Stravia_Tec.Activity", "Activity")
                        .WithMany("Routes")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("CategoryOrganizer", b =>
                {
                    b.HasOne("Api_Stravia_Tec.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Stravia_Tec.Organizer", null)
                        .WithMany()
                        .HasForeignKey("OrganizersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChallengeOrganizer", b =>
                {
                    b.HasOne("Api_Stravia_Tec.Challenge", null)
                        .WithMany()
                        .HasForeignKey("ChallengesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Stravia_Tec.Organizer", null)
                        .WithMany()
                        .HasForeignKey("OrganizersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GroupOrganizer", b =>
                {
                    b.HasOne("Api_Stravia_Tec.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Stravia_Tec.Organizer", null)
                        .WithMany()
                        .HasForeignKey("OrganizersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrganizerRace", b =>
                {
                    b.HasOne("Api_Stravia_Tec.Organizer", null)
                        .WithMany()
                        .HasForeignKey("OrganizersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Stravia_Tec.Race", null)
                        .WithMany()
                        .HasForeignKey("RacesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api_Stravia_Tec.Activity", b =>
                {
                    b.Navigation("Challenges");

                    b.Navigation("Routes");
                });

            modelBuilder.Entity("Api_Stravia_Tec.ActivityType", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Challenges");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("Api_Stravia_Tec.Category", b =>
                {
                    b.Navigation("Activity");

                    b.Navigation("Races");
                });

            modelBuilder.Entity("Api_Stravia_Tec.Route", b =>
                {
                    b.Navigation("Organizers");
                });
#pragma warning restore 612, 618
        }
    }
}
