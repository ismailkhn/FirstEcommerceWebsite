using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class asdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_CoverPhotoId",
                table: "Products",
                column: "CoverPhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Pictures_CoverPhotoId",
                table: "Products",
                column: "CoverPhotoId",
                principalTable: "Pictures",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Pictures_CoverPhotoId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CoverPhotoId",
                table: "Products");
        }
    }
}
