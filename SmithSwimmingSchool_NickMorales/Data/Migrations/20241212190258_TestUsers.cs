using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmithSwimmingSchool_NickMorales.Data.Migrations
{
    /// <inheritdoc />
    public partial class TestUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "097e276d-7d78-48b5-b3d0-9a07c6aeb35d", "1ed1d03e-6b9e-420f-8492-0075abbfc3bb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3b1c8c46-6304-4b64-af2d-4381b18ebfa5", "4d53553c-0ad2-4f57-ae29-108bad5883f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dcd697b6-ebab-4e74-bb23-447858017148", "5952b77d-a43e-4abe-a9a0-e84bcb52096c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5965d0a4-6cc0-4b4e-aa28-d1ded18f6e57", "59c40ef0-9d33-4a49-84cd-6d473613ee11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dcd697b6-ebab-4e74-bb23-447858017148", "73372ad9-f5a1-419d-ae2f-4e61da842712" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5965d0a4-6cc0-4b4e-aa28-d1ded18f6e57", "90d6b798-e33c-4036-985b-9776e3c54efc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5965d0a4-6cc0-4b4e-aa28-d1ded18f6e57", "f9fe425b-ea46-4e90-b46e-73dca5ef21b7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "097e276d-7d78-48b5-b3d0-9a07c6aeb35d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b1c8c46-6304-4b64-af2d-4381b18ebfa5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5965d0a4-6cc0-4b4e-aa28-d1ded18f6e57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcd697b6-ebab-4e74-bb23-447858017148");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ed1d03e-6b9e-420f-8492-0075abbfc3bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d53553c-0ad2-4f57-ae29-108bad5883f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5952b77d-a43e-4abe-a9a0-e84bcb52096c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59c40ef0-9d33-4a49-84cd-6d473613ee11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73372ad9-f5a1-419d-ae2f-4e61da842712");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90d6b798-e33c-4036-985b-9776e3c54efc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9fe425b-ea46-4e90-b46e-73dca5ef21b7");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "097e276d-7d78-48b5-b3d0-9a07c6aeb35d", null, "Administrator", "ADMINISTRATOR" },
                    { "3b1c8c46-6304-4b64-af2d-4381b18ebfa5", null, "Visitor", "VISITOR" },
                    { "5965d0a4-6cc0-4b4e-aa28-d1ded18f6e57", null, "Swimmer", "SWIMMER" },
                    { "dcd697b6-ebab-4e74-bb23-447858017148", null, "Coach", "COACH" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1ed1d03e-6b9e-420f-8492-0075abbfc3bb", 0, "0ecd89c8-6bdf-4477-8f7c-27f4a03ef0be", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", null, "AQAAAAIAAYagAAAAEG8u4vsQabkEMOIuGtVgJ1el1k5SmzJyBhfV8rVXIspjjoyQ3QTSeSX8Tyo5jId4oA==", null, false, "b212c6bc-7e8c-457b-ba3e-94262b261c39", false, "admin@gmail.com" },
                    { "4d53553c-0ad2-4f57-ae29-108bad5883f7", 0, "e9b6f363-3d43-455a-a980-cd4b296d92f3", "visitor@gmail.com", true, false, null, "VISITOR@GMAIL.COM", null, "AQAAAAIAAYagAAAAENoFORTfAtRx5mqL59VR4KZr+31dA0fpYMDgUftFSzMAaS6WgafGxsCdbAk/TgsfBg==", null, false, "f76c2e6a-dc57-40e6-aa67-d75fa03197f9", false, "visitor@gmail.com" },
                    { "5952b77d-a43e-4abe-a9a0-e84bcb52096c", 0, "91018d09-fb20-4f2a-a2c6-18f824af956f", "alejandro.garcia@gmail.com", true, false, null, "ALEJANDRO.GARCIA@GMAIL.COM", null, "AQAAAAIAAYagAAAAEGBoUKR/uiJy0R2NL2fu0EXPLgkMV7+MmokleU0KrxfcMJzZmz/wNIFimQvCrTI72A==", null, false, "2688b06b-2456-4977-99b5-d783337be6e1", false, "alejandro.garcia@gmail.com" },
                    { "59c40ef0-9d33-4a49-84cd-6d473613ee11", 0, "4995676a-4b72-44c8-88fb-651fb3ba91be", "juan.perez@gmail.com", true, false, null, "JUAN.PEREZ@GMAIL.COM", null, "AQAAAAIAAYagAAAAEA94sg29Di/Wikrc1BQKLzKDNNB2b16qZyYrs9XcDTpPde+kA68uzzjOsLujI/AUow==", null, false, "e19cbbc7-5158-458e-aed9-3535b62d7494", false, "juan.perez@gmail.com" },
                    { "73372ad9-f5a1-419d-ae2f-4e61da842712", 0, "819bbd7f-c321-47b2-bdb0-3eb7be5d59cb", "mariana.lopez@gmail.com", true, false, null, "MARIANA.LOPEZ@GMAIL.COM", null, "AQAAAAIAAYagAAAAEMKr8A8/GD9ee5vYjYCDHXfb26aRyXfB27F0/Txx9vWrRX1XUu43XqLCFIwlmOlJZA==", null, false, "1c2c0191-acc8-47a4-b315-b343663c1276", false, "mariana.lopez@gmail.com" },
                    { "90d6b798-e33c-4036-985b-9776e3c54efc", 0, "da6df121-a6f3-47cf-8e48-22dde49e990f", "sofia.torres@gmail.com", true, false, null, "SOFIA.TORRES@GMAIL.COM", null, "AQAAAAIAAYagAAAAEI/0AQiIKvyWFuUQtl2r9O1Pf6OFQZFB21AIW7po7kssm0oANDupZq2/pJx5NdjSRA==", null, false, "970cac82-250a-4885-80cf-7ddc59f912bb", false, "sofia.torres@gmail.com" },
                    { "f9fe425b-ea46-4e90-b46e-73dca5ef21b7", 0, "6dc2365a-fdc1-4751-963e-c62ba97a81a9", "laura.martinez@gmail.com", true, false, null, "LAURA.MARTINEZ@GMAIL.COM", null, "AQAAAAIAAYagAAAAEEWyojQZOhd7hwKSTMIjUlc1JA8YwS+bZj6NyDmJ9W6/e1eDFE10rGvG97YVtzzroQ==", null, false, "2a813c7c-0b09-4b4d-b3b0-6653be9012af", false, "laura.martinez@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "097e276d-7d78-48b5-b3d0-9a07c6aeb35d", "1ed1d03e-6b9e-420f-8492-0075abbfc3bb" },
                    { "3b1c8c46-6304-4b64-af2d-4381b18ebfa5", "4d53553c-0ad2-4f57-ae29-108bad5883f7" },
                    { "dcd697b6-ebab-4e74-bb23-447858017148", "5952b77d-a43e-4abe-a9a0-e84bcb52096c" },
                    { "5965d0a4-6cc0-4b4e-aa28-d1ded18f6e57", "59c40ef0-9d33-4a49-84cd-6d473613ee11" },
                    { "dcd697b6-ebab-4e74-bb23-447858017148", "73372ad9-f5a1-419d-ae2f-4e61da842712" },
                    { "5965d0a4-6cc0-4b4e-aa28-d1ded18f6e57", "90d6b798-e33c-4036-985b-9776e3c54efc" },
                    { "5965d0a4-6cc0-4b4e-aa28-d1ded18f6e57", "f9fe425b-ea46-4e90-b46e-73dca5ef21b7" }
                });
        }
    }
}
