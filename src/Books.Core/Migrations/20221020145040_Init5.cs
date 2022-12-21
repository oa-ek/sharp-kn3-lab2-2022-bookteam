using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.Core.Migrations
{
    public partial class Init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e12a8a88-f64a-4d89-8d28-1caad1eb79bf", "5126eb3b-3ec9-448a-bca4-2f05a20ff851" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e12a8a88-f64a-4d89-8d28-1caad1eb79bf", "b5ba870e-4a44-490f-a3b5-6d25b7c7f533" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fd78d75d-c63d-43a3-8e0d-8a4180e3c526", "b5ba870e-4a44-490f-a3b5-6d25b7c7f533" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e12a8a88-f64a-4d89-8d28-1caad1eb79bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd78d75d-c63d-43a3-8e0d-8a4180e3c526");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5126eb3b-3ec9-448a-bca4-2f05a20ff851");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5ba870e-4a44-490f-a3b5-6d25b7c7f533");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconPath",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f4cf3f1-267c-4aaf-87aa-2afc7618c2c9", "f697cc7d-625c-42a7-9322-122ee67849bb", "Admin", "ADMIN" },
                    { "a047761c-99b8-4741-be18-9c2a3a0407ed", "f4b93f3e-0e71-4e3d-9b4e-26d31f47434d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "299ffcb9-45c6-4f96-84ff-b1c24fb45d97", 0, "2f684e99-65ae-4163-9145-11aa8f65fe4b", "admin@books.com", true, null, null, false, null, "ADMIN@BOOKS.COM", "ADMIN@BOOKS.COM", "AQAAAAEAACcQAAAAEAKCnaqzhRb6AmVXuWE4h9dD2ugN34Xgjr9V0MQMDL0cOxhdN8yYVTg9IcSL/RJP6w==", null, false, "c94577f5-bdba-4877-93b5-9ab1bdd660b3", false, "admin@books.com" },
                    { "c3bd138e-6d11-4ca5-98cc-60a0737c3720", 0, "5a46fc60-1701-434a-bb2c-cbe158bf77b6", "user@books.com", true, null, null, false, null, "USER@BOOKS.COM", "USER@BOOKS.COM", "AQAAAAEAACcQAAAAEOd+owjXgvNIZcoer/SJD3het9NKVsbXnp7xKpDjMQp+xi+cgaYKBOMzpzaUA+Soew==", null, false, "d6690734-19e9-48fe-9188-68458b3e7c6e", false, "user@books.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1f4cf3f1-267c-4aaf-87aa-2afc7618c2c9", "299ffcb9-45c6-4f96-84ff-b1c24fb45d97" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1f4cf3f1-267c-4aaf-87aa-2afc7618c2c9", "c3bd138e-6d11-4ca5-98cc-60a0737c3720" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a047761c-99b8-4741-be18-9c2a3a0407ed", "c3bd138e-6d11-4ca5-98cc-60a0737c3720" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1f4cf3f1-267c-4aaf-87aa-2afc7618c2c9", "299ffcb9-45c6-4f96-84ff-b1c24fb45d97" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1f4cf3f1-267c-4aaf-87aa-2afc7618c2c9", "c3bd138e-6d11-4ca5-98cc-60a0737c3720" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a047761c-99b8-4741-be18-9c2a3a0407ed", "c3bd138e-6d11-4ca5-98cc-60a0737c3720" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f4cf3f1-267c-4aaf-87aa-2afc7618c2c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a047761c-99b8-4741-be18-9c2a3a0407ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "299ffcb9-45c6-4f96-84ff-b1c24fb45d97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3bd138e-6d11-4ca5-98cc-60a0737c3720");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IconPath",
                table: "Books");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e12a8a88-f64a-4d89-8d28-1caad1eb79bf", "94ab961a-a472-48ed-bf9e-d9f5939d9709", "Admin", "ADMIN" },
                    { "fd78d75d-c63d-43a3-8e0d-8a4180e3c526", "ac2b3749-d2e7-44e5-b393-070cd248fb8f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5126eb3b-3ec9-448a-bca4-2f05a20ff851", 0, "c326c0d8-db86-4273-bc05-0ae61c4a5317", "admin@books.com", true, null, null, false, null, "ADMIN@BOOKS.COM", "ADMIN@BOOKS.COM", "AQAAAAEAACcQAAAAECkNogAxkaq7VRQfnBd9GyD1nkDVp69N0AGiTHANtpmeQMmb0f+M7pfaTyaEPp2flQ==", null, false, "2416c8f1-4dec-496f-a3f6-445c629841e8", false, "admin@books.com" },
                    { "b5ba870e-4a44-490f-a3b5-6d25b7c7f533", 0, "b0d3d091-c08a-44bf-84db-3481befdd596", "user@books.com", true, null, null, false, null, "USER@BOOKS.COM", "USER@BOOKS.COM", "AQAAAAEAACcQAAAAEB7oALuzW8xTSQEdEASHRyUv1xXRiMlJQczik2GwtHfx9TFNuY5KivVjKYbd6IKGsw==", null, false, "ff96e054-c2eb-42ee-8235-f57ac988c6aa", false, "user@books.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e12a8a88-f64a-4d89-8d28-1caad1eb79bf", "5126eb3b-3ec9-448a-bca4-2f05a20ff851" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e12a8a88-f64a-4d89-8d28-1caad1eb79bf", "b5ba870e-4a44-490f-a3b5-6d25b7c7f533" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fd78d75d-c63d-43a3-8e0d-8a4180e3c526", "b5ba870e-4a44-490f-a3b5-6d25b7c7f533" });
        }
    }
}
