using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitStudioGym.Migrations
{
    /// <inheritdoc />
    public partial class MakeMembershipPlanOptional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_MembershipPlans_MembershipPlanID",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "MembershipPlanID",
                table: "Members",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_MembershipPlans_MembershipPlanID",
                table: "Members",
                column: "MembershipPlanID",
                principalTable: "MembershipPlans",
                principalColumn: "MembershipPlanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_MembershipPlans_MembershipPlanID",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "MembershipPlanID",
                table: "Members",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_MembershipPlans_MembershipPlanID",
                table: "Members",
                column: "MembershipPlanID",
                principalTable: "MembershipPlans",
                principalColumn: "MembershipPlanID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
