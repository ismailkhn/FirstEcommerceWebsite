using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newbase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Blogs",
                newName: "PublishedTime");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlogCategoryId",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TagToBlog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagToBlog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TagToBlog_BlogTag_TagId",
                        column: x => x.TagId,
                        principalTable: "BlogTag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagToBlog_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorId",
                table: "Blogs",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogCategoryId",
                table: "Blogs",
                column: "BlogCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TagToBlog_BlogId",
                table: "TagToBlog",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_TagToBlog_TagId",
                table: "TagToBlog",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Author_AuthorId",
                table: "Blogs",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogCategory_BlogCategoryId",
                table: "Blogs",
                column: "BlogCategoryId",
                principalTable: "BlogCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Author_AuthorId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogCategory_BlogCategoryId",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "BlogCategory");

            migrationBuilder.DropTable(
                name: "TagToBlog");

            migrationBuilder.DropTable(
                name: "BlogTag");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_AuthorId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_BlogCategoryId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BlogCategoryId",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "PublishedTime",
                table: "Blogs",
                newName: "Time");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Blogs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
