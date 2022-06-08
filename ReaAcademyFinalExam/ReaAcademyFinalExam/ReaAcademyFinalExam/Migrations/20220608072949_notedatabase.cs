using Microsoft.EntityFrameworkCore.Migrations;

namespace ReaAcademyFinalExam.Migrations
{
    public partial class notedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    tagID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tagName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.tagID);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    noteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noteContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoriescategoryID = table.Column<int>(type: "int", nullable: true),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tagstagID = table.Column<int>(type: "int", nullable: true),
                    tagName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.noteID);
                    table.ForeignKey(
                        name: "FK_Notes_Categories_categoriescategoryID",
                        column: x => x.categoriescategoryID,
                        principalTable: "Categories",
                        principalColumn: "categoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notes_Tags_tagstagID",
                        column: x => x.tagstagID,
                        principalTable: "Tags",
                        principalColumn: "tagID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_categoriescategoryID",
                table: "Notes",
                column: "categoriescategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_tagstagID",
                table: "Notes",
                column: "tagstagID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
