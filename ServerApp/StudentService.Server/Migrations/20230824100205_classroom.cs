using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentService.Server.Migrations
{
    public partial class classroom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClassRoom",
                table: "Exams",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassRoom",
                table: "Exams");
        }
    }
}
