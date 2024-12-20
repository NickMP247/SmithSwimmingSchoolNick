using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmithSwimmingSchool_NickMorales.Data.Migrations
{
    /// <inheritdoc />
    public partial class newModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Groups_GroupID",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Swimmers_SwimmerID",
                table: "Enrollments");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00aa858c-17df-4921-bbfb-93032ec29619", "0ada4ee7-f3f0-416b-8c7f-9d92c0aa53be" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c454d9b-a883-4b54-8a87-e0ffd5b3f4d1", "1937a86c-7e25-423f-9bd5-a9a9ff5cdb01" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4bbff256-c063-4b0e-90f0-f8a02b10da0d", "222ae258-aaa1-432b-b927-fdece15cee01" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4bbff256-c063-4b0e-90f0-f8a02b10da0d", "3d87b147-b53f-47fb-887e-242b0695ffad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3402e44-96b4-4dbb-ac18-63842e5d89b6", "3f134502-f5da-4e85-89d7-b28ed9e693e3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c454d9b-a883-4b54-8a87-e0ffd5b3f4d1", "d18c5703-20cc-4c99-970b-06be0956f4a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4bbff256-c063-4b0e-90f0-f8a02b10da0d", "ff292857-9770-4483-9bd1-9a2ab3ebaf8a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00aa858c-17df-4921-bbfb-93032ec29619");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bbff256-c063-4b0e-90f0-f8a02b10da0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c454d9b-a883-4b54-8a87-e0ffd5b3f4d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3402e44-96b4-4dbb-ac18-63842e5d89b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ada4ee7-f3f0-416b-8c7f-9d92c0aa53be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1937a86c-7e25-423f-9bd5-a9a9ff5cdb01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "222ae258-aaa1-432b-b927-fdece15cee01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d87b147-b53f-47fb-887e-242b0695ffad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f134502-f5da-4e85-89d7-b28ed9e693e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18c5703-20cc-4c99-970b-06be0956f4a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff292857-9770-4483-9bd1-9a2ab3ebaf8a");

            migrationBuilder.AlterColumn<int>(
                name: "SwimmerID",
                table: "Enrollments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GroupID",
                table: "Enrollments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Groups_GroupID",
                table: "Enrollments",
                column: "GroupID",
                principalTable: "Groups",
                principalColumn: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Swimmers_SwimmerID",
                table: "Enrollments",
                column: "SwimmerID",
                principalTable: "Swimmers",
                principalColumn: "SwimmerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Groups_GroupID",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Swimmers_SwimmerID",
                table: "Enrollments");

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

            migrationBuilder.AlterColumn<int>(
                name: "SwimmerID",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GroupID",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00aa858c-17df-4921-bbfb-93032ec29619", null, "Visitor", "VISITOR" },
                    { "4bbff256-c063-4b0e-90f0-f8a02b10da0d", null, "Swimmer", "SWIMMER" },
                    { "6c454d9b-a883-4b54-8a87-e0ffd5b3f4d1", null, "Coach", "COACH" },
                    { "c3402e44-96b4-4dbb-ac18-63842e5d89b6", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0ada4ee7-f3f0-416b-8c7f-9d92c0aa53be", 0, "e0f710db-58c1-4622-8d73-8cd933c660db", "visitor@gmail.com", true, false, null, "VISITOR@GMAIL.COM", "VISITOR@GMAIL.COM", "AQAAAAIAAYagAAAAEEuIhGOnMZf4eL/st7TZ0EoNwMT5SjprRQTtt52GwLCLELM+rCtZ44jVhweI8qR9pw==", null, false, "d36eca23-dbe6-4d33-baa0-0f3c03d4984f", false, "visitor@gmail.com" },
                    { "1937a86c-7e25-423f-9bd5-a9a9ff5cdb01", 0, "71782da8-d789-4f1b-bdab-15ee199789f6", "alejandro.garcia@gmail.com", true, false, null, "ALEJANDRO.GARCIA@GMAIL.COM", "ALEJANDRO.GARCIA@GMAIL.COM", "AQAAAAIAAYagAAAAEG2n/Dc0FbeKmI11+FCoK/Z1eM7A2UF/KGbsx9Vh1OehAF86LzUuSiQcGS+rxU9BhQ==", null, false, "c8644fc5-e4b1-4bc6-a0eb-028ad22027bf", false, "alejandro.garcia@gmail.com" },
                    { "222ae258-aaa1-432b-b927-fdece15cee01", 0, "b97c512c-6b99-4b8d-a865-8163348c50c0", "laura.martinez@gmail.com", true, false, null, "LAURA.MARTINEZ@GMAIL.COM", "LAURA.MARTINEZ@GMAIL.COM", "AQAAAAIAAYagAAAAEEInDTeHxVJpzWZ0ofTbIwLjh3Nsu19soEQfphhZPY4KG8xvS8XyBR4UNyr6DGuieQ==", null, false, "7423f079-f90e-47cd-94a0-1f54be1096be", false, "laura.martinez@gmail.com" },
                    { "3d87b147-b53f-47fb-887e-242b0695ffad", 0, "fb5693df-d36e-45ba-a146-b1d60b215ce6", "sofia.torres@gmail.com", true, false, null, "SOFIA.TORRES@GMAIL.COM", "SOFIA.TORRES@GMAIL.COM", "AQAAAAIAAYagAAAAEFEUsdgB2Qg7ipGmLHctyrO5jLYXZI8Os6zIAok6LMmnYqnEc7ruFou6/XfJhzU1+w==", null, false, "4d9bd862-c3be-453a-baf9-5e3592564884", false, "sofia.torres@gmail.com" },
                    { "3f134502-f5da-4e85-89d7-b28ed9e693e3", 0, "44a37c45-2966-49cd-b9ed-c604179d72ad", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEBWFFtmhCVgAUq2Tat5Gzhlr1VWpyRvcR3WPlSvw4s1N0ogj4uAyIqEkZPu5QO4X+Q==", null, false, "895849b0-f8f0-42f1-8f61-8fd736c2be21", false, "admin@gmail.com" },
                    { "d18c5703-20cc-4c99-970b-06be0956f4a5", 0, "812afb2d-0e2d-4556-8988-e0ef7cc0fee4", "mariana.lopez@gmail.com", true, false, null, "MARIANA.LOPEZ@GMAIL.COM", "MARIANA.LOPEZ@GMAIL.COM", "AQAAAAIAAYagAAAAED0P6GqOz2ppcCkuR11w4TaKWR0Bhq75fqULelHw3cMOVWj+2MTuRnYD/Rq+YFkT8g==", null, false, "c095c088-90fc-4821-b2e7-67c696a6f9d2", false, "mariana.lopez@gmail.com" },
                    { "ff292857-9770-4483-9bd1-9a2ab3ebaf8a", 0, "3424eacf-a567-40c8-be34-015b4c42e2ce", "juan.perez@gmail.com", true, false, null, "JUAN.PEREZ@GMAIL.COM", "JUAN.PEREZ@GMAIL.COM", "AQAAAAIAAYagAAAAEGtqRDiJIdVFvbrZKBB/PIowO12Ghkiyev4BAdVoJ799PiyjA+CjQl1i4HIrLr/5Vg==", null, false, "d3d4286b-1af2-4ad4-84a4-c4d24601b891", false, "juan.perez@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "00aa858c-17df-4921-bbfb-93032ec29619", "0ada4ee7-f3f0-416b-8c7f-9d92c0aa53be" },
                    { "6c454d9b-a883-4b54-8a87-e0ffd5b3f4d1", "1937a86c-7e25-423f-9bd5-a9a9ff5cdb01" },
                    { "4bbff256-c063-4b0e-90f0-f8a02b10da0d", "222ae258-aaa1-432b-b927-fdece15cee01" },
                    { "4bbff256-c063-4b0e-90f0-f8a02b10da0d", "3d87b147-b53f-47fb-887e-242b0695ffad" },
                    { "c3402e44-96b4-4dbb-ac18-63842e5d89b6", "3f134502-f5da-4e85-89d7-b28ed9e693e3" },
                    { "6c454d9b-a883-4b54-8a87-e0ffd5b3f4d1", "d18c5703-20cc-4c99-970b-06be0956f4a5" },
                    { "4bbff256-c063-4b0e-90f0-f8a02b10da0d", "ff292857-9770-4483-9bd1-9a2ab3ebaf8a" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Groups_GroupID",
                table: "Enrollments",
                column: "GroupID",
                principalTable: "Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Swimmers_SwimmerID",
                table: "Enrollments",
                column: "SwimmerID",
                principalTable: "Swimmers",
                principalColumn: "SwimmerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
