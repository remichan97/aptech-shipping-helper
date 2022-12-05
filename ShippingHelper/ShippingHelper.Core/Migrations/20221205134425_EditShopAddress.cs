using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class EditShopAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Address", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "189 Thanh Nhan, Hai Ba Trung", "47c0691e-f89c-4e97-b500-8addea737eab", "AQAAAAEAACcQAAAAEBExecLDd+Aj2iH1q0TRtea7pSIFK+r4oY1163CCIs9enEbR4Vv0pKRNvWNuHT5VDw==", "c7ce3fa0-f2eb-4d9c-9c76-8c5d01af658d" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                column: "ConcurrencyStamp",
                value: "dee9a8b6-639b-4f97-9a0e-0f7db7156be2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "ca060360-351a-47ed-86eb-6ee2663cc395");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "0756fbf3-232d-409d-a1e5-10416d009b79");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "Address", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "Shop Address", "55f4abdb-44b2-42e3-8344-5872513895f1", "AQAAAAEAACcQAAAAEIzJLdqhQolBVUj8eYzgnbd5cTk8AC8l5l4dNEUr9Jj90yCB71w3JTN8j75+nA2UKQ==", "15e37933-7d94-4708-9944-aaeeee09c0ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ddce9f9-3e68-4d4d-80bb-75c502ae784d", "AQAAAAEAACcQAAAAEPxP0IkafqFvBrTg6ukA4TnZBkZrJV3qnK3yl9LIe08GPe6qTjcBlLiJXh72GezOgA==", "554726af-3c56-410a-9711-bd4d91e28b47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7c0e74b-3f5d-43f0-85f4-f7529b99558e", "AQAAAAEAACcQAAAAEKi7dHMx099Dtxc2DRTyrgB3zQD4qP5CeKNV9swHXzTyranziMgq0xBF71nmNq4mDg==", "4b661bf7-b3e7-41fc-9a7d-504268653e22" });
        }
    }
}
