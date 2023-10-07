﻿// <auto-generated />
using System;
using CnGalWebSite.ProjectSite.API.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CnGalWebSite.ProjectSite.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasColumnType("longtext");

                    b.Property<string>("BackgroundImage")
                        .HasColumnType("longtext");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hide")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("longtext");

                    b.Property<string>("OrganizationDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("OrganizationName")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PersonDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("PersonName")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("PreviousWorks")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("RegistTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Tags")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.Carousel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Hide")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<string>("Link")
                        .HasColumnType("longtext");

                    b.Property<string>("Note")
                        .HasColumnType("longtext");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Carousels");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.FriendLink", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Hide")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<string>("Link")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("FriendLinks");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Contact")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Description")
                        .HasMaxLength(10000000)
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Hide")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CreateUserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.ProjectImage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<string>("Note")
                        .HasColumnType("longtext");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<long?>("ProjectId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectImage");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.ProjectPosition", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("BudgetMax")
                        .HasColumnType("int");

                    b.Property<int>("BudgetMin")
                        .HasColumnType("int");

                    b.Property<string>("BudgetNote")
                        .HasColumnType("longtext");

                    b.Property<int>("BudgetType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<bool>("Hide")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Percentage")
                        .HasColumnType("int");

                    b.Property<int>("PositionType")
                        .HasColumnType("int");

                    b.Property<string>("PositionTypeName")
                        .HasColumnType("longtext");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<long>("ProjectId")
                        .HasColumnType("bigint");

                    b.Property<string>("Tags")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UrgencyType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectPositions");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.Stall", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Contact")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Hide")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("PositionType")
                        .HasColumnType("int");

                    b.Property<string>("PositionTypeName")
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CreateUserId");

                    b.ToTable("Stalls");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.StallAudio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("BriefIntroduction")
                        .HasColumnType("longtext");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<long?>("StallId")
                        .HasColumnType("bigint");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("longtext");

                    b.Property<string>("Url")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("StallId");

                    b.ToTable("StallAudio");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.StallImage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<string>("Note")
                        .HasColumnType("longtext");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<long?>("StallId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("StallId");

                    b.ToTable("StallImage");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.StallText", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<string>("Link")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<long?>("StallId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("StallId");

                    b.ToTable("StallText");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.UserAudio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("BriefIntroduction")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time(6)");

                    b.Property<bool>("Hide")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Url")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CreateUserId");

                    b.ToTable("UserAudios");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.UserImage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Hide")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<string>("Note")
                        .HasColumnType("longtext");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CreateUserId");

                    b.ToTable("UserImages");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.UserText", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Hide")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Link")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CreateUserId");

                    b.ToTable("UserTexts");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.Project", b =>
                {
                    b.HasOne("CnGalWebSite.ProjectSite.Models.DataModels.ApplicationUser", "CreateUser")
                        .WithMany("Projects")
                        .HasForeignKey("CreateUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreateUser");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.ProjectImage", b =>
                {
                    b.HasOne("CnGalWebSite.ProjectSite.Models.DataModels.Project", null)
                        .WithMany("Images")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.ProjectPosition", b =>
                {
                    b.HasOne("CnGalWebSite.ProjectSite.Models.DataModels.Project", "Project")
                        .WithMany("Positions")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.Stall", b =>
                {
                    b.HasOne("CnGalWebSite.ProjectSite.Models.DataModels.ApplicationUser", "CreateUser")
                        .WithMany("Stalls")
                        .HasForeignKey("CreateUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreateUser");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.StallAudio", b =>
                {
                    b.HasOne("CnGalWebSite.ProjectSite.Models.DataModels.Stall", null)
                        .WithMany("Audios")
                        .HasForeignKey("StallId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.StallImage", b =>
                {
                    b.HasOne("CnGalWebSite.ProjectSite.Models.DataModels.Stall", null)
                        .WithMany("Images")
                        .HasForeignKey("StallId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.StallText", b =>
                {
                    b.HasOne("CnGalWebSite.ProjectSite.Models.DataModels.Stall", null)
                        .WithMany("Texts")
                        .HasForeignKey("StallId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.UserAudio", b =>
                {
                    b.HasOne("CnGalWebSite.ProjectSite.Models.DataModels.ApplicationUser", "CreateUser")
                        .WithMany("Audios")
                        .HasForeignKey("CreateUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreateUser");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.UserImage", b =>
                {
                    b.HasOne("CnGalWebSite.ProjectSite.Models.DataModels.ApplicationUser", "CreateUser")
                        .WithMany("Images")
                        .HasForeignKey("CreateUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreateUser");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.UserText", b =>
                {
                    b.HasOne("CnGalWebSite.ProjectSite.Models.DataModels.ApplicationUser", "CreateUser")
                        .WithMany("Texts")
                        .HasForeignKey("CreateUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreateUser");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.ApplicationUser", b =>
                {
                    b.Navigation("Audios");

                    b.Navigation("Images");

                    b.Navigation("Projects");

                    b.Navigation("Stalls");

                    b.Navigation("Texts");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.Project", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Positions");
                });

            modelBuilder.Entity("CnGalWebSite.ProjectSite.Models.DataModels.Stall", b =>
                {
                    b.Navigation("Audios");

                    b.Navigation("Images");

                    b.Navigation("Texts");
                });
#pragma warning restore 612, 618
        }
    }
}
