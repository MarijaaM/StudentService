using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentService.Server.Migrations
{
    public partial class date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Subjects_Id",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Exams",
                newName: "Date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Exams",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SubjectId",
                table: "Exams",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Subjects_SubjectId",
                table: "Exams",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Subjects_SubjectId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_SubjectId",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Exams",
                newName: "DateTime");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Exams",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Subjects_Id",
                table: "Exams",
                column: "Id",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
