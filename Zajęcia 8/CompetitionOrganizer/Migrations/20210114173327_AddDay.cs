using Microsoft.EntityFrameworkCore.Migrations;

namespace CompetitionOrganizer.Migrations
{
    public partial class AddDay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Matches",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Competitions",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Matches");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Competitions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);
        }
    }
}
