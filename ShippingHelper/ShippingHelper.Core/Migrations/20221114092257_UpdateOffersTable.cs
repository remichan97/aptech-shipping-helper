using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class UpdateOffersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_ProductOffers_ProductOfferId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_ProductOfferId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "ProductOfferId",
                table: "Offers");

            migrationBuilder.AddColumn<Guid>(
                name: "OfferId",
                table: "ProductOffers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "PostedDate",
                table: "Offers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                column: "ConcurrencyStamp",
                value: "405d8507-20a0-41db-a3bb-39e884eaf1c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "b8a6fa59-f7a4-4e0e-8ad0-a34b8a7e9892");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "3aff1379-f90d-442e-b03d-2cec936b7056");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a18fd417-a493-488b-8c52-8685e36ed031", "AQAAAAEAACcQAAAAENyhvBrAhZbqIxJ017da/RHyy6TBH0eKXyxchuEa4YmFWdtCnXxN2VkpYPOYLJ8YlQ==", "88ce1722-fb14-4d67-9409-ddfcacf28091" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54e68786-3d0c-4fa0-a0b4-555f63f9308e", "AQAAAAEAACcQAAAAEEdgotAvM1JIpgDFru7h3YeTu1hcakk9OSNop6Tji8Zpu2hzfPLiheTZF4dLsjH7gg==", "14190679-7a6c-478c-aad4-a4b605de7c6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca2363e1-dc5e-436e-97d9-3f8762e30c9d", "AQAAAAEAACcQAAAAEO1XYySKfKWulWIFoXPYVE3AEUTlgz9WDdGbq6Dh7doq2qpMK4zomUW/PsBLqewRSQ==", "a05fd8b3-b493-4fc6-875b-15a252be0e89" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductOffers_OfferId",
                table: "ProductOffers",
                column: "OfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOffers_Offers_OfferId",
                table: "ProductOffers",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductOffers_Offers_OfferId",
                table: "ProductOffers");

            migrationBuilder.DropIndex(
                name: "IX_ProductOffers_OfferId",
                table: "ProductOffers");

            migrationBuilder.DropColumn(
                name: "OfferId",
                table: "ProductOffers");

            migrationBuilder.DropColumn(
                name: "PostedDate",
                table: "Offers");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductOfferId",
                table: "Offers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "IX_Offers_ProductOfferId",
                table: "Offers",
                column: "ProductOfferId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_ProductOffers_ProductOfferId",
                table: "Offers",
                column: "ProductOfferId",
                principalTable: "ProductOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
