using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmithSwimmingSchool_NickMorales.Data.Migrations
{
    /// <inheritdoc />
    public partial class SqlServerAzure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "3205dfa8-5ed3-4954-b57f-a807584cdb6f", null, "Swimmer", "SWIMMER" },
                    { "7d1cdedc-2684-4eaf-9b18-9852d334e655", null, "Coach", "COACH" },
                    { "8d9e3512-0bb4-4066-b791-6b9c8216f3b6", null, "Administrator", "ADMINISTRATOR" },
                    { "ac0b957e-f2b3-4a73-881d-50c20c32e65f", null, "Visitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "002edca8-100c-4eb6-8825-14e378753223", 0, "b0f66b98-f5d5-42fd-aa1a-1ab1f48483f3", "alejandro.garcia@gmail.com", true, false, null, "ALEJANDRO.GARCIA@GMAIL.COM", "ALEJANDRO.GARCIA@GMAIL.COM", "AQAAAAIAAYagAAAAEKPrGMln8Z0JCsc+Yir2dzpvLjBTsKzPsaP0tQZBYeDoqhzqA03N/y8qa7wsr7xEHQ==", null, false, "dcf2b1c0-deb8-4e0c-a34c-ad2c61af3e15", false, "alejandro.garcia@gmail.com" },
                    { "029d2d5f-5e84-4094-ab43-a9b841d66dcc", 0, "29291a36-14b7-4328-bafe-6bc4e8ab19ee", "sofia.torres@gmail.com", true, false, null, "SOFIA.TORRES@GMAIL.COM", "SOFIA.TORRES@GMAIL.COM", "AQAAAAIAAYagAAAAEFDO4iMhCskKm7WvfEJTRZ9Xa+AIsdwSsPkw1Yl9K9SH3ECJmJgF17iGxH3AHH8E0w==", null, false, "ac87401f-c7e0-4a03-83d9-64bb658f811f", false, "sofia.torres@gmail.com" },
                    { "0ca35f27-c442-4311-b4e0-b5a8704b63fd", 0, "c65fb723-ff91-42fd-9876-49b5702db0f5", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEH38SXSUdp7tJbpS884P9MxVr3Eldlp0jLL4HHLCtZvWkniLAqSss0YuaHhkcW2YKw==", null, false, "7823b997-0e31-4923-b73f-b5acb870001c", false, "admin@gmail.com" },
                    { "7ecf8a13-f865-4b73-a21a-ad9c1ea3f1d2", 0, "b6fc80a8-a8c9-479b-9d67-e3dd295a8321", "mariana.lopez@gmail.com", true, false, null, "MARIANA.LOPEZ@GMAIL.COM", "MARIANA.LOPEZ@GMAIL.COM", "AQAAAAIAAYagAAAAEPBekSHCw/221sI1gTAr4lAkeNnCrufwm/jZta1XgrcTRZlQ+vjcyHlef29ftmvjPQ==", null, false, "8722b014-036b-46c1-888d-4d3b5189f193", false, "mariana.lopez@gmail.com" },
                    { "879a58d3-ddcb-4436-a818-0c3605172988", 0, "272290f8-9a0d-4076-8af3-dd655b7a2c5a", "visitor@gmail.com", true, false, null, "VISITOR@GMAIL.COM", "VISITOR@GMAIL.COM", "AQAAAAIAAYagAAAAEP6nxqA++dTkZr8OmqrA1L4SHCNbUBVzQZhSp3EWnjdoeAU/538wBzGpeteB8Z6BeQ==", null, false, "4650d561-6568-4cab-843f-fb993bfa04a5", false, "visitor@gmail.com" },
                    { "9bb8d80f-3ecc-4513-9241-ea5a5ec7947f", 0, "d937b0c3-98f7-4eca-a54e-5c5c512e9bb4", "gonzalo.torres@gmail.com", true, false, null, "GONZALO.TORRES@GMAIL.COM", "GONZALO.TORRES@GMAIL.COM", "AQAAAAIAAYagAAAAEIS1oQ4+daCXnMuDNYCFVDyDLqtkQMknl01jj+PpvyFyLx0WlzcG/nfngTZs37hAkA==", null, false, "07002718-1f36-431b-9a9a-d80e8d485b7e", false, "gonzalo.torres@gmail.com" },
                    { "dd4e92c9-a253-4319-8ea9-d3071928bd95", 0, "6cb0fe96-e3a7-43e3-bcf0-b61a216bb12a", "juan.perez@gmail.com", true, false, null, "JUAN.PEREZ@GMAIL.COM", "JUAN.PEREZ@GMAIL.COM", "AQAAAAIAAYagAAAAEOiLnoQGFIRH3uNEozH/KELo9krOVV0KAQ7u19y7wGSYdAzbU/3QIqF6ECgxvO0BxA==", null, false, "4d046220-ace6-402c-9bc4-c359c072ea02", false, "juan.perez@gmail.com" },
                    { "dfd83910-eb9d-41f5-8719-5cf49aaeaaa4", 0, "cbb60a15-6db7-4a77-9bce-9dac1d944cb3", "laura.martinez@gmail.com", true, false, null, "LAURA.MARTINEZ@GMAIL.COM", "LAURA.MARTINEZ@GMAIL.COM", "AQAAAAIAAYagAAAAEMaXtF5uCBNFQ5v/gn5V8xzBNmUJcXyflJjT4RlT1VAsG9w6CtAOYz/w5iFbzcxYZA==", null, false, "1a3b5ae8-ae4a-4d5f-8ea6-b61cac1f2cb9", false, "laura.martinez@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7d1cdedc-2684-4eaf-9b18-9852d334e655", "002edca8-100c-4eb6-8825-14e378753223" },
                    { "3205dfa8-5ed3-4954-b57f-a807584cdb6f", "029d2d5f-5e84-4094-ab43-a9b841d66dcc" },
                    { "8d9e3512-0bb4-4066-b791-6b9c8216f3b6", "0ca35f27-c442-4311-b4e0-b5a8704b63fd" },
                    { "7d1cdedc-2684-4eaf-9b18-9852d334e655", "7ecf8a13-f865-4b73-a21a-ad9c1ea3f1d2" },
                    { "ac0b957e-f2b3-4a73-881d-50c20c32e65f", "879a58d3-ddcb-4436-a818-0c3605172988" },
                    { "3205dfa8-5ed3-4954-b57f-a807584cdb6f", "9bb8d80f-3ecc-4513-9241-ea5a5ec7947f" },
                    { "3205dfa8-5ed3-4954-b57f-a807584cdb6f", "dd4e92c9-a253-4319-8ea9-d3071928bd95" },
                    { "3205dfa8-5ed3-4954-b57f-a807584cdb6f", "dfd83910-eb9d-41f5-8719-5cf49aaeaaa4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7d1cdedc-2684-4eaf-9b18-9852d334e655", "002edca8-100c-4eb6-8825-14e378753223" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3205dfa8-5ed3-4954-b57f-a807584cdb6f", "029d2d5f-5e84-4094-ab43-a9b841d66dcc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8d9e3512-0bb4-4066-b791-6b9c8216f3b6", "0ca35f27-c442-4311-b4e0-b5a8704b63fd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7d1cdedc-2684-4eaf-9b18-9852d334e655", "7ecf8a13-f865-4b73-a21a-ad9c1ea3f1d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ac0b957e-f2b3-4a73-881d-50c20c32e65f", "879a58d3-ddcb-4436-a818-0c3605172988" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3205dfa8-5ed3-4954-b57f-a807584cdb6f", "9bb8d80f-3ecc-4513-9241-ea5a5ec7947f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3205dfa8-5ed3-4954-b57f-a807584cdb6f", "dd4e92c9-a253-4319-8ea9-d3071928bd95" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3205dfa8-5ed3-4954-b57f-a807584cdb6f", "dfd83910-eb9d-41f5-8719-5cf49aaeaaa4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3205dfa8-5ed3-4954-b57f-a807584cdb6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d1cdedc-2684-4eaf-9b18-9852d334e655");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d9e3512-0bb4-4066-b791-6b9c8216f3b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac0b957e-f2b3-4a73-881d-50c20c32e65f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "002edca8-100c-4eb6-8825-14e378753223");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "029d2d5f-5e84-4094-ab43-a9b841d66dcc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ca35f27-c442-4311-b4e0-b5a8704b63fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ecf8a13-f865-4b73-a21a-ad9c1ea3f1d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "879a58d3-ddcb-4436-a818-0c3605172988");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bb8d80f-3ecc-4513-9241-ea5a5ec7947f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd4e92c9-a253-4319-8ea9-d3071928bd95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfd83910-eb9d-41f5-8719-5cf49aaeaaa4");

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
    }
}
