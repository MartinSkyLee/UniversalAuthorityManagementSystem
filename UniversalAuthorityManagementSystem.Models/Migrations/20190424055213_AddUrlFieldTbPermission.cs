using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversalAuthorityManagement.Models.Migrations
{
    public partial class AddUrlFieldTbPermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "url",
                table: "tb_permission",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "url",
                table: "tb_permission");
        }
    }
}
