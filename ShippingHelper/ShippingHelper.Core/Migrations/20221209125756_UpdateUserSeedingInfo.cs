using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class UpdateUserSeedingInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                column: "ConcurrencyStamp",
                value: "e40820be-413e-43f7-b46a-e0f226a71b41");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "089ad0a5-84af-4ebb-ac18-22afcb87999e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "cef353b8-a66d-4464-8db5-5e147067e6bb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "1ae8fbf6-5814-4538-982b-d63cdf71a6d9", "AQAAAAEAACcQAAAAEOdk50xf4G0NjiqSwaNUFWR/PTRmvAIIwxCH4glSWPygiwJjOMNYN0eZtgBgES3FFw==", "1234567890", "abe1024a-45ef-4410-b039-6301dee11bca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "83ecf648-d4a8-4265-8f6b-18263c3220f2", "AQAAAAEAACcQAAAAEHD7bobtbvgef1hc4gTrGCAp1FC+N2Rtv7J43ir/aMgn/e0QXH55jd/o89sKcc24ZA==", "1234567890", "dc5c0b5c-bf8b-4b81-a8a0-7fb12fc26850" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "86b1ce21-0ca2-4881-a5d6-e0569d82d36d", "AQAAAAEAACcQAAAAEMWz57OxIwqLFsIVrAYomHyEjpN3BefyRbnyHHS7RvKiNkF6xM7DFJVmDO2R9vWjhg==", "1234567890", "084e3f5d-7a0a-491a-9b1c-9b01d5a01c30" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                column: "ConcurrencyStamp",
                value: "9480b292-cb15-4e8f-bedc-dc9307edad0e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "74ae0904-c774-48b4-bd54-6096062e48bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "f7067431-17f4-4ffc-8027-15034ff4f700");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "d6941dab-c939-4cbf-a764-e723a8b79e2b", "AQAAAAEAACcQAAAAEO9fppPTkQviFRnWqa0kfyansY0K5GdK6Bcmtab8pkrW/nttJVWCzsEFYFuvYBxrcg==", null, "1f11d6d5-7d38-4751-8a50-178a47f2d6c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "81edc977-efbf-49d2-9426-b25999da6fff", "AQAAAAEAACcQAAAAEORuwmn0qf2Ds3wYHZMic2YOEStEgc+z3t2dtKazpvFTsv5ZeKnB+zvwJBL2bPs2LA==", null, "0bedab8e-9560-4efa-9bda-c5f32ba644a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "80503b03-ae0f-4081-b79f-90debbce479c", "AQAAAAEAACcQAAAAEFRy8YPTA6UZm3VOGmsOwID2eFXTfw3YbB/SoFshki+ORiJoxK8R3o4YU83MTFDFRg==", null, "5f5cfeea-017b-4749-8c8f-7078b14940bf" });
        }
    }
}
