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
    [Migration("20241211195713_Second")]
    partial class Second
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
                            Id = "097e276d-7d78-48b5-b3d0-9a07c6aeb35d",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "5965d0a4-6cc0-4b4e-aa28-d1ded18f6e57",
                            Name = "Swimmer",
                            NormalizedName = "SWIMMER"
                        },
                        new
                        {
                            Id = "dcd697b6-ebab-4e74-bb23-447858017148",
                            Name = "Coach",
                            NormalizedName = "COACH"
                        },
                        new
                        {
                            Id = "3b1c8c46-6304-4b64-af2d-4381b18ebfa5",
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
                            Id = "1ed1d03e-6b9e-420f-8492-0075abbfc3bb",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0ecd89c8-6bdf-4477-8f7c-27f4a03ef0be",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEG8u4vsQabkEMOIuGtVgJ1el1k5SmzJyBhfV8rVXIspjjoyQ3QTSeSX8Tyo5jId4oA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b212c6bc-7e8c-457b-ba3e-94262b261c39",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "4d53553c-0ad2-4f57-ae29-108bad5883f7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e9b6f363-3d43-455a-a980-cd4b296d92f3",
                            Email = "visitor@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "VISITOR@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAENoFORTfAtRx5mqL59VR4KZr+31dA0fpYMDgUftFSzMAaS6WgafGxsCdbAk/TgsfBg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f76c2e6a-dc57-40e6-aa67-d75fa03197f9",
                            TwoFactorEnabled = false,
                            UserName = "visitor@gmail.com"
                        },
                        new
                        {
                            Id = "5952b77d-a43e-4abe-a9a0-e84bcb52096c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "91018d09-fb20-4f2a-a2c6-18f824af956f",
                            Email = "alejandro.garcia@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ALEJANDRO.GARCIA@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGBoUKR/uiJy0R2NL2fu0EXPLgkMV7+MmokleU0KrxfcMJzZmz/wNIFimQvCrTI72A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2688b06b-2456-4977-99b5-d783337be6e1",
                            TwoFactorEnabled = false,
                            UserName = "alejandro.garcia@gmail.com"
                        },
                        new
                        {
                            Id = "73372ad9-f5a1-419d-ae2f-4e61da842712",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "819bbd7f-c321-47b2-bdb0-3eb7be5d59cb",
                            Email = "mariana.lopez@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MARIANA.LOPEZ@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEMKr8A8/GD9ee5vYjYCDHXfb26aRyXfB27F0/Txx9vWrRX1XUu43XqLCFIwlmOlJZA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1c2c0191-acc8-47a4-b315-b343663c1276",
                            TwoFactorEnabled = false,
                            UserName = "mariana.lopez@gmail.com"
                        },
                        new
                        {
                            Id = "59c40ef0-9d33-4a49-84cd-6d473613ee11",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4995676a-4b72-44c8-88fb-651fb3ba91be",
                            Email = "juan.perez@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JUAN.PEREZ@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEA94sg29Di/Wikrc1BQKLzKDNNB2b16qZyYrs9XcDTpPde+kA68uzzjOsLujI/AUow==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e19cbbc7-5158-458e-aed9-3535b62d7494",
                            TwoFactorEnabled = false,
                            UserName = "juan.perez@gmail.com"
                        },
                        new
                        {
                            Id = "f9fe425b-ea46-4e90-b46e-73dca5ef21b7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6dc2365a-fdc1-4751-963e-c62ba97a81a9",
                            Email = "laura.martinez@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "LAURA.MARTINEZ@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEWyojQZOhd7hwKSTMIjUlc1JA8YwS+bZj6NyDmJ9W6/e1eDFE10rGvG97YVtzzroQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2a813c7c-0b09-4b4d-b3b0-6653be9012af",
                            TwoFactorEnabled = false,
                            UserName = "laura.martinez@gmail.com"
                        },
                        new
                        {
                            Id = "90d6b798-e33c-4036-985b-9776e3c54efc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "da6df121-a6f3-47cf-8e48-22dde49e990f",
                            Email = "sofia.torres@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SOFIA.TORRES@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEI/0AQiIKvyWFuUQtl2r9O1Pf6OFQZFB21AIW7po7kssm0oANDupZq2/pJx5NdjSRA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "970cac82-250a-4885-80cf-7ddc59f912bb",
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
                            UserId = "1ed1d03e-6b9e-420f-8492-0075abbfc3bb",
                            RoleId = "097e276d-7d78-48b5-b3d0-9a07c6aeb35d"
                        },
                        new
                        {
                            UserId = "4d53553c-0ad2-4f57-ae29-108bad5883f7",
                            RoleId = "3b1c8c46-6304-4b64-af2d-4381b18ebfa5"
                        },
                        new
                        {
                            UserId = "5952b77d-a43e-4abe-a9a0-e84bcb52096c",
                            RoleId = "dcd697b6-ebab-4e74-bb23-447858017148"
                        },
                        new
                        {
                            UserId = "73372ad9-f5a1-419d-ae2f-4e61da842712",
                            RoleId = "dcd697b6-ebab-4e74-bb23-447858017148"
                        },
                        new
                        {
                            UserId = "59c40ef0-9d33-4a49-84cd-6d473613ee11",
                            RoleId = "5965d0a4-6cc0-4b4e-aa28-d1ded18f6e57"
                        },
                        new
                        {
                            UserId = "f9fe425b-ea46-4e90-b46e-73dca5ef21b7",
                            RoleId = "5965d0a4-6cc0-4b4e-aa28-d1ded18f6e57"
                        },
                        new
                        {
                            UserId = "90d6b798-e33c-4036-985b-9776e3c54efc",
                            RoleId = "5965d0a4-6cc0-4b4e-aa28-d1ded18f6e57"
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