using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class AddReportedUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportedMerchants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReportType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportedMerchants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportedMerchants_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                column: "ConcurrencyStamp",
                value: "7fff907b-a040-47d0-a720-04c655d59744");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "357cf25b-4389-4e71-9169-0b9b36d0c7d2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "01631388-60a5-4f04-90ee-33bd828705c8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8533c265-2e30-444d-99da-dfe7490cf386", "AQAAAAEAACcQAAAAELx5bmAdaYh3FU7dki2Q39zbkSTj8PWCIolX9D93rccbWOlDAzqFSeEOpbs9dUlvhQ==", "8174b85c-8e4d-4d56-b249-11ccddc0fc2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fda092af-6836-444c-b0d5-847a99211ee3", "AQAAAAEAACcQAAAAEJCz6lzTvbSwE9PwcqK+ttVdU80CyoDlhyryqkzmcb5oZm7xo9DHlZMJgu9mv41LIg==", "b922a80f-7d1f-4cc0-ba7a-72d65208e098" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63affee8-a685-4a3a-83c4-bddc278985ca", "AQAAAAEAACcQAAAAEN2DOsWiR/pT7fAhz3+JD03Zg8yNFZsNqP8aRWvWVENMI3VamHs3tYcugU9e/zzuVg==", "a8cd5a2d-1cc7-454a-9b73-890ed42b6a89" });

            migrationBuilder.CreateIndex(
                name: "IX_ReportedMerchants_UserId",
                table: "ReportedMerchants",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportedMerchants");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                column: "ConcurrencyStamp",
                value: "68bf7729-6006-4db7-b7a0-ff277c70665e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "53abe091-1fe3-4aa5-b267-f53002740205");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "1bb76eda-49bb-402f-a09c-e4b306b43b97");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25bff26f-6182-411c-abc8-ac419ff0f7b9", "AQAAAAEAACcQAAAAEHJ8Pc8QB0BvamCow8E0XuTivYgFcgCoFsZHcQeckT9qjcyApwSOXwrhCP47It6s5Q==", "7cd8659c-37b8-495a-b1e0-9ee540628ea3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b97b776-1539-4903-a4a4-7cf172a65d38", "AQAAAAEAACcQAAAAEB/yzwx+u+ref3yadxnGUmLyAjyJiccXqZ6vEttQ8ngkcig4WWQzFwN3yYYRbqMBxA==", "de84697f-dcdd-4f4e-8b4b-b07ebde3cffb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23a2fe26-4f94-41e5-9e0a-07d109e65219", "AQAAAAEAACcQAAAAENiX2OXSSFOiiBSP7POYG5kSOgEYbD1Gq5/w6DQ3HH3WXNBpqrZeHebkcmHYkFeRRw==", "befbd04e-1fab-4101-ba75-a9bba0b8184c" });
        }
    }
}
