using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.Core.Migrations
{
    public partial class Init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
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

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a94e9728-1ca1-4d2e-88a5-c1157a822292", "eec1a525-fc5e-467f-b0fa-6191a6ff8d98", "User", "USER" },
                    { "b9ca6af4-0d99-4749-baba-dd66223692d1", "b16f672a-6fc9-4a88-a77a-4311da05c8b8", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "659ecc89-e26b-469c-b879-494f4744de36", 0, "8b87bd9b-23ec-4096-9db1-8b5a9a409bed", "admin@books.com", true, null, null, false, null, "ADMIN@BOOKS.COM", "ADMIN@BOOKS.COM", "AQAAAAEAACcQAAAAEGljWDI0S3uOPDZ9WEVH62zuejIxTrsW+a8WkedlFXD6beKa6YjJsyne/s1SwielAA==", null, false, "d63f6472-24e5-4122-aa60-f244dc8a889b", false, "admin@books.com" },
                    { "954c466f-822c-429b-aba7-669425d09d56", 0, "980f900e-e823-4e2c-a112-39f7b900fb83", "user@books.com", true, null, null, false, null, "USER@BOOKS.COM", "USER@BOOKS.COM", "AQAAAAEAACcQAAAAELmu98f/Zbn+MFxesDCVF9dZ/mHa3aCPF0lU7b9cJDy3L7v22hezP2of3omatXJeeA==", null, false, "9b4bfdab-5ddd-444d-b03d-42927d81acb4", false, "user@books.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, " J.K. Rowling" },
                    { 2, "J.R.R. Tolkien" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b9ca6af4-0d99-4749-baba-dd66223692d1", "659ecc89-e26b-469c-b879-494f4744de36" },
                    { "a94e9728-1ca1-4d2e-88a5-c1157a822292", "954c466f-822c-429b-aba7-669425d09d56" },
                    { "b9ca6af4-0d99-4749-baba-dd66223692d1", "954c466f-822c-429b-aba7-669425d09d56" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Genres", "IconPath", "PageCount", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Harry Potter has no idea how famous he is. That's because he's being raised by his miserable aunt and uncle who are terrified Harry will learn that he's really a wizard, just as his parents were. But everything changes when Harry is summoned to attend an infamous school for wizards, and he begins to discover some clues about his illustrious birthright. From the surprising ...", "Fantasy, Fiction, Young Adult, Magic, Childrens, Middle Grade, Classics, Adventure", "Images\\abc73q84.jpg", 309, new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Sorcerer's Stone" },
                    { 2, 2, "Sumptuous slipcased edition of Tolkien’s classic epic tale of adventure, fully illustrated in colour for the first time by the author himself. Limited to a worldwide first printing of just 5,000 copies, this deluxe volume is quarterbound in leather and includes many special features unique to this edition. Since it was first published in 1954, The Lord of the Rings has bee ...", "Classics, Fiction, Adventure, Fantasy, Literature, Novels, Young Adult", "Images\\33.jpg", 1216, new DateTime(2005, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b9ca6af4-0d99-4749-baba-dd66223692d1", "659ecc89-e26b-469c-b879-494f4744de36" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a94e9728-1ca1-4d2e-88a5-c1157a822292", "954c466f-822c-429b-aba7-669425d09d56" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b9ca6af4-0d99-4749-baba-dd66223692d1", "954c466f-822c-429b-aba7-669425d09d56" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a94e9728-1ca1-4d2e-88a5-c1157a822292");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9ca6af4-0d99-4749-baba-dd66223692d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "659ecc89-e26b-469c-b879-494f4744de36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "954c466f-822c-429b-aba7-669425d09d56");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Books",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");
        }
    }
}
