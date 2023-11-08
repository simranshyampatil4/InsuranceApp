using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceApp.Migrations
{
    /// <inheritdoc />
    public partial class v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePlans_InsuranceSchemes_SchemeId",
                table: "InsurancePlans");

            migrationBuilder.DropIndex(
                name: "IX_InsurancePlans_SchemeId",
                table: "InsurancePlans");

            migrationBuilder.DropColumn(
                name: "SchemeId",
                table: "InsurancePlans");

            migrationBuilder.AddColumn<int>(
                name: "PlanId",
                table: "InsuranceSchemes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlanId",
                table: "InsuranceSchemes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceSchemes_PlanId",
                table: "InsuranceSchemes",
                column: "PlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceSchemes_InsurancePlans_PlanId",
                table: "InsuranceSchemes",
                column: "PlanId",
                principalTable: "InsurancePlans",
                principalColumn: "PlanId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceSchemes_InsurancePlans_PlanId",
                table: "InsuranceSchemes");

            migrationBuilder.DropIndex(
                name: "IX_InsuranceSchemes_PlanId",
                table: "InsuranceSchemes");

            migrationBuilder.DropColumn(
                name: "PlanId",
                table: "InsuranceSchemes");

            migrationBuilder.DropColumn(
                name: "PlanId",
                table: "InsuranceSchemes");

            migrationBuilder.AddColumn<int>(
                name: "SchemeId",
                table: "InsurancePlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePlans_SchemeId",
                table: "InsurancePlans",
                column: "SchemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePlans_InsuranceSchemes_SchemeId",
                table: "InsurancePlans",
                column: "SchemeId",
                principalTable: "InsuranceSchemes",
                principalColumn: "SchemeId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
