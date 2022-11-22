using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class UpdateOfferTableAddCityNav : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55f4abdb-44b2-42e3-8344-5872513895f1", "AQAAAAEAACcQAAAAEIzJLdqhQolBVUj8eYzgnbd5cTk8AC8l5l4dNEUr9Jj90yCB71w3JTN8j75+nA2UKQ==", "15e37933-7d94-4708-9944-aaeeee09c0ac" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CityId",
                table: "Offers",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Cities_CityId",
                table: "Offers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Cities_CityId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_CityId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Offers");

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
    }
}
