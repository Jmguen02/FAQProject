using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQProject.Migrations
{
    public partial class Topic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TopicId",
                table: "FAQs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicId = table.Column<string>(nullable: false),
                    TopicName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicId);
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "TopicName" },
                values: new object[] { "Bs", "Bootstrap" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "TopicName" },
                values: new object[] { "C", "C#" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "TopicName" },
                values: new object[] { "Js", "JavaScript" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 1,
                column: "TopicId",
                value: "Js");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 2,
                column: "TopicId",
                value: "Js");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 3,
                column: "TopicId",
                value: "Bs");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 4,
                column: "TopicId",
                value: "Bs");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 5,
                column: "TopicId",
                value: "C");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 6,
                column: "TopicId",
                value: "C");

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_TopicId",
                table: "FAQs",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_FAQs_Topics_TopicId",
                table: "FAQs",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "TopicId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FAQs_Topics_TopicId",
                table: "FAQs");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_FAQs_TopicId",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "FAQs");
        }
    }
}
