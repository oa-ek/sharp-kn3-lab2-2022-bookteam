using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.Core.Migrations
{
    public partial class Init9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6fb0ee40-b679-4d66-a79a-701c41f46936", "3ab3ea45-e7ed-4adf-b51f-bcf886471b19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8039bdf9-1539-4aa3-b7ae-3fa60512abc8", "3ab3ea45-e7ed-4adf-b51f-bcf886471b19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6fb0ee40-b679-4d66-a79a-701c41f46936", "dec3cd78-72cc-4df3-a73a-d6f4c4640d12" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fb0ee40-b679-4d66-a79a-701c41f46936");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8039bdf9-1539-4aa3-b7ae-3fa60512abc8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ab3ea45-e7ed-4adf-b51f-bcf886471b19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dec3cd78-72cc-4df3-a73a-d6f4c4640d12");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "442bded9-cf4d-4e0a-a314-a0d6f8402c38", "9489e602-33be-43b7-87b1-4698621c4748", "Moderator", "MODERATOR" },
                    { "4e956607-9c62-4e68-affb-690a084e3175", "62adca41-0051-42d7-ad59-6d37fb9cd09e", "Admin", "ADMIN" },
                    { "d43554b0-b7cd-4637-a3fe-8acd4431e0f5", "7c9a3830-a58c-4b64-9a09-997a79f21c7b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5851d398-136b-478e-bbec-abf79924f2a8", 0, "727c307d-efce-4143-8158-232cd54d860a", "user@gmails.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAECXRWlgET7xBVxfqbXlebv4hU6gSe9lMS5y1PWHI+2LEf49S/SClZOWixAvzwLBqXg==", null, false, "bfc7a54b-7f8f-4487-83a4-8b627e22b18c", false, "user@gmail.com" },
                    { "7244ace3-2031-4209-a13c-cf2c7847fb89", 0, "02a365dd-5397-401f-a29d-0c94d73d92a1", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECV51xbNqVTqNgX8d0F4Xc/ZGTtLBr1lCmnerBuOPk21A6hCJXs30RsipMB6w5myDg==", null, false, "0de20542-17b2-4b98-9594-c78db5cc488b", false, "admin@gmail.com" },
                    { "81bed891-89c5-4e5e-b188-ed63c3b82482", 0, "5ba6985b-056d-4775-b8e5-bf9f5f7c8a34", "moder@gmail.com", true, null, null, false, null, "MODER@GMAIL.COM", "MODER@GMAIL.COM", "AQAAAAEAACcQAAAAELa11qgqq8Se5aUrHv82moNBJj3+JXgQ8HhifDjDPnxzWMCn9yeYfDs4gWOXoqDQvQ==", null, false, "07aac5cd-5769-45c4-ba1c-9c98e357fef3", false, "moder@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d43554b0-b7cd-4637-a3fe-8acd4431e0f5", "5851d398-136b-478e-bbec-abf79924f2a8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4e956607-9c62-4e68-affb-690a084e3175", "7244ace3-2031-4209-a13c-cf2c7847fb89" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "442bded9-cf4d-4e0a-a314-a0d6f8402c38", "81bed891-89c5-4e5e-b188-ed63c3b82482" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d43554b0-b7cd-4637-a3fe-8acd4431e0f5", "5851d398-136b-478e-bbec-abf79924f2a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4e956607-9c62-4e68-affb-690a084e3175", "7244ace3-2031-4209-a13c-cf2c7847fb89" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "442bded9-cf4d-4e0a-a314-a0d6f8402c38", "81bed891-89c5-4e5e-b188-ed63c3b82482" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "442bded9-cf4d-4e0a-a314-a0d6f8402c38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e956607-9c62-4e68-affb-690a084e3175");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d43554b0-b7cd-4637-a3fe-8acd4431e0f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5851d398-136b-478e-bbec-abf79924f2a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7244ace3-2031-4209-a13c-cf2c7847fb89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81bed891-89c5-4e5e-b188-ed63c3b82482");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6fb0ee40-b679-4d66-a79a-701c41f46936", "e8e98494-b34e-417b-8650-e8179b26f4f1", "Admin", "ADMIN" },
                    { "8039bdf9-1539-4aa3-b7ae-3fa60512abc8", "59f8df8d-7db7-4531-ad0e-70a11fe1b3cc", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3ab3ea45-e7ed-4adf-b51f-bcf886471b19", 0, "6a6ffc10-e4f3-43fe-9320-31da8edb7df9", "user@books.com", true, null, null, false, null, "USER@BOOKS.COM", "USER@BOOKS.COM", "AQAAAAEAACcQAAAAEBxhddaU6wmhIn3gk+nfH6Aw04F62hQLyC2V4NYCeho/24TjBodx9eb6XprTtVLwOw==", null, false, "fa76617b-084a-4ab1-9bcf-29140ecebf7f", false, "user@books.com" },
                    { "dec3cd78-72cc-4df3-a73a-d6f4c4640d12", 0, "8ce8d25f-9f3e-475a-8f59-fbc0c53f709d", "admin@books.com", true, null, null, false, null, "ADMIN@BOOKS.COM", "ADMIN@BOOKS.COM", "AQAAAAEAACcQAAAAEHYwW/L46XGgYDOLe/xqPJ+MY0brQvS5eX9pXJujfjwfX2iz4waTlu6kPZwxtnVl3w==", null, false, "78b5700d-6e99-4f20-b28a-7ab129e93bfc", false, "admin@books.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6fb0ee40-b679-4d66-a79a-701c41f46936", "3ab3ea45-e7ed-4adf-b51f-bcf886471b19" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8039bdf9-1539-4aa3-b7ae-3fa60512abc8", "3ab3ea45-e7ed-4adf-b51f-bcf886471b19" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6fb0ee40-b679-4d66-a79a-701c41f46936", "dec3cd78-72cc-4df3-a73a-d6f4c4640d12" });
        }
    }
}
