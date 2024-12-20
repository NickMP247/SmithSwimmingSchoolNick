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
    [Migration("20241220173203_clasefinal")]
    partial class clasefinal
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
                            Id = "2b49c293-8690-4b6f-8f1e-23c2a4312cd3",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "a8e69b86-8b3c-4b66-9522-cb8ddd81a980",
                            Name = "Swimmer",
                            NormalizedName = "SWIMMER"
                        },
                        new
                        {
                            Id = "a2b64652-7eaf-409f-a213-2008b5b78b1f",
                            Name = "Coach",
                            NormalizedName = "COACH"
                        },
                        new
                        {
                            Id = "f269c88d-654f-471b-80c2-49ffa7c4d26d",
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
                            Id = "361cae72-f426-4014-8a54-a68c779de0e9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fce15742-54ce-43db-898c-9b2912548a5d",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEBWTwidynNG3j6ECT5FXCMnGVupOnEhHk/XZJBH/9gFM80y0ZQYym+nBL+quZNKusA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "045b7b44-62fb-4c5a-8a6e-b70a07903598",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "43181ffc-71ec-4e57-ae62-831e2869b10f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3a687297-8654-4bea-ae6f-0e094cfcaed0",
                            Email = "visitor@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "VISITOR@GMAIL.COM",
                            NormalizedUserName = "VISITOR@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEN8p4DAEtrQzQ4xzWZGXUr8y/5YwOf7cRlPo+EhUb8MooJg5/EDXlcxO6nFiEoxVUw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a38abd35-bcdc-4097-b9cf-6e75837cd420",
                            TwoFactorEnabled = false,
                            UserName = "visitor@gmail.com"
                        },
                        new
                        {
                            Id = "4c5b98b3-ba59-46e9-982c-2ef2456d9f97",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4f46b343-6084-4a78-97e4-0d7c42e77753",
                            Email = "alejandro.garcia@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ALEJANDRO.GARCIA@GMAIL.COM",
                            NormalizedUserName = "ALEJANDRO.GARCIA@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEG0nJUTSVfGFvtKYlkeVjxXgtCBegIlBrAdR5dGJIbzIu2p6UjLaCBgWZLteKcaQeA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0497e4f9-d128-4715-a4e8-a9bbd7f9609c",
                            TwoFactorEnabled = false,
                            UserName = "alejandro.garcia@gmail.com"
                        },
                        new
                        {
                            Id = "deeef038-72af-4e79-9ab0-82b323921626",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a8b93d8d-38c4-442d-9c14-e6fad96453e5",
                            Email = "mariana.lopez@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MARIANA.LOPEZ@GMAIL.COM",
                            NormalizedUserName = "MARIANA.LOPEZ@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEODuyYfZk3D3pTwS9ZPOD7HvzYFkhn6al+hkzA79CoGMRQk+WlNI6EQmnrFzT46Bqw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7b3d17e8-3c18-4c83-aa4c-6f2069411935",
                            TwoFactorEnabled = false,
                            UserName = "mariana.lopez@gmail.com"
                        },
                        new
                        {
                            Id = "f59ed429-c483-484f-8de3-e3cc28028d6d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "54927361-75f4-4c89-9b9f-4463ed760bb5",
                            Email = "juan.perez@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JUAN.PEREZ@GMAIL.COM",
                            NormalizedUserName = "JUAN.PEREZ@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDOOmcMgOgFY3fuQt5YCRWbFan6nk3CKmMULZolvygpBZNBXbcsK2CrZJUAuay7ALw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "beebaa67-1078-4382-acf8-f97f39f9fd02",
                            TwoFactorEnabled = false,
                            UserName = "juan.perez@gmail.com"
                        },
                        new
                        {
                            Id = "42cbc516-a3ca-4187-a7c7-397cb32ce98f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e574b262-d546-40be-9492-65a3a26ec4a2",
                            Email = "laura.martinez@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "LAURA.MARTINEZ@GMAIL.COM",
                            NormalizedUserName = "LAURA.MARTINEZ@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAECFrkXPQHIZUQuPP1psAZ2jUOCbh+DaWtEv7SqeNwhesRo+Mcbrt5tHjhpofGs/LEQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dde0a4de-c569-40bf-9b12-cad8a185dc55",
                            TwoFactorEnabled = false,
                            UserName = "laura.martinez@gmail.com"
                        },
                        new
                        {
                            Id = "beab7baa-350b-4f06-a1f4-de5fa820af7d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "838b4031-e5e1-4254-93a9-6c027e828441",
                            Email = "sofia.torres@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SOFIA.TORRES@GMAIL.COM",
                            NormalizedUserName = "SOFIA.TORRES@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEKhgRZO8nQjmi3hXgXLGu5i13t4aBfOb24m6mIOGRBMGg6mByZkNYMr0NJjcm1g1uQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c749f859-7b36-43d0-aa9d-f891ccb43c1c",
                            TwoFactorEnabled = false,
                            UserName = "sofia.torres@gmail.com"
                        },
                        new
                        {
                            Id = "505abe7f-9cfb-4f54-ac16-fb010a871775",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "181a23e1-a6e6-4ac7-96ca-394817d63f0f",
                            Email = "gonzalo.torres@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "GONZALO.TORRES@GMAIL.COM",
                            NormalizedUserName = "GONZALO.TORRES@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELdQ4B3U5qvvK1NBnUAP5hAReQbyV48N4M6cRKEL3fgq+qdtN6OEB4j/a5TyNq4lMA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5188c1fe-9d8f-47c2-8083-ae866890acbc",
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
                            UserId = "361cae72-f426-4014-8a54-a68c779de0e9",
                            RoleId = "2b49c293-8690-4b6f-8f1e-23c2a4312cd3"
                        },
                        new
                        {
                            UserId = "43181ffc-71ec-4e57-ae62-831e2869b10f",
                            RoleId = "f269c88d-654f-471b-80c2-49ffa7c4d26d"
                        },
                        new
                        {
                            UserId = "4c5b98b3-ba59-46e9-982c-2ef2456d9f97",
                            RoleId = "a2b64652-7eaf-409f-a213-2008b5b78b1f"
                        },
                        new
                        {
                            UserId = "deeef038-72af-4e79-9ab0-82b323921626",
                            RoleId = "a2b64652-7eaf-409f-a213-2008b5b78b1f"
                        },
                        new
                        {
                            UserId = "f59ed429-c483-484f-8de3-e3cc28028d6d",
                            RoleId = "a8e69b86-8b3c-4b66-9522-cb8ddd81a980"
                        },
                        new
                        {
                            UserId = "42cbc516-a3ca-4187-a7c7-397cb32ce98f",
                            RoleId = "a8e69b86-8b3c-4b66-9522-cb8ddd81a980"
                        },
                        new
                        {
                            UserId = "beab7baa-350b-4f06-a1f4-de5fa820af7d",
                            RoleId = "a8e69b86-8b3c-4b66-9522-cb8ddd81a980"
                        },
                        new
                        {
                            UserId = "505abe7f-9cfb-4f54-ac16-fb010a871775",
                            RoleId = "a8e69b86-8b3c-4b66-9522-cb8ddd81a980"
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
