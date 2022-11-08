using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class UpdateOfferTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductOffers_Offers_OffersId",
                table: "ProductOffers");

            migrationBuilder.DropIndex(
                name: "IX_ProductOffers_OffersId",
                table: "ProductOffers");

            migrationBuilder.DropColumn(
                name: "OffersId",
                table: "ProductOffers");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "OffersId",
                table: "ProductOffers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                column: "ConcurrencyStamp",
                value: "8b390815-b999-4e50-a721-4c5f1c9505b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "2710619c-d6f9-4c73-b5ed-0760e1b45c1a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "d6ed99a0-c43a-4330-85a1-18c2bdc7f735");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24129f91-10ab-44fb-8e4f-e096b55fab5d", "AQAAAAEAACcQAAAAEF2UE6+XpK0PuAHmxVn3WuZnIwzGUS+tUNBxW47YXmnr0U/OAtSMlCnyrBEVcyocjg==", "c76e5a8a-9b92-4735-a642-0889b4526b2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e2d692d-5ad2-4616-950f-f1a9b2672fec", "AQAAAAEAACcQAAAAEBwN9o4XBjSGvTQIrBK5K5b0iZQB+vR6oB7fyobcBQl9r5UWfRJbTxSPh3fS9IgZkg==", "ea95590a-1a87-4964-9288-e91d689529ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b9c9d38-0d5d-460c-936f-26bac836d4f5", "AQAAAAEAACcQAAAAEDyz0a+NoLxNYLBw4RULg8QLcYB5rdR4SJAujGjNmfttvOVJXYtNXXqmwQZakIKbrQ==", "7f7cd98f-9fa4-498e-8a2f-e9455a9e0f8c" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductOffers_OffersId",
                table: "ProductOffers",
                column: "OffersId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOffers_Offers_OffersId",
                table: "ProductOffers",
                column: "OffersId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
