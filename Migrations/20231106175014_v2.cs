using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceApp.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_InsuranceSchemes_SchemeId",
                table: "InsurancePolicies");

            migrationBuilder.RenameColumn(
                name: "SchemeId",
                table: "InsurancePolicies",
                newName: "PlanId");

            migrationBuilder.RenameIndex(
                name: "IX_InsurancePolicies_SchemeId",
                table: "InsurancePolicies",
                newName: "IX_InsurancePolicies_PlanId");

            migrationBuilder.AddColumn<int>(
                name: "InsuranceSchemeSchemeId",
                table: "InsurancePolicies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePolicies_InsuranceSchemeSchemeId",
                table: "InsurancePolicies",
                column: "InsuranceSchemeSchemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicies_InsurancePlans_PlanId",
                table: "InsurancePolicies",
                column: "PlanId",
                principalTable: "InsurancePlans",
                principalColumn: "PlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicies_InsuranceSchemes_InsuranceSchemeSchemeId",
                table: "InsurancePolicies",
                column: "InsuranceSchemeSchemeId",
                principalTable: "InsuranceSchemes",
                principalColumn: "SchemeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_InsurancePlans_PlanId",
                table: "InsurancePolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_InsuranceSchemes_InsuranceSchemeSchemeId",
                table: "InsurancePolicies");

            migrationBuilder.DropIndex(
                name: "IX_InsurancePolicies_InsuranceSchemeSchemeId",
                table: "InsurancePolicies");

            migrationBuilder.DropColumn(
                name: "InsuranceSchemeSchemeId",
                table: "InsurancePolicies");

            migrationBuilder.RenameColumn(
                name: "PlanId",
                table: "InsurancePolicies",
                newName: "SchemeId");

            migrationBuilder.RenameIndex(
                name: "IX_InsurancePolicies_PlanId",
                table: "InsurancePolicies",
                newName: "IX_InsurancePolicies_SchemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicies_InsuranceSchemes_SchemeId",
                table: "InsurancePolicies",
                column: "SchemeId",
                principalTable: "InsuranceSchemes",
                principalColumn: "SchemeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
