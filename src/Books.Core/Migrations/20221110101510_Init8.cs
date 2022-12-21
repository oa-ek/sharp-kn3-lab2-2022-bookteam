using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.Core.Migrations
{
    public partial class Init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");

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

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Genres",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "PublishersId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Rating",
                table: "Books",
                type: "real",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    AuthorsId = table.Column<int>(type: "int", nullable: false),
                    BooksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.AuthorsId, x.BooksId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookGenre",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    GenresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => new { x.BooksId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_BookGenre_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenre_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Genres",
                columns: new[] { "Id", "GenreName" },
                values: new object[,]
                {
                    { 1, "Fantasy" },
                    { 2, "Fiction" },
                    { 3, "Adventure" },
                    { 4, "Classics" },
                    { 5, "Novels" },
                    { 6, "Young Adult" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Scholastic Inc" },
                    { 2, "Houghton Mifflin Harcourt" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublishersId",
                table: "Books",
                column: "PublishersId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                column: "BooksId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_GenresId",
                table: "BookGenre",
                column: "GenresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublishersId",
                table: "Books",
                column: "PublishersId",
                principalTable: "Publishers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublishersId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "BookGenre");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Books_PublishersId",
                table: "Books");

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

            migrationBuilder.DropColumn(
                name: "PublishersId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Genres",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "AuthorId", "Genres" },
                values: new object[] { 1, "Fantasy, Fiction, Young Adult, Magic, Childrens, Middle Grade, Classics, Adventure" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Genres" },
                values: new object[] { 2, "Classics, Fiction, Adventure, Fantasy, Literature, Novels, Young Adult" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
