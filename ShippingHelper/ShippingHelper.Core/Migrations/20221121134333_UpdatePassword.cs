using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class UpdatePassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f71694-8d9d-4c9e-9698-4ebaad596253",
                column: "ConcurrencyStamp",
                value: "17dd2878-5a9b-4ac9-82ca-adda9a3c01b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                column: "ConcurrencyStamp",
                value: "818916c4-b58c-4697-95bf-91cd8ff60242");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                column: "ConcurrencyStamp",
                value: "ca75c8af-1645-4963-a386-cce5bb4f7534");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4b0832d-5e47-4bc0-ad80-5fae3741d2e5", "AQAAAAEAACcQAAAAEMCQWjJe3z2llb/S+xMdU7i/TXDBeLoMiJiHJpLz86aQXYb6Q05KBX1MwKBulsSKfw==", "e7a2139a-779f-4b54-a866-1092bdd69266" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aff4aa11-e2b9-45d6-9651-2b852cf6062d", "AQAAAAEAACcQAAAAEGUgwE1meEw+jF4R/FCxbW/zpkXVG7KYtERBVm6ONzU+7IqD/LQtYOaoj3zGHGjBHw==", "0ff22b0b-13e1-4710-83df-42ad567b5ccb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38f6cd81-00fa-4e2d-a072-00a18fdbd105", "AQAAAAEAACcQAAAAEN2X5N8yJ3tHuxQMwsdlp6nbPd9uW2fY1BYqVjgqTvkE8RLsu1VXgU7WzgUWKFS/1g==", "3ebbaf54-3347-4acf-93d4-c85c63126db0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
