using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class nameToItemType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NAME",
                table: "BLOCKS");

            migrationBuilder.AddColumn<string>(
                name: "NAME",
                table: "ItemTypes",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NAME",
                table: "ItemTypes");

            migrationBuilder.AddColumn<string>(
                name: "NAME",
                table: "BLOCKS",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
