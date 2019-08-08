using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations
{
    public partial class relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "authorId",
                table: "books",
                newName: "authorid");

            migrationBuilder.AlterColumn<long>(
                name: "authorid",
                table: "books",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.CreateIndex(
                name: "IX_books_authorid",
                table: "books",
                column: "authorid");

            migrationBuilder.AddForeignKey(
                name: "FK_books_authors_authorid",
                table: "books",
                column: "authorid",
                principalTable: "authors",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_authors_authorid",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_authorid",
                table: "books");

            migrationBuilder.RenameColumn(
                name: "authorid",
                table: "books",
                newName: "authorId");

            migrationBuilder.AlterColumn<long>(
                name: "authorId",
                table: "books",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);
        }
    }
}
