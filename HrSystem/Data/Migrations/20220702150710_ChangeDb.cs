using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HrSystem.Data.Migrations
{
    public partial class ChangeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreviousExperiences_EmployeeDetails_EmployeeDetailsId",
                table: "PreviousExperiences");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsAssessments_EmployeeDetails_EmployeeDetailsId",
                table: "SkillsAssessments");

            migrationBuilder.DropTable(
                name: "EmployeeDetails");

            migrationBuilder.DropTable(
                name: "EmployeePositions");

            migrationBuilder.DropIndex(
                name: "IX_SkillsAssessments_EmployeeDetailsId",
                table: "SkillsAssessments");

            migrationBuilder.DropIndex(
                name: "IX_PreviousExperiences_EmployeeDetailsId",
                table: "PreviousExperiences");

            migrationBuilder.DropColumn(
                name: "EmployeeDetailsId",
                table: "SkillsAssessments");

            migrationBuilder.DropColumn(
                name: "EmployeeDetailsId",
                table: "PreviousExperiences");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "SkillsAssessments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeеId",
                table: "PreviousExperiences",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(maxLength: 50, nullable: false),
                    DepartmentName = table.Column<string>(maxLength: 35, nullable: false),
                    Salary = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    LastName = table.Column<string>(maxLength: 40, nullable: false),
                    ImageURL = table.Column<string>(nullable: false),
                    Address = table.Column<string>(maxLength: 55, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    MedicalStauts = table.Column<string>(maxLength: 250, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 15, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    PositionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillsAssessments_EmployeeId",
                table: "SkillsAssessments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PreviousExperiences_EmployeеId",
                table: "PreviousExperiences",
                column: "EmployeеId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PositionId",
                table: "Employee",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_PreviousExperiences_Employee_EmployeеId",
                table: "PreviousExperiences",
                column: "EmployeеId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsAssessments_Employee_EmployeeId",
                table: "SkillsAssessments",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreviousExperiences_Employee_EmployeеId",
                table: "PreviousExperiences");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsAssessments_Employee_EmployeeId",
                table: "SkillsAssessments");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_SkillsAssessments_EmployeeId",
                table: "SkillsAssessments");

            migrationBuilder.DropIndex(
                name: "IX_PreviousExperiences_EmployeеId",
                table: "PreviousExperiences");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "SkillsAssessments");

            migrationBuilder.DropColumn(
                name: "EmployeеId",
                table: "PreviousExperiences");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeDetailsId",
                table: "SkillsAssessments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeDetailsId",
                table: "PreviousExperiences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EmployeePositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    PositionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeePositionId = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    MedicalStauts = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_EmployeePositions_EmployeePositionId",
                        column: x => x.EmployeePositionId,
                        principalTable: "EmployeePositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillsAssessments_EmployeeDetailsId",
                table: "SkillsAssessments",
                column: "EmployeeDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_PreviousExperiences_EmployeeDetailsId",
                table: "PreviousExperiences",
                column: "EmployeeDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_EmployeePositionId",
                table: "EmployeeDetails",
                column: "EmployeePositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_PreviousExperiences_EmployeeDetails_EmployeeDetailsId",
                table: "PreviousExperiences",
                column: "EmployeeDetailsId",
                principalTable: "EmployeeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsAssessments_EmployeeDetails_EmployeeDetailsId",
                table: "SkillsAssessments",
                column: "EmployeeDetailsId",
                principalTable: "EmployeeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
