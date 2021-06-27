using Microsoft.EntityFrameworkCore.Migrations;

namespace PCBack.Infrastructure.Persistance.Migrations
{
    public partial class addSubmissionCompositeKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Submissions",
                table: "Submissions");

            migrationBuilder.DropIndex(
                name: "IX_Submissions_UserName",
                table: "Submissions");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Submissions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Submissions",
                table: "Submissions",
                columns: new[] { "UserName", "TaskId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Submissions",
                table: "Submissions");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Submissions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Submissions",
                table: "Submissions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_UserName",
                table: "Submissions",
                column: "UserName");
        }
    }
}
