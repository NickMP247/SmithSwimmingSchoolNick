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
    [Migration("20241220043846_newSwimmer")]
    partial class newSwimmer
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
                            Id = "b6fc1fb2-9859-4cc3-bb92-5fde9b90b982",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "b87a604a-843b-43e7-884f-8d1476871d9b",
                            Name = "Swimmer",
                            NormalizedName = "SWIMMER"
                        },
                        new
                        {
                            Id = "c8bf78c4-2ea2-47a8-bca5-65dde54530d8",
                            Name = "Coach",
                            NormalizedName = "COACH"
                        },
                        new
                        {
                            Id = "0e3d2d44-79be-4980-a82f-e54c0ae6565a",
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
                            Id = "d979bdc8-ec47-4206-abc8-de177c22fa50",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8aa15b61-e388-412d-8a5b-96cf35acd6ca",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAo7Ga2TdOlLPvs41imLC/XG0rC/N/IiYc/GJBqengipVZlTfPTs9rDztIy9p5X22g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fd67f013-96a8-4889-95bd-424c36fedccd",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "ce44046f-f33a-491f-a09f-9dd397a4c388",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "253f4593-30b7-4f8b-8660-c524bdb1f5f7",
                            Email = "visitor@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "VISITOR@GMAIL.COM",
                            NormalizedUserName = "VISITOR@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPMlUszoh9ZCo2LNJFSEaEqUBGhK6ogL9B2Q3TwSYPzOR47E2IGMv7YTzccvOAn8OQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "de6f21b7-010c-4d74-983b-89155803a559",
                            TwoFactorEnabled = false,
                            UserName = "visitor@gmail.com"
                        },
                        new
                        {
                            Id = "9a6b00c9-ffe1-49b3-b8fe-019eb7494c87",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f0fa5618-234c-41a8-b3d4-d3642dd6b256",
                            Email = "alejandro.garcia@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ALEJANDRO.GARCIA@GMAIL.COM",
                            NormalizedUserName = "ALEJANDRO.GARCIA@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAENAxpYgiLgrXvWm2i3frcd+Ho4OOrHTs8xXRmOTGKdw79qwhZotaZqBvPi1ILZrJpw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9372b0b8-4c7a-40f1-884a-b12c347334ca",
                            TwoFactorEnabled = false,
                            UserName = "alejandro.garcia@gmail.com"
                        },
                        new
                        {
                            Id = "8d833840-2e27-4456-b74b-7837fdfd492d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fe73a034-3781-4891-b2d3-81b4ef0d0b74",
                            Email = "mariana.lopez@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MARIANA.LOPEZ@GMAIL.COM",
                            NormalizedUserName = "MARIANA.LOPEZ@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPLBk8ZlJ71vmYnEeQyeCKdffESuxliKoUdvHUwgrpCsMhQGZQ4fmsA2BQuEqT5kYQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "766a7e8a-f43c-4ea6-bb27-72633bca84b4",
                            TwoFactorEnabled = false,
                            UserName = "mariana.lopez@gmail.com"
                        },
                        new
                        {
                            Id = "b50daf01-3a14-4350-8153-6180e8b36a52",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b43cc2f6-0d70-4463-b7fc-342ef6f661d0",
                            Email = "juan.perez@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JUAN.PEREZ@GMAIL.COM",
                            NormalizedUserName = "JUAN.PEREZ@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEOA3v4oDF43AuqBRR2QT5jLhDYRLMWTBFLkznJNO5UwiAJcWWYKx/Jqnb4yfTDhGRA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9c24df58-5b3f-404f-98ee-000fe9acfbdb",
                            TwoFactorEnabled = false,
                            UserName = "juan.perez@gmail.com"
                        },
                        new
                        {
                            Id = "2e36b572-bddb-4f35-8d6c-4975914ca5d5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c5f93326-9ec8-4417-8c26-294cf80e890a",
                            Email = "laura.martinez@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "LAURA.MARTINEZ@GMAIL.COM",
                            NormalizedUserName = "LAURA.MARTINEZ@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEJzpAOqa1IwZKBjE797xbc/slUW5KGOHdQqn/zaeQBZN1KbjCTYCbl2y3EeB79fpKw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "269b2b4e-09d4-49e5-b382-bb35565bd0c6",
                            TwoFactorEnabled = false,
                            UserName = "laura.martinez@gmail.com"
                        },
                        new
                        {
                            Id = "a652474d-1881-4c8f-ab0e-f1a8dbddbeb0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f579254b-cbed-445a-8a1c-162d79604453",
                            Email = "sofia.torres@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SOFIA.TORRES@GMAIL.COM",
                            NormalizedUserName = "SOFIA.TORRES@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEM5tAPw78YxZrAR9sG4kyo6mokvlrDjoD8nYD9Vyt6zqqWGv7L70T42mOMSUWGS05Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "99030eee-e6c7-480a-9b54-a4248ea0866e",
                            TwoFactorEnabled = false,
                            UserName = "sofia.torres@gmail.com"
                        },
                        new
                        {
                            Id = "914b261c-8297-4fdd-9b5b-ee5ef3b8be72",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5f6efd6e-b216-4c44-8061-87f237e72612",
                            Email = "gonzalo.torres@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "GONZALO.TORRES@GMAIL.COM",
                            NormalizedUserName = "GONZALO.TORRES@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDRSaFzW7IRkuShyLQ5+fj7piA/oulqbk5WzzzM0nmiWJG/gwWTPjObyQxrTjEn/uQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "832b6291-991e-4d6b-a3bc-d0212a498fa2",
                            TwoFactorEnabled = false,
                            UserName = "gonzalo.torres@gmail.com"
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
                            UserId = "d979bdc8-ec47-4206-abc8-de177c22fa50",
                            RoleId = "b6fc1fb2-9859-4cc3-bb92-5fde9b90b982"
                        },
                        new
                        {
                            UserId = "ce44046f-f33a-491f-a09f-9dd397a4c388",
                            RoleId = "0e3d2d44-79be-4980-a82f-e54c0ae6565a"
                        },
                        new
                        {
                            UserId = "9a6b00c9-ffe1-49b3-b8fe-019eb7494c87",
                            RoleId = "c8bf78c4-2ea2-47a8-bca5-65dde54530d8"
                        },
                        new
                        {
                            UserId = "8d833840-2e27-4456-b74b-7837fdfd492d",
                            RoleId = "c8bf78c4-2ea2-47a8-bca5-65dde54530d8"
                        },
                        new
                        {
                            UserId = "b50daf01-3a14-4350-8153-6180e8b36a52",
                            RoleId = "b87a604a-843b-43e7-884f-8d1476871d9b"
                        },
                        new
                        {
                            UserId = "2e36b572-bddb-4f35-8d6c-4975914ca5d5",
                            RoleId = "b87a604a-843b-43e7-884f-8d1476871d9b"
                        },
                        new
                        {
                            UserId = "a652474d-1881-4c8f-ab0e-f1a8dbddbeb0",
                            RoleId = "b87a604a-843b-43e7-884f-8d1476871d9b"
                        },
                        new
                        {
                            UserId = "914b261c-8297-4fdd-9b5b-ee5ef3b8be72",
                            RoleId = "b87a604a-843b-43e7-884f-8d1476871d9b"
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

                    b.Property<int?>("GroupID")
                        .HasColumnType("int");

                    b.Property<int?>("SwimmerID")
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
                        },
                        new
                        {
                            SwimmerID = 4,
                            BirthDate = new DateTime(2008, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "gonzalo.torres@gmail.com",
                            Genre = 0,
                            Name = "Gonzalo Torres",
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
                        .HasForeignKey("GroupID");

                    b.HasOne("SmithSwimmingSchool_NickMorales.Models.Swimmer", "Swimmer")
                        .WithMany()
                        .HasForeignKey("SwimmerID");

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
