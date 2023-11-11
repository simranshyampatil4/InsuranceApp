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
                name: "FK_InsurancePolicies_Customers_CustomerId",
                table: "InsurancePolicies");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "InsurancePolicies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicies_Customers_CustomerId",
                table: "InsurancePolicies",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_Customers_CustomerId",
                table: "InsurancePolicies");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "InsurancePolicies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicies_Customers_CustomerId",
                table: "InsurancePolicies",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");
        }
    }
}
