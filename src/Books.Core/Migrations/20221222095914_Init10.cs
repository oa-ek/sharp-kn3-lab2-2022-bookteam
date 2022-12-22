using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.Core.Migrations
{
    public partial class Init10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "BookUser",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookUser", x => new { x.BooksId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_BookUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookUser_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00515a0f-575f-42ee-818f-9253cbc2e9ed", "6cd3a3b2-8cc8-410b-a896-d2136279c6d0", "Moderator", "MODERATOR" },
                    { "0bd77fa6-f374-4ca5-af23-907b54da6fb3", "1857858c-fca1-4fe2-88ba-c3cfa6da6232", "Admin", "ADMIN" },
                    { "945ef5fb-40cd-4e38-afb9-c1d4593817eb", "ff168586-b13d-4c68-834f-f3493a41106c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1156a3e3-1556-4b7a-a04d-92dc2d121aea", 0, "5cdac27b-40ba-4c76-800a-23984b47de38", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEL4CrGkcTpLhEMg8xXNFXRQcVK93NgNy3mlF1n0uE4dVSz4tMm35ssNvKb39QVRLkA==", null, false, "b92e606a-3629-41c4-a4a3-96ac847aa3b9", false, "admin@gmail.com" },
                    { "752f5361-3636-4165-963a-91e3b519acbd", 0, "06538a43-7e65-4c0f-8176-124df067e653", "moder@gmail.com", true, null, null, false, null, "MODER@GMAIL.COM", "MODER@GMAIL.COM", "AQAAAAEAACcQAAAAECvXXqye4L9UJdVYKFSH4S2b5kFnaYwDhyriyZXu+tF5aSUydBWerJ4khxQD7aaDEw==", null, false, "4de54123-e93a-4ac1-a778-c3e099784b24", false, "moder@gmail.com" },
                    { "c0042b68-9973-4b30-9b01-f91d4a55654e", 0, "e3633b22-4a93-42aa-9575-d380b457540b", "user@gmails.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEF/u72Na9VEIOGp8qv2D1XKI2kUugADBnWLnX95DLCkm2cHzp2a9Bdrf/YVaE2Lyig==", null, false, "93dbd7f8-2afe-4fb1-bf4e-9506a3121e18", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0bd77fa6-f374-4ca5-af23-907b54da6fb3", "1156a3e3-1556-4b7a-a04d-92dc2d121aea" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "00515a0f-575f-42ee-818f-9253cbc2e9ed", "752f5361-3636-4165-963a-91e3b519acbd" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "945ef5fb-40cd-4e38-afb9-c1d4593817eb", "c0042b68-9973-4b30-9b01-f91d4a55654e" });

            migrationBuilder.CreateIndex(
                name: "IX_BookUser_UsersId",
                table: "BookUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookUser");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0bd77fa6-f374-4ca5-af23-907b54da6fb3", "1156a3e3-1556-4b7a-a04d-92dc2d121aea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00515a0f-575f-42ee-818f-9253cbc2e9ed", "752f5361-3636-4165-963a-91e3b519acbd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "945ef5fb-40cd-4e38-afb9-c1d4593817eb", "c0042b68-9973-4b30-9b01-f91d4a55654e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00515a0f-575f-42ee-818f-9253cbc2e9ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0bd77fa6-f374-4ca5-af23-907b54da6fb3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "945ef5fb-40cd-4e38-afb9-c1d4593817eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1156a3e3-1556-4b7a-a04d-92dc2d121aea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "752f5361-3636-4165-963a-91e3b519acbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0042b68-9973-4b30-9b01-f91d4a55654e");

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
    }
}
