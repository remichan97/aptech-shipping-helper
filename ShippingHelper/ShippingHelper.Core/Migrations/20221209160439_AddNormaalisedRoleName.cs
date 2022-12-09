using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class AddNormaalisedRoleName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "1a8b51cb-2953-414b-afad-e270460eeb0d", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "136d9722-be52-45a2-be06-b4b38e573593", "SHIPPING MERCHANT" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "c9583bcb-690b-4aa2-9613-f97428af6600", "SHOP MERCHANT" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0eb848cf-376c-4727-9b85-6433f4b954bf", "AQAAAAEAACcQAAAAENlOlFxYGE3ax6HUf2LfVsSy67eFO4WoXwPdI6nRI45tOFDgt7io6kh5SDZcNdIXzQ==", "264b8c85-58be-47b1-9d72-3cc0bbf18b7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9049ec6e-3614-4d84-89ff-5226fb607d35", "AQAAAAEAACcQAAAAEBonS32f0tv5B1l9k4XJAXJbYaPHO9zeSyeq4H3GmJz0Dc8ABkSWKGdbq0BM3Cj66A==", "59512c64-02bf-4767-a1a7-e71dd927be64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed145e48-9e8a-45a6-bade-7f25e8f654fa", "AQAAAAEAACcQAAAAEIspqCuwvf08xbfWMDTUTN2teCvVsaYNHdaXxEmGx+Ccj0WRt3FPW1k4tKkDnUpq4Q==", "ab8d99dc-295c-4377-a88a-0a200ef96e93" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "e40820be-413e-43f7-b46a-e0f226a71b41", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "089ad0a5-84af-4ebb-ac18-22afcb87999e", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "cef353b8-a66d-4464-8db5-5e147067e6bb", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ae8fbf6-5814-4538-982b-d63cdf71a6d9", "AQAAAAEAACcQAAAAEOdk50xf4G0NjiqSwaNUFWR/PTRmvAIIwxCH4glSWPygiwJjOMNYN0eZtgBgES3FFw==", "abe1024a-45ef-4410-b039-6301dee11bca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83ecf648-d4a8-4265-8f6b-18263c3220f2", "AQAAAAEAACcQAAAAEHD7bobtbvgef1hc4gTrGCAp1FC+N2Rtv7J43ir/aMgn/e0QXH55jd/o89sKcc24ZA==", "dc5c0b5c-bf8b-4b81-a8a0-7fb12fc26850" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86b1ce21-0ca2-4881-a5d6-e0569d82d36d", "AQAAAAEAACcQAAAAEMWz57OxIwqLFsIVrAYomHyEjpN3BefyRbnyHHS7RvKiNkF6xM7DFJVmDO2R9vWjhg==", "084e3f5d-7a0a-491a-9b1c-9b01d5a01c30" });
        }
    }
}
