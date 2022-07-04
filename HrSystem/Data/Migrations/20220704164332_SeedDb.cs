using Microsoft.EntityFrameworkCore.Migrations;

namespace HrSystem.Data.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreviousExperiences_Employees_EmployeeId",
                table: "PreviousExperiences");

            migrationBuilder.DropIndex(
                name: "IX_PreviousExperiences_EmployeeId",
                table: "PreviousExperiences");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "PreviousExperiences");

            migrationBuilder.DropColumn(
                name: "EmployeеId",
                table: "PreviousExperiences");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "RecomendationLetter",
                table: "PreviousExperiences",
                maxLength: 350,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Employees",
                maxLength: 40,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "RecomendationLetter",
                table: "PreviousExperiences",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 350,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "PreviousExperiences",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeеId",
                table: "PreviousExperiences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_PreviousExperiences_EmployeeId",
                table: "PreviousExperiences",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PreviousExperiences_Employees_EmployeeId",
                table: "PreviousExperiences",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
