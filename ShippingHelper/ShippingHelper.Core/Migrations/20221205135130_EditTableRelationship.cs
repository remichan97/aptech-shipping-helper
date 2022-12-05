using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class EditTableRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                value: "20648e55-871f-42c1-b08f-202092242e76");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "37c333b8-5e6a-4763-98f1-99270cfb6d76");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "fe53cafc-1002-4eb5-94f2-e948af31a54f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9da6c4a9-c8e4-4f3c-b6c0-3cd3c1fe679e", "AQAAAAEAACcQAAAAEPtqsSrBeebfEw+p44exgCyIbFaI0oo7ZcjWEpqMyIm/NpWKbYe8uR38zijQZzcU1w==", "47072564-b0de-4df2-aa62-df7d56a99f6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a22a92e0-5f49-4748-9e86-0aeae011ff93", "AQAAAAEAACcQAAAAEATTN8JTsaAUX0Th915LwY9Ws3QwP8bO5tclmfkSqG+dBuMOq9Cw/xuSJHMPGNHFhg==", "c0331836-e676-483c-8ba2-f76ad549cab1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82bd1c7a-55bd-4e3c-985a-966cbc5e4489", "AQAAAAEAACcQAAAAEHTKOyuDgOAOBLiUIspDPH8d+TZv4mImEnVYzjlzwZ7mmT6S+3nBvHgoT/04Zuvcbw==", "253a4629-02dc-4e23-afc2-e1113d3ed6a9" });

            migrationBuilder.CreateIndex(
                name: "IX_Offers_ProductOfferId",
                table: "Offers",
                column: "ProductOfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_ProductOffers_ProductOfferId",
                table: "Offers",
                column: "ProductOfferId",
                principalTable: "ProductOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                column: "ConcurrencyStamp",
                value: "60956298-f703-461d-a7b1-db7ad1726a2b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "fd34513b-4651-4cb1-80b9-41d648c47590");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "4a42f8aa-dc2c-4cf8-830c-3ce565c1e26e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47c0691e-f89c-4e97-b500-8addea737eab", "AQAAAAEAACcQAAAAEBExecLDd+Aj2iH1q0TRtea7pSIFK+r4oY1163CCIs9enEbR4Vv0pKRNvWNuHT5VDw==", "c7ce3fa0-f2eb-4d9c-9c76-8c5d01af658d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05409414-6d4d-495c-8e5b-8d15f9080288", "AQAAAAEAACcQAAAAECGjtQMwkLJIL/26znOu6oyGLWepwGArB1tL0zD6xkyoTcBT+j9mDjArnAhD0L9RYw==", "de29def9-32bc-4852-b434-e610a0b4b2c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e12d369c-0fdc-437b-a1a3-28d585bdbbff", "AQAAAAEAACcQAAAAEGemTM4iWLEJgmxnnws1y3FMyFcqXjVZkWtM+y3WuS9P8xwv0ChyRU5tgVy8y5sJTA==", "7661e4f0-2eeb-41e6-a571-c2a219b0d686" });
        }
    }
}
