using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversalAuthorityManagement.Models.Migrations
{
    public partial class AddFKTbApplicationTbMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "app_id",
                table: "tb_menu",
                type: "int(11)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_menu_app_id",
                table: "tb_menu",
                column: "app_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Menu",
                table: "tb_menu",
                column: "app_id",
                principalTable: "tb_application",
                principalColumn: "app_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_Menu",
                table: "tb_menu");

            migrationBuilder.DropIndex(
                name: "IX_tb_menu_app_id",
                table: "tb_menu");

            migrationBuilder.DropColumn(
                name: "app_id",
                table: "tb_menu");
        }
    }
}
