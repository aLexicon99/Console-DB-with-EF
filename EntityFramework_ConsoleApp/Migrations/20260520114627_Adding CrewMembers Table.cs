using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_ConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class AddingCrewMembersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrewMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RocketId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewMembers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrewMemberRocket",
                columns: table => new
                {
                    CrewMembersId = table.Column<int>(type: "int", nullable: false),
                    RocketsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewMemberRocket", x => new { x.CrewMembersId, x.RocketsId });
                    table.ForeignKey(
                        name: "FK_CrewMemberRocket_CrewMembers_CrewMembersId",
                        column: x => x.CrewMembersId,
                        principalTable: "CrewMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrewMemberRocket_Rockets_RocketsId",
                        column: x => x.RocketsId,
                        principalTable: "Rockets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CrewMemberRocket_RocketsId",
                table: "CrewMemberRocket",
                column: "RocketsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrewMemberRocket");

            migrationBuilder.DropTable(
                name: "CrewMembers");
        }
    }
}
