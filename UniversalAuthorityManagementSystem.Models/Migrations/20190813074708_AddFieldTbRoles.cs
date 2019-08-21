using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversalAuthorityManagement.Models.Migrations
{
    public partial class AddFieldTbRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "is_built_in_role",
                table: "tb_roles",
                type: "bit(1)",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "is_super_administrator",
                table: "tb_roles",
                type: "bit(1)",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "is_system_admin",
                table: "tb_roles",
                type: "bit(1)",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_built_in_role",
                table: "tb_roles");

            migrationBuilder.DropColumn(
                name: "is_super_administrator",
                table: "tb_roles");

            migrationBuilder.DropColumn(
                name: "is_system_admin",
                table: "tb_roles");
        }
    }
}
