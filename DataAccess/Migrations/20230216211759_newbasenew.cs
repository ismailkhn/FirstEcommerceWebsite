using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newbasenew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Author_AuthorId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogCategory_BlogCategoryId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_TagToBlog_BlogTag_TagId",
                table: "TagToBlog");

            migrationBuilder.DropForeignKey(
                name: "FK_TagToBlog_Blogs_BlogId",
                table: "TagToBlog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagToBlog",
                table: "TagToBlog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogTag",
                table: "BlogTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogCategory",
                table: "BlogCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "TagToBlog",
                newName: "tagToBlogs");

            migrationBuilder.RenameTable(
                name: "BlogTag",
                newName: "BlogTags");

            migrationBuilder.RenameTable(
                name: "BlogCategory",
                newName: "BlogCategories");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authors");

            migrationBuilder.RenameIndex(
                name: "IX_TagToBlog_TagId",
                table: "tagToBlogs",
                newName: "IX_tagToBlogs_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_TagToBlog_BlogId",
                table: "tagToBlogs",
                newName: "IX_tagToBlogs_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tagToBlogs",
                table: "tagToBlogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogTags",
                table: "BlogTags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogCategories",
                table: "BlogCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Authors_AuthorId",
                table: "Blogs",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogCategories_BlogCategoryId",
                table: "Blogs",
                column: "BlogCategoryId",
                principalTable: "BlogCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tagToBlogs_BlogTags_TagId",
                table: "tagToBlogs",
                column: "TagId",
                principalTable: "BlogTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tagToBlogs_Blogs_BlogId",
                table: "tagToBlogs",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Authors_AuthorId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogCategories_BlogCategoryId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_tagToBlogs_BlogTags_TagId",
                table: "tagToBlogs");

            migrationBuilder.DropForeignKey(
                name: "FK_tagToBlogs_Blogs_BlogId",
                table: "tagToBlogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tagToBlogs",
                table: "tagToBlogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogTags",
                table: "BlogTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogCategories",
                table: "BlogCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "tagToBlogs",
                newName: "TagToBlog");

            migrationBuilder.RenameTable(
                name: "BlogTags",
                newName: "BlogTag");

            migrationBuilder.RenameTable(
                name: "BlogCategories",
                newName: "BlogCategory");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Author");

            migrationBuilder.RenameIndex(
                name: "IX_tagToBlogs_TagId",
                table: "TagToBlog",
                newName: "IX_TagToBlog_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_tagToBlogs_BlogId",
                table: "TagToBlog",
                newName: "IX_TagToBlog_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagToBlog",
                table: "TagToBlog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogTag",
                table: "BlogTag",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogCategory",
                table: "BlogCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TagToBlog_BlogTag_TagId",
                table: "TagToBlog",
                column: "TagId",
                principalTable: "BlogTag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagToBlog_Blogs_BlogId",
                table: "TagToBlog",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
