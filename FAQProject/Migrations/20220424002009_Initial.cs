using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    FAQId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FAQQuestion = table.Column<string>(nullable: true),
                    FAQAnswer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.FAQId);
                });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "FAQId", "FAQAnswer", "FAQQuestion" },
                values: new object[,]
                {
                    { 1, "A general purpose scripting language that executes in a web browser.", "What is JavaScript?" },
                    { 2, "In 1995.", "When was JavaScript first released?" },
                    { 3, "Bootstrap is the most popular CSS Framework for developing responsive and mobile-first websites.", "What is Bootstrap?" },
                    { 4, "In 2011", "When was Bootstrap first released?" },
                    { 5, "C# is a modern, object-oriented, and type-safe programming language.", "What is C#?" },
                    { 6, "In 2002.", "When was C# first released?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQs");
        }
    }
}
