using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KnapSoft.Data.Migrations
{
    /// <inheritdoc />
    public partial class imagesseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/emptyplaceholder.png");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/emptyplaceholder.png");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/emptyplaceholder.png");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/emptyplaceholder.png");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/images/emptyplaceholder.png");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "/images/emptyplaceholder.png");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "/images/emptyplaceholder.png");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/images/emptyplaceholder.png");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "/images/emptyplaceholder.png");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/images/emptyplaceholder.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: null);
        }
    }
}
