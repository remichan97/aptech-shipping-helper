using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class ModifyContactsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Contacts",
                newName: "Subjects");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                column: "ConcurrencyStamp",
                value: "fb69a582-07de-4dc2-899e-855d66733147");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "0581e6f7-30e9-429a-8bf8-0c63645bd16e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "15b21741-2944-40ee-a417-21827a81bab2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9612a116-7ec2-487f-83a6-2d2e75f335ac", "AQAAAAEAACcQAAAAEEwAwlLKwXvrdMoPFvEkPX79awodjv0+E3cKbL3Ofz9ltew3/sqajrlsAB4c2PkJ6Q==", "1e7f7cd0-cd2b-4dcd-8117-46bd61fae0ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e67b8798-e1e1-4fed-9ca8-4af325ac1a18", "AQAAAAEAACcQAAAAEPBjMUOSaSpcIQFXMv/Gg3V0zeFB6qlZ8Fy89N1XljAC0GZw5IQjW4//HNoZFabyWA==", "0b420a80-8c63-4aa8-aa90-b1da641a1c76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe3968ee-8904-4e52-ba07-cf1c7ce88ec5", "AQAAAAEAACcQAAAAEH25NNZK3LsFeTK1TRNpmRz2tzMt+c1pqzrF/4Sdp/JtFw8r6Mm+Ubsu6pWsz6Ompw==", "1de0c04f-8ace-4aeb-ad19-135e31256abf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subjects",
                table: "Contacts",
                newName: "PhoneNumber");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                column: "ConcurrencyStamp",
                value: "1fc372c0-88bb-4da1-ab91-32dfab103865");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "acb28e58-4e17-4015-92e1-2c82dfd576be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "94415fd8-3c83-422e-a198-2e084b9c8455");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7879b98-419a-41fc-a07f-0a541fc9d99a", "AQAAAAEAACcQAAAAEFUdLHJFJIvUaxe+koHivsaxCq/N4Rtmj1PQiygY59JSRABDqalGZCuoGJm+vrGxTQ==", "43986949-f49f-4301-ba07-a9384a464bbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45182127-4e49-476b-94f9-ba5fd7ec5a5e", "AQAAAAEAACcQAAAAEHY8cf14XaI2qI7olIFqugGiP7cEmuMifDSXFe13EQea/oODJhaxp9N17aw0RAnqHw==", "e5fb6133-1550-472a-b7aa-4bcfb06fcf73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7d9aabe-e5bd-4cdb-ac29-4afe92d24ed5", "AQAAAAEAACcQAAAAEAt1+Sin+r/T79jqjHQunzVddjptj+mGrbqAkMWDqNi/Z9rvoW53PutQSHFPvfdg+g==", "495a2437-dbd4-4bc6-877d-f17c46ceee3f" });
        }
    }
}
