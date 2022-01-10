using Microsoft.EntityFrameworkCore.Migrations;

namespace InventorySystemDataAccess.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Attributes-Value_AttributeValue_ID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AttributeValue_ID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AttributeValue_ID",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Color_ID",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size_ID",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Color_ID",
                table: "Products",
                column: "Color_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Size_ID",
                table: "Products",
                column: "Size_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Attributes-Value_Color_ID",
                table: "Products",
                column: "Color_ID",
                principalTable: "Attributes-Value",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Attributes-Value_Size_ID",
                table: "Products",
                column: "Size_ID",
                principalTable: "Attributes-Value",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Attributes-Value_Color_ID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Attributes-Value_Size_ID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Color_ID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Size_ID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Color_ID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size_ID",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "AttributeValue_ID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_AttributeValue_ID",
                table: "Products",
                column: "AttributeValue_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Attributes-Value_AttributeValue_ID",
                table: "Products",
                column: "AttributeValue_ID",
                principalTable: "Attributes-Value",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
