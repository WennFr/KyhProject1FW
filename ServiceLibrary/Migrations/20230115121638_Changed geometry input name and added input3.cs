using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceLibrary.Data.Data.Data.Menus.Migrations
{
    public partial class Changedgeometryinputnameandaddedinput3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Width",
                table: "GeometryResults",
                newName: "Perimeter");

            migrationBuilder.RenameColumn(
                name: "Perimiter",
                table: "GeometryResults",
                newName: "Input3");

            migrationBuilder.RenameColumn(
                name: "Height",
                table: "GeometryResults",
                newName: "Input2");

            migrationBuilder.AddColumn<double>(
                name: "Input1",
                table: "GeometryResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Input1",
                table: "GeometryResults");

            migrationBuilder.RenameColumn(
                name: "Perimeter",
                table: "GeometryResults",
                newName: "Width");

            migrationBuilder.RenameColumn(
                name: "Input3",
                table: "GeometryResults",
                newName: "Perimiter");

            migrationBuilder.RenameColumn(
                name: "Input2",
                table: "GeometryResults",
                newName: "Height");
        }
    }
}
