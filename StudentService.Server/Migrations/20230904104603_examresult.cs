using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentService.Server.Migrations
{
    public partial class examresult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Subjects_SubjectId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Users_StudentId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_StudentId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_SubjectId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "Mark",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "Results",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Exams");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectId",
                table: "Exams",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Exams",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateTable(
                name: "ExamResults",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Mark = table.Column<int>(type: "INTEGER", nullable: false),
                    ExamId = table.Column<long>(type: "INTEGER", nullable: false),
                    StudentId = table.Column<long>(type: "INTEGER", nullable: false),
                    Results = table.Column<int>(type: "INTEGER", nullable: false),
                    PassedOrNot = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamResults_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamResults_Users_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamResults_ExamId",
                table: "ExamResults",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamResults_StudentId",
                table: "ExamResults",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Subjects_Id",
                table: "Exams",
                column: "Id",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Subjects_Id",
                table: "Exams");

            migrationBuilder.DropTable(
                name: "ExamResults");

            migrationBuilder.AlterColumn<long>(
                name: "SubjectId",
                table: "Exams",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Exams",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Mark",
                table: "Exams",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Results",
                table: "Exams",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "StudentId",
                table: "Exams",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_StudentId",
                table: "Exams",
                column: "StudentId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Users_StudentId",
                table: "Exams",
                column: "StudentId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
