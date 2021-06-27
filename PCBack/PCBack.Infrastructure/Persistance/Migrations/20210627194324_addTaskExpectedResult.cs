using Microsoft.EntityFrameworkCore.Migrations;

namespace PCBack.Infrastructure.Persistance.Migrations
{
    public partial class addTaskExpectedResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Result",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Result",
                table: "Tasks");
        }
    }
}
