using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_rileyrm.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieForumID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieForumID);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieForumID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Superhero", "James Mangold", true, "none", "Best superhero movie", "R", "Logan", 2017 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieForumID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Superhero", "Christopher Nolan", false, "none", "Second best superhero movie", "PG-13", "Dark Knight", 2008 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieForumID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action", "Edgar Wright", true, "none", "Like Fast and Furious but better", "R", "Baby Driver", 2017 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
