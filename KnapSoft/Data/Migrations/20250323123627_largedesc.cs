using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KnapSoft.Data.Migrations
{
    /// <inheritdoc />
    public partial class largedesc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LargeDescription",
                table: "Solutions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "LargeDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "LargeDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 3,
                column: "LargeDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 4,
                column: "LargeDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 5,
                column: "LargeDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 6,
                column: "LargeDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 7,
                column: "LargeDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 8,
                column: "LargeDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 9,
                column: "LargeDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 10,
                column: "LargeDescription",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LargeDescription",
                table: "Solutions");
        }
    }
}
