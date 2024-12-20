using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmithSwimmingSchool_NickMorales.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coachs",
                columns: table => new
                {
                    CoachID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coachs", x => x.CoachID);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Places = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupID);
                });

            migrationBuilder.CreateTable(
                name: "Swimmers",
                columns: table => new
                {
                    SwimmerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Swimmers", x => x.SwimmerID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoachID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                    table.ForeignKey(
                        name: "FK_Courses_Coachs_CoachID",
                        column: x => x.CoachID,
                        principalTable: "Coachs",
                        principalColumn: "CoachID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    EnrollmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    SwimmerID = table.Column<int>(type: "int", nullable: false),
                    GroupID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.EnrollmentID);
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Groups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Groups",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Swimmers_SwimmerID",
                        column: x => x.SwimmerID,
                        principalTable: "Swimmers",
                        principalColumn: "SwimmerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnrollmentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportID);
                    table.ForeignKey(
                        name: "FK_Reports_Enrollments_EnrollmentID",
                        column: x => x.EnrollmentID,
                        principalTable: "Enrollments",
                        principalColumn: "EnrollmentID");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1bdd872f-dfab-40bf-b3ac-2dbda7fb86b2", null, "Administrator", "ADMINISTRATOR" },
                    { "bbaa7d7c-81e4-40f1-9fcd-83d76e64aa85", null, "Swimmer", "SWIMMER" },
                    { "d458216e-8e35-4cf9-9538-c0b1ff27a9ec", null, "Visitor", "VISITOR" },
                    { "fb799699-8021-405f-bbba-0102ef2e7c56", null, "Coach", "COACH" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2fb6c4a8-5e11-4a71-af08-b7eadaa37f47", 0, "fc920721-9d58-4540-8480-5d0356d607d4", "laura.martinez@gmail.com", true, false, null, "LAURA.MARTINEZ@GMAIL.COM", null, "AQAAAAIAAYagAAAAEE47T7C74ciRqSCvmxulu7UD2KW55Nf8SLGgYtfuzJ7D3Ix67J+TQPbBJoJjMjEWcQ==", null, false, "a9010fff-cccd-47b1-ba9f-f7c2bf0fb393", false, "laura.martinez@gmail.com" },
                    { "6d0464d5-9bcc-4c3b-8136-a00af390b3ee", 0, "09a7577f-db41-4f67-aa01-23ef0f80b6fc", "mariana.lopez@gmail.com", true, false, null, "MARIANA.LOPEZ@GMAIL.COM", null, "AQAAAAIAAYagAAAAEFWAe0upocBlJzfB9jfKJHL5R2NusPoiCaUozaDF6FHVTX1++CYICuAOWH2gOQZAlw==", null, false, "8e4d5f7d-e026-4e02-980b-c2540b21537f", false, "mariana.lopez@gmail.com" },
                    { "86cf6e74-9a89-4abf-92d7-430a2ed26268", 0, "77e2015d-7785-43a7-a4c9-f4d38325b7b0", "juan.perez@gmail.com", true, false, null, "JUAN.PEREZ@GMAIL.COM", null, "AQAAAAIAAYagAAAAEF9jrZ4fqJhcRY4Idts8HTE7d57cPgSarzf4HVSxJdwFCu34FzongkDlSovvF85dwQ==", null, false, "68c9d350-cc01-4133-87e8-bbddb0ecd8e5", false, "juan.perez@gmail.com" },
                    { "9303f70b-eded-4dce-9110-b9cddbd1d7d6", 0, "de291c16-1ecd-4ea6-ba68-ab2e3e66eb70", "sofia.torres@gmail.com", true, false, null, "SOFIA.TORRES@GMAIL.COM", null, "AQAAAAIAAYagAAAAEHeItXxnummyiqGB6+hDOjfZFd+a3K6aNue+8EsgCYw4upKIA2biHrjBJCtfNbqM8w==", null, false, "92d0cf02-b31f-4370-b905-b3c55d8b4d67", false, "sofia.torres@gmail.com" },
                    { "cd3e85c9-749f-490c-a435-eacd20424a7e", 0, "dcd86f31-c987-4b47-97bf-7c30f4aa7a81", "alejandro.garcia@gmail.com", true, false, null, "ALEJANDRO.GARCIA@GMAIL.COM", null, "AQAAAAIAAYagAAAAEDAnnN41/jQ7axgN94B0pvtkQElQ0g4gW4o6X79e7Hbgea3eKFQ0uPl4h9l9rer0WA==", null, false, "a57a2c76-a26f-4666-96fe-93f5d0d8f28f", false, "alejandro.garcia@gmail.com" },
                    { "d0c3daf8-22cb-4c27-a050-33ba6b9f567a", 0, "9c3e9844-bb6a-415e-ae41-791ad0735553", "visitor@gmail.com", true, false, null, "VISITOR@GMAIL.COM", null, "AQAAAAIAAYagAAAAEMyV9ILqBVIBd3vYUXNOPFQUtGzUKsV6/JORbQpi3jxlcZcJUrULDt//PLTTJHvRgg==", null, false, "91a5e911-3347-410f-8f32-0f8b03edd14a", false, "visitor@gmail.com" },
                    { "e01f2524-2add-4fab-a500-2f77a813581a", 0, "a019d850-88c6-442e-8e53-c3215770eb72", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", null, "AQAAAAIAAYagAAAAEHGHlaAwjrmKc1WoZJB5V2wi/cwCXCfBVmkVESdlIzndSwBzBwJCpc6mge1Kd/Su/Q==", null, false, "c731893e-4873-4525-8221-d776f46e475d", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Coachs",
                columns: new[] { "CoachID", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "alejandro.garcia@gmail.com", "Alejandro García", "123456780" },
                    { 2, "mariana.lopez@gmail.com", "Mariana López", "123456781" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupID", "EndDate", "Level", "Places", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 20, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 20, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Swimmers",
                columns: new[] { "SwimmerID", "BirthDate", "Email", "Genre", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "juan.perez@gmail.com", 0, "Juan Pérez", "111111111" },
                    { 2, new DateTime(2010, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "laura.martinez@gmail.com", 1, "Laura Martínez", "222222222" },
                    { 3, new DateTime(2008, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sofia.torres@gmail.com", 1, "Sofía Torres", "333333333" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "CoachID", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Advanced Youth" },
                    { 2, 2, "Beginner Adults" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentID", "CourseID", "GroupID", "SwimmerID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 2, 2 },
                    { 3, 2, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "ReportID", "Description", "EnrollmentID" },
                values: new object[,]
                {
                    { 1, "Excellent progress", 1 },
                    { 2, "Needs improvement in technique", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CoachID",
                table: "Courses",
                column: "CoachID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseID",
                table: "Enrollments",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_GroupID",
                table: "Enrollments",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_SwimmerID",
                table: "Enrollments",
                column: "SwimmerID");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_EnrollmentID",
                table: "Reports",
                column: "EnrollmentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Swimmers");

            migrationBuilder.DropTable(
                name: "Coachs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bdd872f-dfab-40bf-b3ac-2dbda7fb86b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbaa7d7c-81e4-40f1-9fcd-83d76e64aa85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d458216e-8e35-4cf9-9538-c0b1ff27a9ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb799699-8021-405f-bbba-0102ef2e7c56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fb6c4a8-5e11-4a71-af08-b7eadaa37f47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d0464d5-9bcc-4c3b-8136-a00af390b3ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86cf6e74-9a89-4abf-92d7-430a2ed26268");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9303f70b-eded-4dce-9110-b9cddbd1d7d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd3e85c9-749f-490c-a435-eacd20424a7e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0c3daf8-22cb-4c27-a050-33ba6b9f567a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e01f2524-2add-4fab-a500-2f77a813581a");
        }
    }
}
