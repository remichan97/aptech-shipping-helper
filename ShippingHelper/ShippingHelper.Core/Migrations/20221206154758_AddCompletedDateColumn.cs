using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class AddCompletedDateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedDate",
                table: "Offers",
                type: "datetime2",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6941dab-c939-4cbf-a764-e723a8b79e2b", "AQAAAAEAACcQAAAAEO9fppPTkQviFRnWqa0kfyansY0K5GdK6Bcmtab8pkrW/nttJVWCzsEFYFuvYBxrcg==", "1f11d6d5-7d38-4751-8a50-178a47f2d6c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81edc977-efbf-49d2-9426-b25999da6fff", "AQAAAAEAACcQAAAAEORuwmn0qf2Ds3wYHZMic2YOEStEgc+z3t2dtKazpvFTsv5ZeKnB+zvwJBL2bPs2LA==", "0bedab8e-9560-4efa-9bda-c5f32ba644a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80503b03-ae0f-4081-b79f-90debbce479c", "AQAAAAEAACcQAAAAEFRy8YPTA6UZm3VOGmsOwID2eFXTfw3YbB/SoFshki+ORiJoxK8R3o4YU83MTFDFRg==", "5f5cfeea-017b-4749-8c8f-7078b14940bf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedDate",
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
        }
    }
}
