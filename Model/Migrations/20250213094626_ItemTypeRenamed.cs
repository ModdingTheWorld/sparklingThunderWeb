using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class ItemTypeRenamed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BLOCKS_ItemTypes_ITEM_TYPE_ID",
                table: "BLOCKS");

            migrationBuilder.DropForeignKey(
                name: "FK_ENTITIES_ItemTypes_ITEM_TYPE_ID",
                table: "ENTITIES");

            migrationBuilder.DropForeignKey(
                name: "FK_ITEMS_ItemTypes_ItemTypeId",
                table: "ITEMS");

            migrationBuilder.DropForeignKey(
                name: "FK_TOOLS_ItemTypes_ITEM_TYPE_ID",
                table: "TOOLS");

            migrationBuilder.DropForeignKey(
                name: "FK_WEAPONS_ItemTypes_ITEM_TYPE_ID",
                table: "WEAPONS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemTypes",
                table: "ItemTypes");

            migrationBuilder.RenameTable(
                name: "ItemTypes",
                newName: "ITEM_TYPE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITEM_TYPE",
                table: "ITEM_TYPE",
                column: "ITEM_TYPE_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BLOCKS_ITEM_TYPE_ITEM_TYPE_ID",
                table: "BLOCKS",
                column: "ITEM_TYPE_ID",
                principalTable: "ITEM_TYPE",
                principalColumn: "ITEM_TYPE_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ENTITIES_ITEM_TYPE_ITEM_TYPE_ID",
                table: "ENTITIES",
                column: "ITEM_TYPE_ID",
                principalTable: "ITEM_TYPE",
                principalColumn: "ITEM_TYPE_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ITEMS_ITEM_TYPE_ItemTypeId",
                table: "ITEMS",
                column: "ItemTypeId",
                principalTable: "ITEM_TYPE",
                principalColumn: "ITEM_TYPE_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TOOLS_ITEM_TYPE_ITEM_TYPE_ID",
                table: "TOOLS",
                column: "ITEM_TYPE_ID",
                principalTable: "ITEM_TYPE",
                principalColumn: "ITEM_TYPE_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WEAPONS_ITEM_TYPE_ITEM_TYPE_ID",
                table: "WEAPONS",
                column: "ITEM_TYPE_ID",
                principalTable: "ITEM_TYPE",
                principalColumn: "ITEM_TYPE_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BLOCKS_ITEM_TYPE_ITEM_TYPE_ID",
                table: "BLOCKS");

            migrationBuilder.DropForeignKey(
                name: "FK_ENTITIES_ITEM_TYPE_ITEM_TYPE_ID",
                table: "ENTITIES");

            migrationBuilder.DropForeignKey(
                name: "FK_ITEMS_ITEM_TYPE_ItemTypeId",
                table: "ITEMS");

            migrationBuilder.DropForeignKey(
                name: "FK_TOOLS_ITEM_TYPE_ITEM_TYPE_ID",
                table: "TOOLS");

            migrationBuilder.DropForeignKey(
                name: "FK_WEAPONS_ITEM_TYPE_ITEM_TYPE_ID",
                table: "WEAPONS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITEM_TYPE",
                table: "ITEM_TYPE");

            migrationBuilder.RenameTable(
                name: "ITEM_TYPE",
                newName: "ItemTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemTypes",
                table: "ItemTypes",
                column: "ITEM_TYPE_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BLOCKS_ItemTypes_ITEM_TYPE_ID",
                table: "BLOCKS",
                column: "ITEM_TYPE_ID",
                principalTable: "ItemTypes",
                principalColumn: "ITEM_TYPE_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ENTITIES_ItemTypes_ITEM_TYPE_ID",
                table: "ENTITIES",
                column: "ITEM_TYPE_ID",
                principalTable: "ItemTypes",
                principalColumn: "ITEM_TYPE_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ITEMS_ItemTypes_ItemTypeId",
                table: "ITEMS",
                column: "ItemTypeId",
                principalTable: "ItemTypes",
                principalColumn: "ITEM_TYPE_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TOOLS_ItemTypes_ITEM_TYPE_ID",
                table: "TOOLS",
                column: "ITEM_TYPE_ID",
                principalTable: "ItemTypes",
                principalColumn: "ITEM_TYPE_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WEAPONS_ItemTypes_ITEM_TYPE_ID",
                table: "WEAPONS",
                column: "ITEM_TYPE_ID",
                principalTable: "ItemTypes",
                principalColumn: "ITEM_TYPE_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
