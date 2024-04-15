using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieAPI.Migrations
{
    public partial class changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_Genres_GenreID",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Movies_MovieID",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Persons_PersonID",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_GenreID",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_MovieID",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_PersonID",
                table: "Links");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Links_GenreID",
                table: "Links",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Links_MovieID",
                table: "Links",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PersonID",
                table: "Links",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Genres_GenreID",
                table: "Links",
                column: "GenreID",
                principalTable: "Genres",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Movies_MovieID",
                table: "Links",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Persons_PersonID",
                table: "Links",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
