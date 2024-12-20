﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmithSwimmingSchool_NickMorales.Data;

#nullable disable

namespace SmithSwimmingSchool_NickMorales.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241212190258_TestUsers")]
    partial class TestUsers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c3402e44-96b4-4dbb-ac18-63842e5d89b6",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "4bbff256-c063-4b0e-90f0-f8a02b10da0d",
                            Name = "Swimmer",
                            NormalizedName = "SWIMMER"
                        },
                        new
                        {
                            Id = "6c454d9b-a883-4b54-8a87-e0ffd5b3f4d1",
                            Name = "Coach",
                            NormalizedName = "COACH"
                        },
                        new
                        {
                            Id = "00aa858c-17df-4921-bbfb-93032ec29619",
                            Name = "Visitor",
                            NormalizedName = "VISITOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3f134502-f5da-4e85-89d7-b28ed9e693e3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "44a37c45-2966-49cd-b9ed-c604179d72ad",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEBWFFtmhCVgAUq2Tat5Gzhlr1VWpyRvcR3WPlSvw4s1N0ogj4uAyIqEkZPu5QO4X+Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "895849b0-f8f0-42f1-8f61-8fd736c2be21",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "0ada4ee7-f3f0-416b-8c7f-9d92c0aa53be",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e0f710db-58c1-4622-8d73-8cd933c660db",
                            Email = "visitor@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "VISITOR@GMAIL.COM",
                            NormalizedUserName = "VISITOR@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEuIhGOnMZf4eL/st7TZ0EoNwMT5SjprRQTtt52GwLCLELM+rCtZ44jVhweI8qR9pw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d36eca23-dbe6-4d33-baa0-0f3c03d4984f",
                            TwoFactorEnabled = false,
                            UserName = "visitor@gmail.com"
                        },
                        new
                        {
                            Id = "1937a86c-7e25-423f-9bd5-a9a9ff5cdb01",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "71782da8-d789-4f1b-bdab-15ee199789f6",
                            Email = "alejandro.garcia@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ALEJANDRO.GARCIA@GMAIL.COM",
                            NormalizedUserName = "ALEJANDRO.GARCIA@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEG2n/Dc0FbeKmI11+FCoK/Z1eM7A2UF/KGbsx9Vh1OehAF86LzUuSiQcGS+rxU9BhQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c8644fc5-e4b1-4bc6-a0eb-028ad22027bf",
                            TwoFactorEnabled = false,
                            UserName = "alejandro.garcia@gmail.com"
                        },
                        new
                        {
                            Id = "d18c5703-20cc-4c99-970b-06be0956f4a5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "812afb2d-0e2d-4556-8988-e0ef7cc0fee4",
                            Email = "mariana.lopez@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MARIANA.LOPEZ@GMAIL.COM",
                            NormalizedUserName = "MARIANA.LOPEZ@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAED0P6GqOz2ppcCkuR11w4TaKWR0Bhq75fqULelHw3cMOVWj+2MTuRnYD/Rq+YFkT8g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c095c088-90fc-4821-b2e7-67c696a6f9d2",
                            TwoFactorEnabled = false,
                            UserName = "mariana.lopez@gmail.com"
                        },
                        new
                        {
                            Id = "ff292857-9770-4483-9bd1-9a2ab3ebaf8a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3424eacf-a567-40c8-be34-015b4c42e2ce",
                            Email = "juan.perez@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JUAN.PEREZ@GMAIL.COM",
                            NormalizedUserName = "JUAN.PEREZ@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGtqRDiJIdVFvbrZKBB/PIowO12Ghkiyev4BAdVoJ799PiyjA+CjQl1i4HIrLr/5Vg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d3d4286b-1af2-4ad4-84a4-c4d24601b891",
                            TwoFactorEnabled = false,
                            UserName = "juan.perez@gmail.com"
                        },
                        new
                        {
                            Id = "222ae258-aaa1-432b-b927-fdece15cee01",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b97c512c-6b99-4b8d-a865-8163348c50c0",
                            Email = "laura.martinez@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "LAURA.MARTINEZ@GMAIL.COM",
                            NormalizedUserName = "LAURA.MARTINEZ@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEInDTeHxVJpzWZ0ofTbIwLjh3Nsu19soEQfphhZPY4KG8xvS8XyBR4UNyr6DGuieQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7423f079-f90e-47cd-94a0-1f54be1096be",
                            TwoFactorEnabled = false,
                            UserName = "laura.martinez@gmail.com"
                        },
                        new
                        {
                            Id = "3d87b147-b53f-47fb-887e-242b0695ffad",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fb5693df-d36e-45ba-a146-b1d60b215ce6",
                            Email = "sofia.torres@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SOFIA.TORRES@GMAIL.COM",
                            NormalizedUserName = "SOFIA.TORRES@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFEUsdgB2Qg7ipGmLHctyrO5jLYXZI8Os6zIAok6LMmnYqnEc7ruFou6/XfJhzU1+w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4d9bd862-c3be-453a-baf9-5e3592564884",
                            TwoFactorEnabled = false,
                            UserName = "sofia.torres@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "3f134502-f5da-4e85-89d7-b28ed9e693e3",
                            RoleId = "c3402e44-96b4-4dbb-ac18-63842e5d89b6"
                        },
                        new
                        {
                            UserId = "0ada4ee7-f3f0-416b-8c7f-9d92c0aa53be",
                            RoleId = "00aa858c-17df-4921-bbfb-93032ec29619"
                        },
                        new
                        {
                            UserId = "1937a86c-7e25-423f-9bd5-a9a9ff5cdb01",
                            RoleId = "6c454d9b-a883-4b54-8a87-e0ffd5b3f4d1"
                        },
                        new
                        {
                            UserId = "d18c5703-20cc-4c99-970b-06be0956f4a5",
                            RoleId = "6c454d9b-a883-4b54-8a87-e0ffd5b3f4d1"
                        },
                        new
                        {
                            UserId = "ff292857-9770-4483-9bd1-9a2ab3ebaf8a",
                            RoleId = "4bbff256-c063-4b0e-90f0-f8a02b10da0d"
                        },
                        new
                        {
                            UserId = "222ae258-aaa1-432b-b927-fdece15cee01",
                            RoleId = "4bbff256-c063-4b0e-90f0-f8a02b10da0d"
                        },
                        new
                        {
                            UserId = "3d87b147-b53f-47fb-887e-242b0695ffad",
                            RoleId = "4bbff256-c063-4b0e-90f0-f8a02b10da0d"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SmithSwimmingSchool_NickMorales.Models.Coach", b =>
                {
                    b.Property<int>("CoachID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoachID"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoachID");

                    b.ToTable("Coachs");

                    b.HasData(
                        new
                        {
                            CoachID = 1,
                            Email = "alejandro.garcia@gmail.com",
                            Name = "Alejandro García",
                            PhoneNumber = "123456780"
                        },
                        new
                        {
                            CoachID = 2,
                            Email = "mariana.lopez@gmail.com",
                            Name = "Mariana López",
                            PhoneNumber = "123456781"
                        });
                });

            modelBuilder.Entity("SmithSwimmingSchool_NickMorales.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"));

                    b.Property<int>("CoachID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.HasIndex("CoachID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseID = 1,
                            CoachID = 1,
                            Title = "Advanced Youth"
                        },
                        new
                        {
                            CourseID = 2,
                            CoachID = 2,
                            Title = "Beginner Adults"
                        });
                });

            modelBuilder.Entity("SmithSwimmingSchool_NickMorales.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<int>("SwimmerID")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("GroupID");

                    b.HasIndex("SwimmerID");

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            EnrollmentID = 1,
                            CourseID = 1,
                            GroupID = 1,
                            SwimmerID = 1
                        },
                        new
                        {
                            EnrollmentID = 2,
                            CourseID = 2,
                            GroupID = 2,
                            SwimmerID = 2
                        },
                        new
                        {
                            EnrollmentID = 3,
                            CourseID = 2,
                            GroupID = 2,
                            SwimmerID = 3
                        });
                });

            modelBuilder.Entity("SmithSwimmingSchool_NickMorales.Models.Group", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupID"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("Places")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("GroupID");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupID = 1,
                            EndDate = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Level = 2,
                            Places = 20,
                            StartDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            GroupID = 2,
                            EndDate = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Level = 0,
                            Places = 20,
                            StartDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("SmithSwimmingSchool_NickMorales.Models.Report", b =>
                {
                    b.Property<int>("ReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnrollmentID")
                        .HasColumnType("int");

                    b.HasKey("ReportID");

                    b.HasIndex("EnrollmentID");

                    b.ToTable("Reports");

                    b.HasData(
                        new
                        {
                            ReportID = 1,
                            Description = "Excellent progress",
                            EnrollmentID = 1
                        },
                        new
                        {
                            ReportID = 2,
                            Description = "Needs improvement in technique",
                            EnrollmentID = 2
                        });
                });

            modelBuilder.Entity("SmithSwimmingSchool_NickMorales.Models.Swimmer", b =>
                {
                    b.Property<int>("SwimmerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SwimmerID"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SwimmerID");

                    b.ToTable("Swimmers");

                    b.HasData(
                        new
                        {
                            SwimmerID = 1,
                            BirthDate = new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "juan.perez@gmail.com",
                            Genre = 0,
                            Name = "Juan Pérez",
                            PhoneNumber = "111111111"
                        },
                        new
                        {
                            SwimmerID = 2,
                            BirthDate = new DateTime(2010, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "laura.martinez@gmail.com",
                            Genre = 1,
                            Name = "Laura Martínez",
                            PhoneNumber = "222222222"
                        },
                        new
                        {
                            SwimmerID = 3,
                            BirthDate = new DateTime(2008, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sofia.torres@gmail.com",
                            Genre = 1,
                            Name = "Sofía Torres",
                            PhoneNumber = "333333333"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmithSwimmingSchool_NickMorales.Models.Course", b =>
                {
                    b.HasOne("SmithSwimmingSchool_NickMorales.Models.Coach", "Coach")
                        .WithMany()
                        .HasForeignKey("CoachID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coach");
                });

            modelBuilder.Entity("SmithSwimmingSchool_NickMorales.Models.Enrollment", b =>
                {
                    b.HasOne("SmithSwimmingSchool_NickMorales.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmithSwimmingSchool_NickMorales.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmithSwimmingSchool_NickMorales.Models.Swimmer", "Swimmer")
                        .WithMany()
                        .HasForeignKey("SwimmerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Group");

                    b.Navigation("Swimmer");
                });

            modelBuilder.Entity("SmithSwimmingSchool_NickMorales.Models.Report", b =>
                {
                    b.HasOne("SmithSwimmingSchool_NickMorales.Models.Enrollment", "Enrollment")
                        .WithMany()
                        .HasForeignKey("EnrollmentID");

                    b.Navigation("Enrollment");
                });
#pragma warning restore 612, 618
        }
    }
}
