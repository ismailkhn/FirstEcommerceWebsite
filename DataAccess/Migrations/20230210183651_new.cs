using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productToCollections_Collections_CollectionId",
                table: "productToCollections");

            migrationBuilder.DropForeignKey(
                name: "FK_productToCollections_Products_ProductId",
                table: "productToCollections");

            migrationBuilder.DropForeignKey(
                name: "FK_productToPictures_Products_ProductId",
                table: "productToPictures");

            migrationBuilder.DropForeignKey(
                name: "FK_productToPictures_pictures_PictureId",
                table: "productToPictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productToPictures",
                table: "productToPictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productToCollections",
                table: "productToCollections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pictures",
                table: "pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_homeSliders",
                table: "homeSliders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bannerProducts",
                table: "bannerProducts");

            migrationBuilder.RenameTable(
                name: "productToPictures",
                newName: "ProductToPictures");

            migrationBuilder.RenameTable(
                name: "productToCollections",
                newName: "ProductToCollections");

            migrationBuilder.RenameTable(
                name: "pictures",
                newName: "Pictures");

            migrationBuilder.RenameTable(
                name: "homeSliders",
                newName: "HomeSliders");

            migrationBuilder.RenameTable(
                name: "bannerProducts",
                newName: "BannerProducts");

            migrationBuilder.RenameIndex(
                name: "IX_productToPictures_ProductId",
                table: "ProductToPictures",
                newName: "IX_ProductToPictures_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_productToPictures_PictureId",
                table: "ProductToPictures",
                newName: "IX_ProductToPictures_PictureId");

            migrationBuilder.RenameIndex(
                name: "IX_productToCollections_ProductId",
                table: "ProductToCollections",
                newName: "IX_ProductToCollections_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_productToCollections_CollectionId",
                table: "ProductToCollections",
                newName: "IX_ProductToCollections_CollectionId");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "HomeSliders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductToPictures",
                table: "ProductToPictures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductToCollections",
                table: "ProductToCollections",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeSliders",
                table: "HomeSliders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BannerProducts",
                table: "BannerProducts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductToCollections_Collections_CollectionId",
                table: "ProductToCollections",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductToCollections_Products_ProductId",
                table: "ProductToCollections",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductToPictures_Pictures_PictureId",
                table: "ProductToPictures",
                column: "PictureId",
                principalTable: "Pictures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductToPictures_Products_ProductId",
                table: "ProductToPictures",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductToCollections_Collections_CollectionId",
                table: "ProductToCollections");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductToCollections_Products_ProductId",
                table: "ProductToCollections");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductToPictures_Pictures_PictureId",
                table: "ProductToPictures");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductToPictures_Products_ProductId",
                table: "ProductToPictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductToPictures",
                table: "ProductToPictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductToCollections",
                table: "ProductToCollections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeSliders",
                table: "HomeSliders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BannerProducts",
                table: "BannerProducts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "HomeSliders");

            migrationBuilder.RenameTable(
                name: "ProductToPictures",
                newName: "productToPictures");

            migrationBuilder.RenameTable(
                name: "ProductToCollections",
                newName: "productToCollections");

            migrationBuilder.RenameTable(
                name: "Pictures",
                newName: "pictures");

            migrationBuilder.RenameTable(
                name: "HomeSliders",
                newName: "homeSliders");

            migrationBuilder.RenameTable(
                name: "BannerProducts",
                newName: "bannerProducts");

            migrationBuilder.RenameIndex(
                name: "IX_ProductToPictures_ProductId",
                table: "productToPictures",
                newName: "IX_productToPictures_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductToPictures_PictureId",
                table: "productToPictures",
                newName: "IX_productToPictures_PictureId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductToCollections_ProductId",
                table: "productToCollections",
                newName: "IX_productToCollections_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductToCollections_CollectionId",
                table: "productToCollections",
                newName: "IX_productToCollections_CollectionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productToPictures",
                table: "productToPictures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productToCollections",
                table: "productToCollections",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pictures",
                table: "pictures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_homeSliders",
                table: "homeSliders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bannerProducts",
                table: "bannerProducts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_productToCollections_Collections_CollectionId",
                table: "productToCollections",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productToCollections_Products_ProductId",
                table: "productToCollections",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productToPictures_Products_ProductId",
                table: "productToPictures",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productToPictures_pictures_PictureId",
                table: "productToPictures",
                column: "PictureId",
                principalTable: "pictures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
