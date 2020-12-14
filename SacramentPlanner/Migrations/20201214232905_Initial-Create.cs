using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bishopric",
                columns: table => new
                {
                    BishopricId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    BishopricName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bishopric", x => x.BishopricId);
                });

            migrationBuilder.CreateTable(
                name: "Planner",
                columns: table => new
                {
                    PlannerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BishopricId = table.Column<int>(type: "int", nullable: false),
                    OpenPrayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosePrayer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planner", x => x.PlannerId);
                    table.ForeignKey(
                        name: "FK_Planner_Bishopric_BishopricId",
                        column: x => x.BishopricId,
                        principalTable: "Bishopric",
                        principalColumn: "BishopricId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlannerId = table.Column<int>(type: "int", nullable: false),
                    OpenSongNum = table.Column<int>(type: "int", nullable: false),
                    OpenSongTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SacramentSongNum = table.Column<int>(type: "int", nullable: false),
                    SacramentSongTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterSongNum = table.Column<int>(type: "int", nullable: true),
                    InterSongTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloseSongNum = table.Column<int>(type: "int", nullable: false),
                    CloseSongTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Songs_Planner_PlannerId",
                        column: x => x.PlannerId,
                        principalTable: "Planner",
                        principalColumn: "PlannerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    SpeakerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlannerId = table.Column<int>(type: "int", nullable: false),
                    SpeakerName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    SpeakerTopic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.SpeakerId);
                    table.ForeignKey(
                        name: "FK_Speakers_Planner_PlannerId",
                        column: x => x.PlannerId,
                        principalTable: "Planner",
                        principalColumn: "PlannerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Planner_BishopricId",
                table: "Planner",
                column: "BishopricId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_PlannerId",
                table: "Songs",
                column: "PlannerId");

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_PlannerId",
                table: "Speakers",
                column: "PlannerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Speakers");

            migrationBuilder.DropTable(
                name: "Planner");

            migrationBuilder.DropTable(
                name: "Bishopric");
        }
    }
}
