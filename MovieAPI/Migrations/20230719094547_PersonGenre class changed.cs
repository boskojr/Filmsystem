using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieAPI.Migrations
{
    public partial class PersonGenreclasschanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personGenres_Genres_GenreID",
                table: "personGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_personGenres_Persons_PersonID",
                table: "personGenres");

            migrationBuilder.DropIndex(
                name: "IX_personGenres_GenreID",
                table: "personGenres");

            migrationBuilder.DropIndex(
                name: "IX_personGenres_PersonID",
                table: "personGenres");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_personGenres_GenreID",
                table: "personGenres",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_personGenres_PersonID",
                table: "personGenres",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_personGenres_Genres_GenreID",
                table: "personGenres",
                column: "GenreID",
                principalTable: "Genres",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_personGenres_Persons_PersonID",
                table: "personGenres",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
