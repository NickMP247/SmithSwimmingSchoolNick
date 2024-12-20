using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmithSwimmingSchool_NickMorales.Data.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
