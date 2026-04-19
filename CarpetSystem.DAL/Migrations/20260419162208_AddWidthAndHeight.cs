using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarpetSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddWidthAndHeight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "height",
                table: "Product",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "width",
                table: "Product",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "height",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "width",
                table: "Product");
        }
    }
}
