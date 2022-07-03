using Microsoft.EntityFrameworkCore.Migrations;

namespace HrSystem.Data.Migrations
{
    public partial class DeleteSomeClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Positions_PositionId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_PreviousExperiences_Employee_EmployeеId",
                table: "PreviousExperiences");

            migrationBuilder.DropTable(
                name: "SkillsAssessments");

            migrationBuilder.DropIndex(
                name: "IX_PreviousExperiences_EmployeеId",
                table: "PreviousExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_PositionId",
                table: "Employees",
                newName: "IX_Employees_PositionId");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "PreviousExperiences",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkillsAssessment",
                table: "Employees",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EmployeePreviousExperienceConnections",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    PreviousExperienceId = table.Column<int>(nullable: false)
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
                        name: "FK_EmployeePreviousExperienceConnections_PreviousExperiences_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "PreviousExperiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreviousExperiences_EmployeeId",
                table: "PreviousExperiences",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Positions_PositionId",
                table: "Employees",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PreviousExperiences_Employees_EmployeeId",
                table: "PreviousExperiences",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Positions_PositionId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_PreviousExperiences_Employees_EmployeeId",
                table: "PreviousExperiences");

            migrationBuilder.DropTable(
                name: "EmployeePreviousExperienceConnections");

            migrationBuilder.DropIndex(
                name: "IX_PreviousExperiences_EmployeeId",
                table: "PreviousExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "PreviousExperiences");

            migrationBuilder.DropColumn(
                name: "SkillsAssessment",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_PositionId",
                table: "Employee",
                newName: "IX_Employee_PositionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SkillsAssessments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    FeedBack = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SkillsRaiting = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsAssessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillsAssessments_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreviousExperiences_EmployeеId",
                table: "PreviousExperiences",
                column: "EmployeеId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsAssessments_EmployeeId",
                table: "SkillsAssessments",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Positions_PositionId",
                table: "Employee",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PreviousExperiences_Employee_EmployeеId",
                table: "PreviousExperiences",
                column: "EmployeеId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
