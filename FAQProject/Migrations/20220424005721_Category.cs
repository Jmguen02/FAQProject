using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQProject.Migrations
{
    public partial class Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "FAQs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { "G", "General" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { "H", "Histroy" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 1,
                column: "CategoryId",
                value: "G");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 2,
                column: "CategoryId",
                value: "H");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 3,
                column: "CategoryId",
                value: "G");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 4,
                column: "CategoryId",
                value: "H");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 5,
                column: "CategoryId",
                value: "G");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 6,
                column: "CategoryId",
                value: "H");

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_CategoryId",
                table: "FAQs",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_FAQs_Categories_CategoryId",
                table: "FAQs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FAQs_Categories_CategoryId",
                table: "FAQs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_FAQs_CategoryId",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "FAQs");
        }
    }
}
