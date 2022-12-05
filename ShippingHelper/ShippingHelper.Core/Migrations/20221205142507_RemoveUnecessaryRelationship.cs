using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class RemoveUnecessaryRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_ProductOffers_ProductOfferId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_ProductOffers_OfferId",
                table: "ProductOffers");

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
                value: "06fcbfcd-a31e-4c09-a09a-c6590d5e6aac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "e16c88f2-4245-4d04-9c26-af6f994a132f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "5de05113-0992-40b5-9f2a-f82b38281ed2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80368a68-6071-4d98-a374-dfe8cdf58cfc", "AQAAAAEAACcQAAAAEJFc9uDh+ehJ5GUQTr4Ewr6wdnfcvgewE6JFexNFweBVbVrACGdwfzo+eHW2VB2m9Q==", "95fee4be-1b02-4f91-8be6-7466ada71c44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "700991aa-9fab-4d98-b542-11b06af53459", "AQAAAAEAACcQAAAAEJcuwDg5vzoMYjMKsimgnDnEBl4lbTB2l9s9EUiB92jWdAQFEP/2/L7e/A8+MAsx4w==", "11831853-c983-4f78-a620-f2b1c4a4ca5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1830ce3a-259f-4cca-b8d6-2c254495cb6b", "AQAAAAEAACcQAAAAEGCoR9No03KBtBjokd8d06RWzt47oAPct0TqaRQa88V97qkrlCLIEG//XyR75mlSSA==", "cb1032d2-4b00-4328-a213-3007c61f9d13" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductOffers_OfferId",
                table: "ProductOffers",
                column: "OfferId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductOffers_OfferId",
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
                name: "IX_ProductOffers_OfferId",
                table: "ProductOffers",
                column: "OfferId");

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
