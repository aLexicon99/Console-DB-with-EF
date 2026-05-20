using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_ConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class removedRockerIdfromCrewMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RocketId",
                table: "CrewMembers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RocketId",
                table: "CrewMembers",
                type: "int",
                nullable: true);
        }
    }
}
