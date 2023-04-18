using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRequirementType_EmployeeType_EmployeeTypeId",
                table: "EmployeeRequirementType");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRequirementType_JobRequirement_JobRequirementId",
                table: "EmployeeRequirementType");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRequirement_JobCategory_JobCategoryId",
                table: "JobRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_Submission_SubmissionId",
                table: "Status");

            migrationBuilder.DropForeignKey(
                name: "FK_Submission_Candidates_CandidateId",
                table: "Submission");

            migrationBuilder.DropForeignKey(
                name: "FK_Submission_JobRequirement_JobRequirementId",
                table: "Submission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Submission",
                table: "Submission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobRequirement",
                table: "JobRequirement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobCategory",
                table: "JobCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeType",
                table: "EmployeeType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeRequirementType",
                table: "EmployeeRequirementType");

            migrationBuilder.RenameTable(
                name: "Submission",
                newName: "Submissions");

            migrationBuilder.RenameTable(
                name: "JobRequirement",
                newName: "JobRequirements");

            migrationBuilder.RenameTable(
                name: "JobCategory",
                newName: "JobCategories");

            migrationBuilder.RenameTable(
                name: "EmployeeType",
                newName: "EmployeeTypes");

            migrationBuilder.RenameTable(
                name: "EmployeeRequirementType",
                newName: "EmployeeRequirementTypes");

            migrationBuilder.RenameIndex(
                name: "IX_Submission_JobRequirementId",
                table: "Submissions",
                newName: "IX_Submissions_JobRequirementId");

            migrationBuilder.RenameIndex(
                name: "IX_Submission_CandidateId",
                table: "Submissions",
                newName: "IX_Submissions_CandidateId");

            migrationBuilder.RenameIndex(
                name: "IX_JobRequirement_JobCategoryId",
                table: "JobRequirements",
                newName: "IX_JobRequirements_JobCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeRequirementType_JobRequirementId",
                table: "EmployeeRequirementTypes",
                newName: "IX_EmployeeRequirementTypes_JobRequirementId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeRequirementType_EmployeeTypeId",
                table: "EmployeeRequirementTypes",
                newName: "IX_EmployeeRequirementTypes_EmployeeTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "ResumeURL",
                table: "Candidates",
                type: "varchar(1000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidates",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Submissions",
                table: "Submissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobRequirements",
                table: "JobRequirements",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobCategories",
                table: "JobCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeTypes",
                table: "EmployeeTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeRequirementTypes",
                table: "EmployeeRequirementTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRequirementTypes_EmployeeTypes_EmployeeTypeId",
                table: "EmployeeRequirementTypes",
                column: "EmployeeTypeId",
                principalTable: "EmployeeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRequirementTypes_JobRequirements_JobRequirementId",
                table: "EmployeeRequirementTypes",
                column: "JobRequirementId",
                principalTable: "JobRequirements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRequirements_JobCategories_JobCategoryId",
                table: "JobRequirements",
                column: "JobCategoryId",
                principalTable: "JobCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Status_Submissions_SubmissionId",
                table: "Status",
                column: "SubmissionId",
                principalTable: "Submissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Submissions_Candidates_CandidateId",
                table: "Submissions",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Submissions_JobRequirements_JobRequirementId",
                table: "Submissions",
                column: "JobRequirementId",
                principalTable: "JobRequirements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRequirementTypes_EmployeeTypes_EmployeeTypeId",
                table: "EmployeeRequirementTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRequirementTypes_JobRequirements_JobRequirementId",
                table: "EmployeeRequirementTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRequirements_JobCategories_JobCategoryId",
                table: "JobRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_Submissions_SubmissionId",
                table: "Status");

            migrationBuilder.DropForeignKey(
                name: "FK_Submissions_Candidates_CandidateId",
                table: "Submissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Submissions_JobRequirements_JobRequirementId",
                table: "Submissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Submissions",
                table: "Submissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobRequirements",
                table: "JobRequirements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobCategories",
                table: "JobCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeTypes",
                table: "EmployeeTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeRequirementTypes",
                table: "EmployeeRequirementTypes");

            migrationBuilder.RenameTable(
                name: "Submissions",
                newName: "Submission");

            migrationBuilder.RenameTable(
                name: "JobRequirements",
                newName: "JobRequirement");

            migrationBuilder.RenameTable(
                name: "JobCategories",
                newName: "JobCategory");

            migrationBuilder.RenameTable(
                name: "EmployeeTypes",
                newName: "EmployeeType");

            migrationBuilder.RenameTable(
                name: "EmployeeRequirementTypes",
                newName: "EmployeeRequirementType");

            migrationBuilder.RenameIndex(
                name: "IX_Submissions_JobRequirementId",
                table: "Submission",
                newName: "IX_Submission_JobRequirementId");

            migrationBuilder.RenameIndex(
                name: "IX_Submissions_CandidateId",
                table: "Submission",
                newName: "IX_Submission_CandidateId");

            migrationBuilder.RenameIndex(
                name: "IX_JobRequirements_JobCategoryId",
                table: "JobRequirement",
                newName: "IX_JobRequirement_JobCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeRequirementTypes_JobRequirementId",
                table: "EmployeeRequirementType",
                newName: "IX_EmployeeRequirementType_JobRequirementId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeRequirementTypes_EmployeeTypeId",
                table: "EmployeeRequirementType",
                newName: "IX_EmployeeRequirementType_EmployeeTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "ResumeURL",
                table: "Candidates",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1000)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidates",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Submission",
                table: "Submission",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobRequirement",
                table: "JobRequirement",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobCategory",
                table: "JobCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeType",
                table: "EmployeeType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeRequirementType",
                table: "EmployeeRequirementType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRequirementType_EmployeeType_EmployeeTypeId",
                table: "EmployeeRequirementType",
                column: "EmployeeTypeId",
                principalTable: "EmployeeType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRequirementType_JobRequirement_JobRequirementId",
                table: "EmployeeRequirementType",
                column: "JobRequirementId",
                principalTable: "JobRequirement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRequirement_JobCategory_JobCategoryId",
                table: "JobRequirement",
                column: "JobCategoryId",
                principalTable: "JobCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Status_Submission_SubmissionId",
                table: "Status",
                column: "SubmissionId",
                principalTable: "Submission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Submission_Candidates_CandidateId",
                table: "Submission",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Submission_JobRequirement_JobRequirementId",
                table: "Submission",
                column: "JobRequirementId",
                principalTable: "JobRequirement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
