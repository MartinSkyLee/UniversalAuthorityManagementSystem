using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversalAuthorityManagement.Models.Migrations
{
    public partial class AddFieldTbSysUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "create_time",
                table: "tb_sys_user",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "create_user_id",
                table: "tb_sys_user",
                type: "int(11)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "update_time",
                table: "tb_sys_user",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "update_user_id",
                table: "tb_sys_user",
                type: "int(11)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "create_time",
                table: "tb_sys_user");

            migrationBuilder.DropColumn(
                name: "create_user_id",
                table: "tb_sys_user");

            migrationBuilder.DropColumn(
                name: "update_time",
                table: "tb_sys_user");

            migrationBuilder.DropColumn(
                name: "update_user_id",
                table: "tb_sys_user");
        }
    }
}
