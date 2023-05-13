using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopProject.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTypes_Books_BookId",
                table: "BookTypes");

            migrationBuilder.DropIndex(
                name: "IX_BookTypes_BookId",
                table: "BookTypes");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "BookTypes");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "BookTypeId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookTypeId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "BookTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_BookTypes_BookId",
                table: "BookTypes",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTypes_Books_BookId",
                table: "BookTypes",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
