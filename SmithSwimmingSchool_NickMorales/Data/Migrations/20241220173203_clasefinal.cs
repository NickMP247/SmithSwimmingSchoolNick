using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmithSwimmingSchool_NickMorales.Data.Migrations
{
    /// <inheritdoc />
    public partial class clasefinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b87a604a-843b-43e7-884f-8d1476871d9b", "2e36b572-bddb-4f35-8d6c-4975914ca5d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c8bf78c4-2ea2-47a8-bca5-65dde54530d8", "8d833840-2e27-4456-b74b-7837fdfd492d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b87a604a-843b-43e7-884f-8d1476871d9b", "914b261c-8297-4fdd-9b5b-ee5ef3b8be72" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c8bf78c4-2ea2-47a8-bca5-65dde54530d8", "9a6b00c9-ffe1-49b3-b8fe-019eb7494c87" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b87a604a-843b-43e7-884f-8d1476871d9b", "a652474d-1881-4c8f-ab0e-f1a8dbddbeb0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b87a604a-843b-43e7-884f-8d1476871d9b", "b50daf01-3a14-4350-8153-6180e8b36a52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e3d2d44-79be-4980-a82f-e54c0ae6565a", "ce44046f-f33a-491f-a09f-9dd397a4c388" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6fc1fb2-9859-4cc3-bb92-5fde9b90b982", "d979bdc8-ec47-4206-abc8-de177c22fa50" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e3d2d44-79be-4980-a82f-e54c0ae6565a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6fc1fb2-9859-4cc3-bb92-5fde9b90b982");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b87a604a-843b-43e7-884f-8d1476871d9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8bf78c4-2ea2-47a8-bca5-65dde54530d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e36b572-bddb-4f35-8d6c-4975914ca5d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d833840-2e27-4456-b74b-7837fdfd492d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "914b261c-8297-4fdd-9b5b-ee5ef3b8be72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a6b00c9-ffe1-49b3-b8fe-019eb7494c87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a652474d-1881-4c8f-ab0e-f1a8dbddbeb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b50daf01-3a14-4350-8153-6180e8b36a52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce44046f-f33a-491f-a09f-9dd397a4c388");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d979bdc8-ec47-4206-abc8-de177c22fa50");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b49c293-8690-4b6f-8f1e-23c2a4312cd3", null, "Administrator", "ADMINISTRATOR" },
                    { "a2b64652-7eaf-409f-a213-2008b5b78b1f", null, "Coach", "COACH" },
                    { "a8e69b86-8b3c-4b66-9522-cb8ddd81a980", null, "Swimmer", "SWIMMER" },
                    { "f269c88d-654f-471b-80c2-49ffa7c4d26d", null, "Visitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "361cae72-f426-4014-8a54-a68c779de0e9", 0, "fce15742-54ce-43db-898c-9b2912548a5d", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEBWTwidynNG3j6ECT5FXCMnGVupOnEhHk/XZJBH/9gFM80y0ZQYym+nBL+quZNKusA==", null, false, "045b7b44-62fb-4c5a-8a6e-b70a07903598", false, "admin@gmail.com" },
                    { "42cbc516-a3ca-4187-a7c7-397cb32ce98f", 0, "e574b262-d546-40be-9492-65a3a26ec4a2", "laura.martinez@gmail.com", true, false, null, "LAURA.MARTINEZ@GMAIL.COM", "LAURA.MARTINEZ@GMAIL.COM", "AQAAAAIAAYagAAAAECFrkXPQHIZUQuPP1psAZ2jUOCbh+DaWtEv7SqeNwhesRo+Mcbrt5tHjhpofGs/LEQ==", null, false, "dde0a4de-c569-40bf-9b12-cad8a185dc55", false, "laura.martinez@gmail.com" },
                    { "43181ffc-71ec-4e57-ae62-831e2869b10f", 0, "3a687297-8654-4bea-ae6f-0e094cfcaed0", "visitor@gmail.com", true, false, null, "VISITOR@GMAIL.COM", "VISITOR@GMAIL.COM", "AQAAAAIAAYagAAAAEN8p4DAEtrQzQ4xzWZGXUr8y/5YwOf7cRlPo+EhUb8MooJg5/EDXlcxO6nFiEoxVUw==", null, false, "a38abd35-bcdc-4097-b9cf-6e75837cd420", false, "visitor@gmail.com" },
                    { "4c5b98b3-ba59-46e9-982c-2ef2456d9f97", 0, "4f46b343-6084-4a78-97e4-0d7c42e77753", "alejandro.garcia@gmail.com", true, false, null, "ALEJANDRO.GARCIA@GMAIL.COM", "ALEJANDRO.GARCIA@GMAIL.COM", "AQAAAAIAAYagAAAAEG0nJUTSVfGFvtKYlkeVjxXgtCBegIlBrAdR5dGJIbzIu2p6UjLaCBgWZLteKcaQeA==", null, false, "0497e4f9-d128-4715-a4e8-a9bbd7f9609c", false, "alejandro.garcia@gmail.com" },
                    { "505abe7f-9cfb-4f54-ac16-fb010a871775", 0, "181a23e1-a6e6-4ac7-96ca-394817d63f0f", "gonzalo.torres@gmail.com", true, false, null, "GONZALO.TORRES@GMAIL.COM", "GONZALO.TORRES@GMAIL.COM", "AQAAAAIAAYagAAAAELdQ4B3U5qvvK1NBnUAP5hAReQbyV48N4M6cRKEL3fgq+qdtN6OEB4j/a5TyNq4lMA==", null, false, "5188c1fe-9d8f-47c2-8083-ae866890acbc", false, "gonzalo.torres@gmail.com" },
                    { "beab7baa-350b-4f06-a1f4-de5fa820af7d", 0, "838b4031-e5e1-4254-93a9-6c027e828441", "sofia.torres@gmail.com", true, false, null, "SOFIA.TORRES@GMAIL.COM", "SOFIA.TORRES@GMAIL.COM", "AQAAAAIAAYagAAAAEKhgRZO8nQjmi3hXgXLGu5i13t4aBfOb24m6mIOGRBMGg6mByZkNYMr0NJjcm1g1uQ==", null, false, "c749f859-7b36-43d0-aa9d-f891ccb43c1c", false, "sofia.torres@gmail.com" },
                    { "deeef038-72af-4e79-9ab0-82b323921626", 0, "a8b93d8d-38c4-442d-9c14-e6fad96453e5", "mariana.lopez@gmail.com", true, false, null, "MARIANA.LOPEZ@GMAIL.COM", "MARIANA.LOPEZ@GMAIL.COM", "AQAAAAIAAYagAAAAEODuyYfZk3D3pTwS9ZPOD7HvzYFkhn6al+hkzA79CoGMRQk+WlNI6EQmnrFzT46Bqw==", null, false, "7b3d17e8-3c18-4c83-aa4c-6f2069411935", false, "mariana.lopez@gmail.com" },
                    { "f59ed429-c483-484f-8de3-e3cc28028d6d", 0, "54927361-75f4-4c89-9b9f-4463ed760bb5", "juan.perez@gmail.com", true, false, null, "JUAN.PEREZ@GMAIL.COM", "JUAN.PEREZ@GMAIL.COM", "AQAAAAIAAYagAAAAEDOOmcMgOgFY3fuQt5YCRWbFan6nk3CKmMULZolvygpBZNBXbcsK2CrZJUAuay7ALw==", null, false, "beebaa67-1078-4382-acf8-f97f39f9fd02", false, "juan.perez@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2b49c293-8690-4b6f-8f1e-23c2a4312cd3", "361cae72-f426-4014-8a54-a68c779de0e9" },
                    { "a8e69b86-8b3c-4b66-9522-cb8ddd81a980", "42cbc516-a3ca-4187-a7c7-397cb32ce98f" },
                    { "f269c88d-654f-471b-80c2-49ffa7c4d26d", "43181ffc-71ec-4e57-ae62-831e2869b10f" },
                    { "a2b64652-7eaf-409f-a213-2008b5b78b1f", "4c5b98b3-ba59-46e9-982c-2ef2456d9f97" },
                    { "a8e69b86-8b3c-4b66-9522-cb8ddd81a980", "505abe7f-9cfb-4f54-ac16-fb010a871775" },
                    { "a8e69b86-8b3c-4b66-9522-cb8ddd81a980", "beab7baa-350b-4f06-a1f4-de5fa820af7d" },
                    { "a2b64652-7eaf-409f-a213-2008b5b78b1f", "deeef038-72af-4e79-9ab0-82b323921626" },
                    { "a8e69b86-8b3c-4b66-9522-cb8ddd81a980", "f59ed429-c483-484f-8de3-e3cc28028d6d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b49c293-8690-4b6f-8f1e-23c2a4312cd3", "361cae72-f426-4014-8a54-a68c779de0e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a8e69b86-8b3c-4b66-9522-cb8ddd81a980", "42cbc516-a3ca-4187-a7c7-397cb32ce98f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f269c88d-654f-471b-80c2-49ffa7c4d26d", "43181ffc-71ec-4e57-ae62-831e2869b10f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2b64652-7eaf-409f-a213-2008b5b78b1f", "4c5b98b3-ba59-46e9-982c-2ef2456d9f97" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a8e69b86-8b3c-4b66-9522-cb8ddd81a980", "505abe7f-9cfb-4f54-ac16-fb010a871775" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a8e69b86-8b3c-4b66-9522-cb8ddd81a980", "beab7baa-350b-4f06-a1f4-de5fa820af7d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2b64652-7eaf-409f-a213-2008b5b78b1f", "deeef038-72af-4e79-9ab0-82b323921626" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a8e69b86-8b3c-4b66-9522-cb8ddd81a980", "f59ed429-c483-484f-8de3-e3cc28028d6d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b49c293-8690-4b6f-8f1e-23c2a4312cd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2b64652-7eaf-409f-a213-2008b5b78b1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8e69b86-8b3c-4b66-9522-cb8ddd81a980");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f269c88d-654f-471b-80c2-49ffa7c4d26d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "361cae72-f426-4014-8a54-a68c779de0e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42cbc516-a3ca-4187-a7c7-397cb32ce98f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43181ffc-71ec-4e57-ae62-831e2869b10f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c5b98b3-ba59-46e9-982c-2ef2456d9f97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "505abe7f-9cfb-4f54-ac16-fb010a871775");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "beab7baa-350b-4f06-a1f4-de5fa820af7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "deeef038-72af-4e79-9ab0-82b323921626");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f59ed429-c483-484f-8de3-e3cc28028d6d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e3d2d44-79be-4980-a82f-e54c0ae6565a", null, "Visitor", "VISITOR" },
                    { "b6fc1fb2-9859-4cc3-bb92-5fde9b90b982", null, "Administrator", "ADMINISTRATOR" },
                    { "b87a604a-843b-43e7-884f-8d1476871d9b", null, "Swimmer", "SWIMMER" },
                    { "c8bf78c4-2ea2-47a8-bca5-65dde54530d8", null, "Coach", "COACH" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2e36b572-bddb-4f35-8d6c-4975914ca5d5", 0, "c5f93326-9ec8-4417-8c26-294cf80e890a", "laura.martinez@gmail.com", true, false, null, "LAURA.MARTINEZ@GMAIL.COM", "LAURA.MARTINEZ@GMAIL.COM", "AQAAAAIAAYagAAAAEJzpAOqa1IwZKBjE797xbc/slUW5KGOHdQqn/zaeQBZN1KbjCTYCbl2y3EeB79fpKw==", null, false, "269b2b4e-09d4-49e5-b382-bb35565bd0c6", false, "laura.martinez@gmail.com" },
                    { "8d833840-2e27-4456-b74b-7837fdfd492d", 0, "fe73a034-3781-4891-b2d3-81b4ef0d0b74", "mariana.lopez@gmail.com", true, false, null, "MARIANA.LOPEZ@GMAIL.COM", "MARIANA.LOPEZ@GMAIL.COM", "AQAAAAIAAYagAAAAEPLBk8ZlJ71vmYnEeQyeCKdffESuxliKoUdvHUwgrpCsMhQGZQ4fmsA2BQuEqT5kYQ==", null, false, "766a7e8a-f43c-4ea6-bb27-72633bca84b4", false, "mariana.lopez@gmail.com" },
                    { "914b261c-8297-4fdd-9b5b-ee5ef3b8be72", 0, "5f6efd6e-b216-4c44-8061-87f237e72612", "gonzalo.torres@gmail.com", true, false, null, "GONZALO.TORRES@GMAIL.COM", "GONZALO.TORRES@GMAIL.COM", "AQAAAAIAAYagAAAAEDRSaFzW7IRkuShyLQ5+fj7piA/oulqbk5WzzzM0nmiWJG/gwWTPjObyQxrTjEn/uQ==", null, false, "832b6291-991e-4d6b-a3bc-d0212a498fa2", false, "gonzalo.torres@gmail.com" },
                    { "9a6b00c9-ffe1-49b3-b8fe-019eb7494c87", 0, "f0fa5618-234c-41a8-b3d4-d3642dd6b256", "alejandro.garcia@gmail.com", true, false, null, "ALEJANDRO.GARCIA@GMAIL.COM", "ALEJANDRO.GARCIA@GMAIL.COM", "AQAAAAIAAYagAAAAENAxpYgiLgrXvWm2i3frcd+Ho4OOrHTs8xXRmOTGKdw79qwhZotaZqBvPi1ILZrJpw==", null, false, "9372b0b8-4c7a-40f1-884a-b12c347334ca", false, "alejandro.garcia@gmail.com" },
                    { "a652474d-1881-4c8f-ab0e-f1a8dbddbeb0", 0, "f579254b-cbed-445a-8a1c-162d79604453", "sofia.torres@gmail.com", true, false, null, "SOFIA.TORRES@GMAIL.COM", "SOFIA.TORRES@GMAIL.COM", "AQAAAAIAAYagAAAAEM5tAPw78YxZrAR9sG4kyo6mokvlrDjoD8nYD9Vyt6zqqWGv7L70T42mOMSUWGS05Q==", null, false, "99030eee-e6c7-480a-9b54-a4248ea0866e", false, "sofia.torres@gmail.com" },
                    { "b50daf01-3a14-4350-8153-6180e8b36a52", 0, "b43cc2f6-0d70-4463-b7fc-342ef6f661d0", "juan.perez@gmail.com", true, false, null, "JUAN.PEREZ@GMAIL.COM", "JUAN.PEREZ@GMAIL.COM", "AQAAAAIAAYagAAAAEOA3v4oDF43AuqBRR2QT5jLhDYRLMWTBFLkznJNO5UwiAJcWWYKx/Jqnb4yfTDhGRA==", null, false, "9c24df58-5b3f-404f-98ee-000fe9acfbdb", false, "juan.perez@gmail.com" },
                    { "ce44046f-f33a-491f-a09f-9dd397a4c388", 0, "253f4593-30b7-4f8b-8660-c524bdb1f5f7", "visitor@gmail.com", true, false, null, "VISITOR@GMAIL.COM", "VISITOR@GMAIL.COM", "AQAAAAIAAYagAAAAEPMlUszoh9ZCo2LNJFSEaEqUBGhK6ogL9B2Q3TwSYPzOR47E2IGMv7YTzccvOAn8OQ==", null, false, "de6f21b7-010c-4d74-983b-89155803a559", false, "visitor@gmail.com" },
                    { "d979bdc8-ec47-4206-abc8-de177c22fa50", 0, "8aa15b61-e388-412d-8a5b-96cf35acd6ca", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEAo7Ga2TdOlLPvs41imLC/XG0rC/N/IiYc/GJBqengipVZlTfPTs9rDztIy9p5X22g==", null, false, "fd67f013-96a8-4889-95bd-424c36fedccd", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b87a604a-843b-43e7-884f-8d1476871d9b", "2e36b572-bddb-4f35-8d6c-4975914ca5d5" },
                    { "c8bf78c4-2ea2-47a8-bca5-65dde54530d8", "8d833840-2e27-4456-b74b-7837fdfd492d" },
                    { "b87a604a-843b-43e7-884f-8d1476871d9b", "914b261c-8297-4fdd-9b5b-ee5ef3b8be72" },
                    { "c8bf78c4-2ea2-47a8-bca5-65dde54530d8", "9a6b00c9-ffe1-49b3-b8fe-019eb7494c87" },
                    { "b87a604a-843b-43e7-884f-8d1476871d9b", "a652474d-1881-4c8f-ab0e-f1a8dbddbeb0" },
                    { "b87a604a-843b-43e7-884f-8d1476871d9b", "b50daf01-3a14-4350-8153-6180e8b36a52" },
                    { "0e3d2d44-79be-4980-a82f-e54c0ae6565a", "ce44046f-f33a-491f-a09f-9dd397a4c388" },
                    { "b6fc1fb2-9859-4cc3-bb92-5fde9b90b982", "d979bdc8-ec47-4206-abc8-de177c22fa50" }
                });
        }
    }
}
