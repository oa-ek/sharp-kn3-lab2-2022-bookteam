using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.Core.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "072b496b-f423-4e16-83b6-081c811ee222", "ae420d9e-e93c-4d47-a1e2-a0808af342d1", "User", "USER" },
                    { "327b1e54-9504-40d0-8d18-0ba969164f7f", "7b5ec45c-e04d-464a-9097-9f87ee2f3021", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2d7048fb-1c33-4ab9-84e3-8157893f941f", 0, "4cbe37ce-bbd4-4295-904c-d4362e27ff33", "user@books.com", true, null, null, false, null, "USER@BOOKS.COM", "USER@BOOKS.COM", "AQAAAAEAACcQAAAAEAnmBINdKjnsEuhf/wz0n6Sc0OxPwJgNWl5NLLdZJej/IlcPG3+UJStMjbV3bSG0Fw==", null, false, "b81d847b-862d-4615-8881-2442367b057e", false, "user@books.com" },
                    { "bb7820b7-359e-44c1-8f72-b0443049c115", 0, "c97e5dcb-7839-496a-9cf2-8f4337037560", "admin@books.com", true, null, null, false, null, "ADMIN@BOOKS.COM", "ADMIN@BOOKS.COM", "AQAAAAEAACcQAAAAEFjDYdIg8y0p6vWOo1euiCIXGGeRr/BoZMIpL/jy6pYJkbkHq4ZnzK/6APpwrNsp9w==", null, false, "ec1b3ebc-6617-4325-a128-5224299e05d7", false, "admin@books.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "072b496b-f423-4e16-83b6-081c811ee222", "2d7048fb-1c33-4ab9-84e3-8157893f941f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "327b1e54-9504-40d0-8d18-0ba969164f7f", "2d7048fb-1c33-4ab9-84e3-8157893f941f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "327b1e54-9504-40d0-8d18-0ba969164f7f", "bb7820b7-359e-44c1-8f72-b0443049c115" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "072b496b-f423-4e16-83b6-081c811ee222", "2d7048fb-1c33-4ab9-84e3-8157893f941f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "327b1e54-9504-40d0-8d18-0ba969164f7f", "2d7048fb-1c33-4ab9-84e3-8157893f941f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "327b1e54-9504-40d0-8d18-0ba969164f7f", "bb7820b7-359e-44c1-8f72-b0443049c115" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "072b496b-f423-4e16-83b6-081c811ee222");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "327b1e54-9504-40d0-8d18-0ba969164f7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d7048fb-1c33-4ab9-84e3-8157893f941f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb7820b7-359e-44c1-8f72-b0443049c115");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
