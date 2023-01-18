using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceLibrary.Data.Data.Data.Menus.Migrations
{
    public partial class changedaverageplayerwinstoaverageplayerwinspercentage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AveragePlayerWins",
                table: "GameResults",
                newName: "AveragePlayerWinsPercentage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AveragePlayerWinsPercentage",
                table: "GameResults",
                newName: "AveragePlayerWins");
        }
    }
}
