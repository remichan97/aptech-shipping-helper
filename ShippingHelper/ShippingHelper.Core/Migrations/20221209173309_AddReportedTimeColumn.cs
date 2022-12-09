using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class AddReportedTimeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReportTime",
                table: "ReportedMerchants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                column: "ConcurrencyStamp",
                value: "b7c75226-56c7-41ec-9adc-976d0fd20209");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "89b890ce-ff6e-44b3-8cd3-b83310330b3f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "f7f718ef-3f79-4e17-b0bc-55e408f08276");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bc278de-05c0-48de-9146-2ac9298f2060", "AQAAAAEAACcQAAAAENC9n+8AgFgwnGNZBqR9SuoX0CyuFyoKgsGbWjogvlv5RJf++Zq+oEA/5NpWoguWUQ==", "279e06cf-7378-41e3-8261-42c60b8811ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbccdbe2-3e44-4b82-917f-8a5f02024e57", "AQAAAAEAACcQAAAAEMqfO6oe23hWGHQ7LUMjHNY3wCmqhvrwI3/1+mVE388gxNl2LmCF+V3lTEq176JVLA==", "c19b1d95-e317-43f7-9081-b902977fcdac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b731d07a-74e8-4b47-bc20-a478b0a1353f", "AQAAAAEAACcQAAAAEAYwubejyWuQArcwgZRqrmSmb8+ECAEFFRfxRxBWxH7YE2azMJkgdk6fGSP1BfhOew==", "22b3c371-80f2-406f-b06e-5d58b38357b4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportTime",
                table: "ReportedMerchants");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                column: "ConcurrencyStamp",
                value: "1a8b51cb-2953-414b-afad-e270460eeb0d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "136d9722-be52-45a2-be06-b4b38e573593");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "c9583bcb-690b-4aa2-9613-f97428af6600");

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
    }
}
