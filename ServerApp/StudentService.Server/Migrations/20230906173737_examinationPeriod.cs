using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentService.Server.Migrations
{
    public partial class examinationPeriod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "SubjectId",
                table: "Exams",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "ExaminationPeriod",
                table: "Exams",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExaminationPeriod",
                table: "Exams");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectId",
                table: "Exams",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");
        }
    }
}
