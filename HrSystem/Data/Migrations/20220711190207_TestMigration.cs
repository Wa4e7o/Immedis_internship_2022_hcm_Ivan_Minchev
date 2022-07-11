using Microsoft.EntityFrameworkCore.Migrations;

namespace HrSystem.Data.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeePreviousExperienceConnections");

            migrationBuilder.AddColumn<int>(
                name: "PreviousExperienceId",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PreviousExperienceId",
                table: "Employees",
                column: "PreviousExperienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PreviousExperiences_PreviousExperienceId",
                table: "Employees",
                column: "PreviousExperienceId",
                principalTable: "PreviousExperiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PreviousExperiences_PreviousExperienceId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PreviousExperienceId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PreviousExperienceId",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "EmployeePreviousExperienceConnections",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PreviousExperienceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePreviousExperienceConnections", x => new { x.EmployeeId, x.PreviousExperienceId });
                    table.ForeignKey(
                        name: "FK_EmployeePreviousExperienceConnections_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeePreviousExperienceConnections_PreviousExperiences_PreviousExperienceId",
                        column: x => x.PreviousExperienceId,
                        principalTable: "PreviousExperiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePreviousExperienceConnections_PreviousExperienceId",
                table: "EmployeePreviousExperienceConnections",
                column: "PreviousExperienceId");
        }
    }
}
