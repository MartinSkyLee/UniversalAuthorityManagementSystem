using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversalAuthorityManagement.Models.Migrations
{
    public partial class AddTableTbApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "app_id",
                table: "tb_roles",
                type: "int(11)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tb_application",
                columns: table => new
                {
                    app_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    app_name = table.Column<string>(type: "varchar(50)", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    create_user_id = table.Column<int>(type: "int(11)", nullable: true),
                    create_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    update_user_id = table.Column<int>(type: "int(11)", nullable: true),
                    update_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_delete = table.Column<short>(type: "bit(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_application", x => x.app_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_roles_app_id",
                table: "tb_roles",
                column: "app_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Roles",
                table: "tb_roles",
                column: "app_id",
                principalTable: "tb_application",
                principalColumn: "app_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_Roles",
                table: "tb_roles");

            migrationBuilder.DropTable(
                name: "tb_application");

            migrationBuilder.DropIndex(
                name: "IX_tb_roles_app_id",
                table: "tb_roles");

            migrationBuilder.DropColumn(
                name: "app_id",
                table: "tb_roles");
        }
    }
}
