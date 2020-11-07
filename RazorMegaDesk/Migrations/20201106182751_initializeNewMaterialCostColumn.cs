using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorMegaDesk.Migrations
{
    public partial class initializeNewMaterialCostColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cost",
                table: "SurfaceMaterial",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "SurfaceMaterial");
        }
    }
}
