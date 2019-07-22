using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversalAuthorityManagement.Models.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_menu",
                columns: table => new
                {
                    menu_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    menu_name = table.Column<string>(type: "varchar(50)", nullable: true),
                    url = table.Column<string>(type: "text", nullable: true),
                    level = table.Column<int>(type: "int(11)", nullable: true),
                    parent_menu_id = table.Column<int>(type: "int(11)", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    icon = table.Column<string>(type: "varchar(20)", nullable: true),
                    device_type_id = table.Column<int>(type: "int(11)", nullable: false),
                    create_user_id = table.Column<int>(type: "int(11)", nullable: true),
                    create_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    update_user_id = table.Column<int>(type: "int(11)", nullable: true),
                    update_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_delete = table.Column<short>(type: "bit(1)", nullable: true),
                    menu_order = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_menu", x => x.menu_id);
                });

            migrationBuilder.CreateTable(
                name: "tb_roles",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    role_name = table.Column<string>(type: "varchar(50)", nullable: true),
                    use_yn = table.Column<short>(type: "bit(1)", nullable: true),
                    create_user_id = table.Column<int>(type: "int(11)", nullable: true),
                    create_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    update_user_id = table.Column<int>(type: "int(11)", nullable: true),
                    update_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_delete = table.Column<short>(type: "bit(1)", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_roles", x => x.role_id);
                });

            migrationBuilder.CreateTable(
                name: "tb_sys_user",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    sys_user_name = table.Column<string>(type: "varchar(50)", nullable: true),
                    password = table.Column<string>(type: "varchar(50)", nullable: true),
                    mobile = table.Column<long>(type: "bigint(20)", nullable: true),
                    email = table.Column<string>(type: "varchar(100)", nullable: true),
                    position = table.Column<string>(type: "text", nullable: true),
                    telephone = table.Column<string>(type: "varchar(50)", nullable: true),
                    is_delete = table.Column<short>(type: "bit(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_sys_user", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "tb_permission",
                columns: table => new
                {
                    permission_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    permission_name = table.Column<string>(type: "varchar(50)", nullable: true),
                    menu_id = table.Column<int>(type: "int(11)", nullable: true),
                    permission_type = table.Column<string>(type: "varchar(50)", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    create_user_id = table.Column<int>(type: "int(11)", nullable: true),
                    create_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    update_user_id = table.Column<int>(type: "int(11)", nullable: true),
                    update_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_delete = table.Column<short>(type: "bit(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_permission", x => x.permission_id);
                    table.ForeignKey(
                        name: "FK_Reference_23",
                        column: x => x.menu_id,
                        principalTable: "tb_menu",
                        principalColumn: "menu_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_user_role",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    user_id = table.Column<int>(type: "int(11)", nullable: true),
                    role_id = table.Column<int>(type: "int(11)", nullable: true),
                    use_yn = table.Column<short>(type: "bit(1)", nullable: true),
                    create_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    create_user_id = table.Column<int>(type: "int(11)", nullable: true),
                    update_user_id = table.Column<int>(type: "int(11)", nullable: true),
                    update_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_delete = table.Column<short>(type: "bit(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_user_role", x => x.id);
                    table.ForeignKey(
                        name: "FK_Role_RoleUser",
                        column: x => x.role_id,
                        principalTable: "tb_roles",
                        principalColumn: "role_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_UserRole",
                        column: x => x.user_id,
                        principalTable: "tb_sys_user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_role_permission",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    role_id = table.Column<int>(type: "int(11)", nullable: true),
                    permission_id = table.Column<int>(type: "int(11)", nullable: true),
                    use_yn = table.Column<short>(type: "bit(1)", nullable: true),
                    create_user_id = table.Column<int>(type: "int(11)", nullable: true),
                    create_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    update_user_id = table.Column<int>(type: "int(11)", nullable: true),
                    update_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_delete = table.Column<short>(type: "bit(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_role_permission", x => x.id);
                    table.ForeignKey(
                        name: "FK_Permiss_RolePermiss",
                        column: x => x.permission_id,
                        principalTable: "tb_permission",
                        principalColumn: "permission_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Role_RolePermiss",
                        column: x => x.role_id,
                        principalTable: "tb_roles",
                        principalColumn: "role_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "FK_Reference_23",
                table: "tb_permission",
                column: "menu_id");

            migrationBuilder.CreateIndex(
                name: "FK_Permiss_RolePermiss",
                table: "tb_role_permission",
                column: "permission_id");

            migrationBuilder.CreateIndex(
                name: "FK_Role_RolePermiss",
                table: "tb_role_permission",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "FK_Role_RoleUser",
                table: "tb_user_role",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "FK_User_UserRole",
                table: "tb_user_role",
                column: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_role_permission");

            migrationBuilder.DropTable(
                name: "tb_user_role");

            migrationBuilder.DropTable(
                name: "tb_permission");

            migrationBuilder.DropTable(
                name: "tb_roles");

            migrationBuilder.DropTable(
                name: "tb_sys_user");

            migrationBuilder.DropTable(
                name: "tb_menu");
        }
    }
}
