using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.Core.Migrations
{
    public partial class Init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "454c802c-3a17-46c4-b35d-2586a3bcd0e4", "63ac132d-3196-44ef-9ba0-6aa0f596c534", "Admin", "ADMIN" },
                    { "af881eaf-652f-4390-b3aa-4bf481ca623f", "3add5757-c029-4a1e-9ffa-19bbffa25107", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "60fc9253-5d9b-47fa-a5e5-1a745f584176", 0, "8ec10fec-a637-4622-b466-6d4121e79674", "user@books.com", true, null, null, false, null, "USER@BOOKS.COM", "USER@BOOKS.COM", "AQAAAAEAACcQAAAAEBpZJCqpJ42dQHzb+AEVCPPc1GrrrXvAoEkKtmzcyHHth7Km8Ai70sWXiF6Gn+7elQ==", null, false, "89ce17af-91fc-467f-a80a-e9f260515133", false, "user@books.com" },
                    { "8fca2658-f9ad-4309-8548-482d8cf70646", 0, "a1cca485-03b8-49da-b1f1-a19bf4923e82", "admin@books.com", true, null, null, false, null, "ADMIN@BOOKS.COM", "ADMIN@BOOKS.COM", "AQAAAAEAACcQAAAAEG5UDNsZM4lVPiOU3oSHqOjSF+vMKT1hlh6pG/bmGEE1Zzwo7H8UQpLDuO+Eg70Cxw==", null, false, "e3dde32a-4194-4496-bb7b-4fad732138f9", false, "admin@books.com" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "IconPath",
                value: "Images\\1.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "454c802c-3a17-46c4-b35d-2586a3bcd0e4", "60fc9253-5d9b-47fa-a5e5-1a745f584176" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "af881eaf-652f-4390-b3aa-4bf481ca623f", "60fc9253-5d9b-47fa-a5e5-1a745f584176" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "454c802c-3a17-46c4-b35d-2586a3bcd0e4", "8fca2658-f9ad-4309-8548-482d8cf70646" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "454c802c-3a17-46c4-b35d-2586a3bcd0e4", "60fc9253-5d9b-47fa-a5e5-1a745f584176" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af881eaf-652f-4390-b3aa-4bf481ca623f", "60fc9253-5d9b-47fa-a5e5-1a745f584176" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "454c802c-3a17-46c4-b35d-2586a3bcd0e4", "8fca2658-f9ad-4309-8548-482d8cf70646" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "454c802c-3a17-46c4-b35d-2586a3bcd0e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af881eaf-652f-4390-b3aa-4bf481ca623f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60fc9253-5d9b-47fa-a5e5-1a745f584176");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fca2658-f9ad-4309-8548-482d8cf70646");

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

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "IconPath",
                value: "Images\\abc73q84.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b9ca6af4-0d99-4749-baba-dd66223692d1", "659ecc89-e26b-469c-b879-494f4744de36" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a94e9728-1ca1-4d2e-88a5-c1157a822292", "954c466f-822c-429b-aba7-669425d09d56" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b9ca6af4-0d99-4749-baba-dd66223692d1", "954c466f-822c-429b-aba7-669425d09d56" });
        }
    }
}
