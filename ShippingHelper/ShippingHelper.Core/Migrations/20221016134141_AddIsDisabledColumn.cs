using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class AddIsDisabledColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDisabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: true,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDisabled",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                column: "ConcurrencyStamp",
                value: "bb4e2db8-8408-429b-9427-e1a0ece6d767");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "479b252e-afcb-4746-95d5-6feeb98ff9eb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "e9d7129b-920a-4025-8f6e-a08839fb2bc3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7472087d-05c4-444c-8d42-4377baa248a7", "AQAAAAEAACcQAAAAEK1zAUwH+aazMOaO5+RR2Mn+Q0jsTn8MOvLdB9ogofW7eAwaQbKqENgsGWMj/Cmk3Q==", "34de8ff5-f73f-42c5-b4ab-cd8a3f90dff2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1800a19b-4344-419b-8057-fd90daed84ea", "AQAAAAEAACcQAAAAEIHyfozTsMJG91qY1sVctyp0Cz54J95jNV7Gteyzan6CKvlxMDDaTsYcosNsNkwv7w==", "b4aba5d5-54b5-437b-afdd-c3b420b79bab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7b82849-e91a-43da-b127-3ac815e7985c", "AQAAAAEAACcQAAAAENF03q96Vp0DFrmzt7JOPhFV4plj7wjEawyzCRcg/mgH+/0SCJppS0J6HbowQae7Ew==", "e38ad011-b150-44a4-ad81-e283e05b20b4" });
        }
    }
}
