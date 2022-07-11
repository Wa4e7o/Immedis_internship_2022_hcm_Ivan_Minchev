using Microsoft.EntityFrameworkCore.Migrations;

namespace HrSystem.Data.Migrations
{
    public partial class NewDbAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePreviousExperienceConnections_PreviousExperiences_EmployeeId",
                table: "EmployeePreviousExperienceConnections");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePreviousExperienceConnections_PreviousExperienceId",
                table: "EmployeePreviousExperienceConnections",
                column: "PreviousExperienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePreviousExperienceConnections_PreviousExperiences_PreviousExperienceId",
                table: "EmployeePreviousExperienceConnections",
                column: "PreviousExperienceId",
                principalTable: "PreviousExperiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePreviousExperienceConnections_PreviousExperiences_PreviousExperienceId",
                table: "EmployeePreviousExperienceConnections");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePreviousExperienceConnections_PreviousExperienceId",
                table: "EmployeePreviousExperienceConnections");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePreviousExperienceConnections_PreviousExperiences_EmployeeId",
                table: "EmployeePreviousExperienceConnections",
                column: "EmployeeId",
                principalTable: "PreviousExperiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
