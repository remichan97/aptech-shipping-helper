using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    public partial class AddCitiesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hồ Chí Minh" },
                    { 2, "Hà Nội" },
                    { 3, "Đà Nẵng" },
                    { 4, "Bình Dương" },
                    { 5, "Đồng Nai" },
                    { 6, "Khánh Hòa" },
                    { 7, "Hải Phòng" },
                    { 8, "Long An" },
                    { 9, "Quảng Nam" },
                    { 10, "Bà Rịa Vũng Tàu" },
                    { 11, "Đắk Lắk" },
                    { 12, "Cần Thơ" },
                    { 13, "Bình Thuận" },
                    { 14, "Lâm Đồng" },
                    { 15, "Thừa Thiên Huế" },
                    { 16, "Kiên Giang" },
                    { 17, "Bắc Ninh" },
                    { 18, "Quảng Ninh" },
                    { 19, "Thanh Hóa" },
                    { 20, "Nghệ An" },
                    { 21, "Hải Dương" },
                    { 22, "Gia Lai" },
                    { 23, "Bình Phước" },
                    { 24, "Hưng Yên" },
                    { 25, "Bình Định" },
                    { 26, "Tiền Giang" },
                    { 27, "Thái Bình" },
                    { 28, "Bắc Giang" },
                    { 29, "Hòa Bình" },
                    { 30, "An Giang" },
                    { 31, "Vĩnh Phúc" },
                    { 32, "Tây Ninh" },
                    { 33, "Thái Nguyên" },
                    { 34, "Lào Cai" },
                    { 35, "Nam Định" },
                    { 36, "Quảng Ngãi" },
                    { 37, "Bến Tre" },
                    { 38, "Đắk Nông" },
                    { 39, "Cà Mau" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 40, "Vĩnh Long" },
                    { 41, "Ninh Bình" },
                    { 42, "Phú Thọ" },
                    { 43, "Ninh Thuận" },
                    { 44, "Phú Yên" },
                    { 45, "Hà Nam" },
                    { 46, "Hà Tĩnh" },
                    { 47, "Đồng Tháp" },
                    { 48, "Sóc Trăng" },
                    { 49, "Kon Tum" },
                    { 50, "Quảng Bình" },
                    { 51, "Quảng Trị" },
                    { 52, "Trà Vinh" },
                    { 53, "Hậu Giang" },
                    { 54, "Sơn La" },
                    { 55, "Bạc Liêu" },
                    { 56, "Yên Bái" },
                    { 57, "Tuyên Quang" },
                    { 58, "Điện Biên" },
                    { 59, "Lai Châu" },
                    { 60, "Lạng Sơn" },
                    { 61, "Hà Giang" },
                    { 62, "Bắc Kạn" },
                    { 63, "Cao Bằng" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                columns: new[] { "CityId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 2, "24129f91-10ab-44fb-8e4f-e096b55fab5d", "AQAAAAEAACcQAAAAEF2UE6+XpK0PuAHmxVn3WuZnIwzGUS+tUNBxW47YXmnr0U/OAtSMlCnyrBEVcyocjg==", "c76e5a8a-9b92-4735-a642-0889b4526b2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                columns: new[] { "CityId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 1, "7e2d692d-5ad2-4616-950f-f1a9b2672fec", "AQAAAAEAACcQAAAAEBwN9o4XBjSGvTQIrBK5K5b0iZQB+vR6oB7fyobcBQl9r5UWfRJbTxSPh3fS9IgZkg==", "ea95590a-1a87-4964-9288-e91d689529ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                columns: new[] { "CityId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 2, "7b9c9d38-0d5d-460c-936f-26bac836d4f5", "AQAAAAEAACcQAAAAEDyz0a+NoLxNYLBw4RULg8QLcYB5rdR4SJAujGjNmfttvOVJXYtNXXqmwQZakIKbrQ==", "7f7cd98f-9fa4-498e-8a2f-e9455a9e0f8c" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CityId",
                table: "AspNetUsers",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Cities_CityId",
                table: "AspNetUsers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Cities_CityId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CityId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "AspNetUsers");

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
    }
}
