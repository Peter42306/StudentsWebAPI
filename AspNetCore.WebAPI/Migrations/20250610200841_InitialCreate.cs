using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetCore.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    GPA = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "GPA", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, 33, 12.0, "Frodo", "Baggins" },
                    { 2, 35, 11.5, "Samwise", "Gamgee" },
                    { 3, 30, 10.800000000000001, "Meriadoc", "Brandybuck" },
                    { 4, 29, 10.199999999999999, "Peregrin", "Took" },
                    { 5, 45, 13.0, "Aragorn", "Elessar" },
                    { 6, 140, 11.699999999999999, "Gimli", "Son of Glóin" },
                    { 7, 2931, 13.5, "Legolas", "Greenleaf" },
                    { 8, 41, 9.9000000000000004, "Boromir", "of Gondor" },
                    { 9, 2019, 14.0, "Gandalf", "the Grey" },
                    { 10, 589, 6.5999999999999996, "Gollum", "Smeagol" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
