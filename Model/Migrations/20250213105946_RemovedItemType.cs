using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class RemovedItemType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "ITEM_TYPE");

            migrationBuilder.DropIndex(
                name: "IX_ITEMS_ItemTypeId",
                table: "ITEMS");

            migrationBuilder.RenameColumn(
                name: "ITEM_TYPE_ID",
                table: "WEAPONS",
                newName: "ITEM_ID");

            migrationBuilder.RenameColumn(
                name: "ITEM_TYPE_ID",
                table: "TOOLS",
                newName: "ITEM_ID");

            migrationBuilder.RenameColumn(
                name: "ItemTypeId",
                table: "ITEMS",
                newName: "TYPE");

            migrationBuilder.RenameColumn(
                name: "ITEM_TYPE_ID",
                table: "ENTITIES",
                newName: "ITEM_ID");

            migrationBuilder.RenameColumn(
                name: "ITEM_TYPE_ID",
                table: "BLOCKS",
                newName: "ITEM_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BLOCKS_ITEMS_ITEM_ID",
                table: "BLOCKS",
                column: "ITEM_ID",
                principalTable: "ITEMS",
                principalColumn: "ITEM_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ENTITIES_ITEMS_ITEM_ID",
                table: "ENTITIES",
                column: "ITEM_ID",
                principalTable: "ITEMS",
                principalColumn: "ITEM_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TOOLS_ITEMS_ITEM_ID",
                table: "TOOLS",
                column: "ITEM_ID",
                principalTable: "ITEMS",
                principalColumn: "ITEM_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WEAPONS_ITEMS_ITEM_ID",
                table: "WEAPONS",
                column: "ITEM_ID",
                principalTable: "ITEMS",
                principalColumn: "ITEM_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BLOCKS_ITEMS_ITEM_ID",
                table: "BLOCKS");

            migrationBuilder.DropForeignKey(
                name: "FK_ENTITIES_ITEMS_ITEM_ID",
                table: "ENTITIES");

            migrationBuilder.DropForeignKey(
                name: "FK_TOOLS_ITEMS_ITEM_ID",
                table: "TOOLS");

            migrationBuilder.DropForeignKey(
                name: "FK_WEAPONS_ITEMS_ITEM_ID",
                table: "WEAPONS");

            migrationBuilder.RenameColumn(
                name: "ITEM_ID",
                table: "WEAPONS",
                newName: "ITEM_TYPE_ID");

            migrationBuilder.RenameColumn(
                name: "ITEM_ID",
                table: "TOOLS",
                newName: "ITEM_TYPE_ID");

            migrationBuilder.RenameColumn(
                name: "TYPE",
                table: "ITEMS",
                newName: "ItemTypeId");

            migrationBuilder.RenameColumn(
                name: "ITEM_ID",
                table: "ENTITIES",
                newName: "ITEM_TYPE_ID");

            migrationBuilder.RenameColumn(
                name: "ITEM_ID",
                table: "BLOCKS",
                newName: "ITEM_TYPE_ID");

            migrationBuilder.CreateTable(
                name: "ITEM_TYPE",
                columns: table => new
                {
                    ITEM_TYPE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TYPE = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEM_TYPE", x => x.ITEM_TYPE_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ITEMS_ItemTypeId",
                table: "ITEMS",
                column: "ItemTypeId");

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
    }
}
