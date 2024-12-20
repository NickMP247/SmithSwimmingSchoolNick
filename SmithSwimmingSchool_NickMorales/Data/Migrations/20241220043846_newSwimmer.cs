using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmithSwimmingSchool_NickMorales.Data.Migrations
{
    /// <inheritdoc />
    public partial class newSwimmer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb8756f1-ed8d-4c01-9b00-3919a733df90", "0aa4bed0-83ac-49a6-a0a2-963603ed5c27" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7447542b-c27d-4ac4-aca2-db28289e853c", "254b1d65-9dd7-4649-ab16-42df3be475c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "18f46238-eb5a-4172-8e34-747bcd606b58", "49fe7b68-017c-4770-a2fe-6476588f2df7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7447542b-c27d-4ac4-aca2-db28289e853c", "7c8f63ad-c513-4e23-b2f9-75cd24d589b2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7447542b-c27d-4ac4-aca2-db28289e853c", "f4a69dcd-8ee7-4a11-80bb-4db7e2110d80" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3b84c952-bbe8-4ce4-a20f-10e98256a899", "fae82abe-57ed-41b7-9633-3ecb9f4be110" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "18f46238-eb5a-4172-8e34-747bcd606b58", "fe0b2d54-1571-4111-afbd-7a648fc262ac" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18f46238-eb5a-4172-8e34-747bcd606b58");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b84c952-bbe8-4ce4-a20f-10e98256a899");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7447542b-c27d-4ac4-aca2-db28289e853c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb8756f1-ed8d-4c01-9b00-3919a733df90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0aa4bed0-83ac-49a6-a0a2-963603ed5c27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "254b1d65-9dd7-4649-ab16-42df3be475c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49fe7b68-017c-4770-a2fe-6476588f2df7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c8f63ad-c513-4e23-b2f9-75cd24d589b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4a69dcd-8ee7-4a11-80bb-4db7e2110d80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fae82abe-57ed-41b7-9633-3ecb9f4be110");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe0b2d54-1571-4111-afbd-7a648fc262ac");

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
                table: "Swimmers",
                columns: new[] { "SwimmerID", "BirthDate", "Email", "Genre", "Name", "PhoneNumber" },
                values: new object[] { 4, new DateTime(2008, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "gonzalo.torres@gmail.com", 0, "Gonzalo Torres", "333333333" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Swimmers",
                keyColumn: "SwimmerID",
                keyValue: 4);

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
                    { "18f46238-eb5a-4172-8e34-747bcd606b58", null, "Coach", "COACH" },
                    { "3b84c952-bbe8-4ce4-a20f-10e98256a899", null, "Administrator", "ADMINISTRATOR" },
                    { "7447542b-c27d-4ac4-aca2-db28289e853c", null, "Swimmer", "SWIMMER" },
                    { "fb8756f1-ed8d-4c01-9b00-3919a733df90", null, "Visitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0aa4bed0-83ac-49a6-a0a2-963603ed5c27", 0, "0b67168e-97b6-411e-812b-c51c0f9f4916", "visitor@gmail.com", true, false, null, "VISITOR@GMAIL.COM", "VISITOR@GMAIL.COM", "AQAAAAIAAYagAAAAEFJzT7PcLAbms6wIWSMd8dbihGtWt5us2c9+lOqLBD2ZpZOcpPOqlSRMjeoQvkn+7Q==", null, false, "c533cdda-9d5a-4468-b3fd-b7c09edb2f11", false, "visitor@gmail.com" },
                    { "254b1d65-9dd7-4649-ab16-42df3be475c1", 0, "0330d721-f698-413b-b511-caa34c22daae", "laura.martinez@gmail.com", true, false, null, "LAURA.MARTINEZ@GMAIL.COM", "LAURA.MARTINEZ@GMAIL.COM", "AQAAAAIAAYagAAAAEMGl3f6f6lBNTgqXGjfFxK+OQS5+QM5RVI3UxqlS6CX+EcubH4ZbcU59DUmXDVX6AA==", null, false, "f5388b93-4f6e-464f-917d-bac464586154", false, "laura.martinez@gmail.com" },
                    { "49fe7b68-017c-4770-a2fe-6476588f2df7", 0, "dd3793e6-5ac4-4f38-b084-adb65d8e8de3", "mariana.lopez@gmail.com", true, false, null, "MARIANA.LOPEZ@GMAIL.COM", "MARIANA.LOPEZ@GMAIL.COM", "AQAAAAIAAYagAAAAEHBOkx62OH0ktOnDbCII65f/IsTmmHQn1Lg6g8VvIfksjlU1GhHmOezu3Rro7Ize5w==", null, false, "2ca0ea63-335c-4fe4-ba8b-d5e6e2553daf", false, "mariana.lopez@gmail.com" },
                    { "7c8f63ad-c513-4e23-b2f9-75cd24d589b2", 0, "1ed42d9b-648d-45bc-9d12-7dfe3828d8d4", "juan.perez@gmail.com", true, false, null, "JUAN.PEREZ@GMAIL.COM", "JUAN.PEREZ@GMAIL.COM", "AQAAAAIAAYagAAAAENIP8HLc5/k2qw16Dd8Z6ZKgRvXCO+fE3VEsY0BkmuGr/psMtgNkZsoQyWK74SlELA==", null, false, "e2b77b4d-3fd3-415f-be6a-8f51fef46f65", false, "juan.perez@gmail.com" },
                    { "f4a69dcd-8ee7-4a11-80bb-4db7e2110d80", 0, "5559b0bb-91fc-4e6c-ab37-2f9100671a69", "sofia.torres@gmail.com", true, false, null, "SOFIA.TORRES@GMAIL.COM", "SOFIA.TORRES@GMAIL.COM", "AQAAAAIAAYagAAAAEHHFd4dPOHPZphrZqeqt/v0VZiCJfU3+3OLNt0BXQTxTrhrtFrDWQxe3yMWuCARZHA==", null, false, "ca3f3303-dd3b-4b94-83ab-b3b60586982b", false, "sofia.torres@gmail.com" },
                    { "fae82abe-57ed-41b7-9633-3ecb9f4be110", 0, "0d947fed-3ac7-47ec-8213-cfcf257d29db", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEN3+ZgDL5dQ/4rJvEsFZhaOuFbzTLrWsv/zSQt8erg73WQxdyidVob47nh4GHGqyZg==", null, false, "bfcd5bee-18b1-403d-af23-3ad2ef582a46", false, "admin@gmail.com" },
                    { "fe0b2d54-1571-4111-afbd-7a648fc262ac", 0, "88647df8-dc12-4589-ba2b-733c5a99ba8c", "alejandro.garcia@gmail.com", true, false, null, "ALEJANDRO.GARCIA@GMAIL.COM", "ALEJANDRO.GARCIA@GMAIL.COM", "AQAAAAIAAYagAAAAEK3sfioACQnrGrQuafpk31PVx+WqHBOdfpOml0x2sSvFd6Fr2MUBw5GJ801apQcwLQ==", null, false, "0ea2774a-4f31-482c-99b6-3e3fcc5832f2", false, "alejandro.garcia@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fb8756f1-ed8d-4c01-9b00-3919a733df90", "0aa4bed0-83ac-49a6-a0a2-963603ed5c27" },
                    { "7447542b-c27d-4ac4-aca2-db28289e853c", "254b1d65-9dd7-4649-ab16-42df3be475c1" },
                    { "18f46238-eb5a-4172-8e34-747bcd606b58", "49fe7b68-017c-4770-a2fe-6476588f2df7" },
                    { "7447542b-c27d-4ac4-aca2-db28289e853c", "7c8f63ad-c513-4e23-b2f9-75cd24d589b2" },
                    { "7447542b-c27d-4ac4-aca2-db28289e853c", "f4a69dcd-8ee7-4a11-80bb-4db7e2110d80" },
                    { "3b84c952-bbe8-4ce4-a20f-10e98256a899", "fae82abe-57ed-41b7-9633-3ecb9f4be110" },
                    { "18f46238-eb5a-4172-8e34-747bcd606b58", "fe0b2d54-1571-4111-afbd-7a648fc262ac" }
                });
        }
    }
}
