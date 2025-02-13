using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class joinedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemTypeId",
                table: "ITEMS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ItemTypes",
                columns: table => new
                {
                    ITEM_TYPE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypes", x => x.ITEM_TYPE_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "STRUCTURES",
                columns: table => new
                {
                    STRUCTURE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STRUCTURES", x => x.STRUCTURE_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BLOCKS",
                columns: table => new
                {
                    ITEM_TYPE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLOCKS", x => x.ITEM_TYPE_ID);
                    table.ForeignKey(
                        name: "FK_BLOCKS_ItemTypes_ITEM_TYPE_ID",
                        column: x => x.ITEM_TYPE_ID,
                        principalTable: "ItemTypes",
                        principalColumn: "ITEM_TYPE_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ENTITIES",
                columns: table => new
                {
                    ITEM_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "varchar(350)", maxLength: 350, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENTITIES", x => x.ITEM_TYPE_ID);
                    table.ForeignKey(
                        name: "FK_ENTITIES_ItemTypes_ITEM_TYPE_ID",
                        column: x => x.ITEM_TYPE_ID,
                        principalTable: "ItemTypes",
                        principalColumn: "ITEM_TYPE_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TOOLS",
                columns: table => new
                {
                    ITEM_TYPE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TOOLS", x => x.ITEM_TYPE_ID);
                    table.ForeignKey(
                        name: "FK_TOOLS_ItemTypes_ITEM_TYPE_ID",
                        column: x => x.ITEM_TYPE_ID,
                        principalTable: "ItemTypes",
                        principalColumn: "ITEM_TYPE_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WEAPONS",
                columns: table => new
                {
                    ITEM_TYPE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WEAPONS", x => x.ITEM_TYPE_ID);
                    table.ForeignKey(
                        name: "FK_WEAPONS_ItemTypes_ITEM_TYPE_ID",
                        column: x => x.ITEM_TYPE_ID,
                        principalTable: "ItemTypes",
                        principalColumn: "ITEM_TYPE_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ITEMS_ItemTypeId",
                table: "ITEMS",
                column: "ItemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ITEMS_ItemTypes_ItemTypeId",
                table: "ITEMS",
                column: "ItemTypeId",
                principalTable: "ItemTypes",
                principalColumn: "ITEM_TYPE_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ITEMS_ItemTypes_ItemTypeId",
                table: "ITEMS");

            migrationBuilder.DropTable(
                name: "BLOCKS");

            migrationBuilder.DropTable(
                name: "ENTITIES");

            migrationBuilder.DropTable(
                name: "STRUCTURES");

            migrationBuilder.DropTable(
                name: "TOOLS");

            migrationBuilder.DropTable(
                name: "WEAPONS");

            migrationBuilder.DropTable(
                name: "ItemTypes");

            migrationBuilder.DropIndex(
                name: "IX_ITEMS_ItemTypeId",
                table: "ITEMS");

            migrationBuilder.DropColumn(
                name: "ItemTypeId",
                table: "ITEMS");
        }
    }
}
