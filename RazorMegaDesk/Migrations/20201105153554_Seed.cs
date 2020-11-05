using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorMegaDesk.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductionTime",
                columns: table => new
                {
                    ProductionTimeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Days = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionTime", x => x.ProductionTimeID);
                });

            migrationBuilder.CreateTable(
                name: "SurfaceMaterial",
                columns: table => new
                {
                    SurfaceMaterialID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurfaceMaterial", x => x.SurfaceMaterialID);
                });

            migrationBuilder.CreateTable(
                name: "Desk",
                columns: table => new
                {
                    DeskID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(maxLength: 255, nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SurfaceMaterialID = table.Column<int>(nullable: false),
                    NumberOfDrawer = table.Column<int>(nullable: false),
                    ProductionTimeID = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desk", x => x.DeskID);
                    table.ForeignKey(
                        name: "FK_Desk_ProductionTime_ProductionTimeID",
                        column: x => x.ProductionTimeID,
                        principalTable: "ProductionTime",
                        principalColumn: "ProductionTimeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Desk_SurfaceMaterial_SurfaceMaterialID",
                        column: x => x.SurfaceMaterialID,
                        principalTable: "SurfaceMaterial",
                        principalColumn: "SurfaceMaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Desk_ProductionTimeID",
                table: "Desk",
                column: "ProductionTimeID");

            migrationBuilder.CreateIndex(
                name: "IX_Desk_SurfaceMaterialID",
                table: "Desk",
                column: "SurfaceMaterialID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Desk");

            migrationBuilder.DropTable(
                name: "ProductionTime");

            migrationBuilder.DropTable(
                name: "SurfaceMaterial");
        }
    }
}
