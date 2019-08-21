﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversalAuthorityManagement.Models.DBEntities;

namespace UniversalAuthorityManagement.Models.Migrations
{
    [DbContext(typeof(UniversalAuthorityManagementContext))]
    [Migration("20190815070612_AddFieldTbSysUser")]
    partial class AddFieldTbSysUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("UniversalAuthorityManagement.Models.DBEntities.TbApplication", b =>
                {
                    b.Property<int>("AppId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("app_id")
                        .HasColumnType("int(11)");

                    b.Property<string>("AppName")
                        .HasColumnName("app_name")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnName("create_time")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreateUserId")
                        .HasColumnName("create_user_id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<short?>("IsDelete")
                        .HasColumnName("is_delete")
                        .HasColumnType("bit(1)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnName("update_time")
                        .HasColumnType("datetime");

                    b.Property<int?>("UpdateUserId")
                        .HasColumnName("update_user_id")
                        .HasColumnType("int(11)");

                    b.HasKey("AppId");

                    b.ToTable("tb_application");
                });

            modelBuilder.Entity("UniversalAuthorityManagement.Models.DBEntities.TbMenu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("menu_id")
                        .HasColumnType("int(11)");

                    b.Property<int?>("AppId")
                        .HasColumnName("app_id")
                        .HasColumnType("int(11)");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnName("create_time")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreateUserId")
                        .HasColumnName("create_user_id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<int>("DeviceTypeId")
                        .HasColumnName("device_type_id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Icon")
                        .HasColumnName("icon")
                        .HasColumnType("varchar(20)");

                    b.Property<short?>("IsDelete")
                        .HasColumnName("is_delete")
                        .HasColumnType("bit(1)");

                    b.Property<int?>("Level")
                        .HasColumnName("level")
                        .HasColumnType("int(11)");

                    b.Property<string>("MenuName")
                        .HasColumnName("menu_name")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("MenuOrder")
                        .HasColumnName("menu_order")
                        .HasColumnType("int(11)");

                    b.Property<int?>("ParentMenuId")
                        .HasColumnName("parent_menu_id")
                        .HasColumnType("int(11)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnName("update_time")
                        .HasColumnType("datetime");

                    b.Property<int?>("UpdateUserId")
                        .HasColumnName("update_user_id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Url")
                        .HasColumnName("url")
                        .HasColumnType("text");

                    b.HasKey("MenuId");

                    b.HasIndex("AppId");

                    b.ToTable("tb_menu");
                });

            modelBuilder.Entity("UniversalAuthorityManagement.Models.DBEntities.TbPermission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("permission_id")
                        .HasColumnType("int(11)");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnName("create_time")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreateUserId")
                        .HasColumnName("create_user_id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<short?>("IsDelete")
                        .HasColumnName("is_delete")
                        .HasColumnType("bit(1)");

                    b.Property<int?>("MenuId")
                        .HasColumnName("menu_id")
                        .HasColumnType("int(11)");

                    b.Property<string>("PermissionName")
                        .HasColumnName("permission_name")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PermissionType")
                        .HasColumnName("permission_type")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnName("update_time")
                        .HasColumnType("datetime");

                    b.Property<int?>("UpdateUserId")
                        .HasColumnName("update_user_id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Url")
                        .HasColumnName("url")
                        .HasColumnType("text");

                    b.HasKey("PermissionId");

                    b.HasIndex("MenuId")
                        .HasName("FK_Reference_23");

                    b.ToTable("tb_permission");
                });

            modelBuilder.Entity("UniversalAuthorityManagement.Models.DBEntities.TbRolePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnName("create_time")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreateUserId")
                        .HasColumnName("create_user_id")
                        .HasColumnType("int(11)");

                    b.Property<short?>("IsDelete")
                        .HasColumnName("is_delete")
                        .HasColumnType("bit(1)");

                    b.Property<int?>("PermissionId")
                        .HasColumnName("permission_id")
                        .HasColumnType("int(11)");

                    b.Property<int?>("RoleId")
                        .HasColumnName("role_id")
                        .HasColumnType("int(11)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnName("update_time")
                        .HasColumnType("datetime");

                    b.Property<int?>("UpdateUserId")
                        .HasColumnName("update_user_id")
                        .HasColumnType("int(11)");

                    b.Property<short?>("UseYn")
                        .HasColumnName("use_yn")
                        .HasColumnType("bit(1)");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId")
                        .HasName("FK_Permiss_RolePermiss");

                    b.HasIndex("RoleId")
                        .HasName("FK_Role_RolePermiss");

                    b.ToTable("tb_role_permission");
                });

            modelBuilder.Entity("UniversalAuthorityManagement.Models.DBEntities.TbRoles", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("role_id")
                        .HasColumnType("int(11)");

                    b.Property<int?>("AppId")
                        .HasColumnName("app_id")
                        .HasColumnType("int(11)");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnName("create_time")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreateUserId")
                        .HasColumnName("create_user_id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<short>("IsBuiltInRole")
                        .HasColumnName("is_built_in_role")
                        .HasColumnType("bit(1)");

                    b.Property<short?>("IsDelete")
                        .HasColumnName("is_delete")
                        .HasColumnType("bit(1)");

                    b.Property<short>("IsSuperAdministrator")
                        .HasColumnName("is_super_administrator")
                        .HasColumnType("bit(1)");

                    b.Property<short>("IsSystemAdmin")
                        .HasColumnName("is_system_admin")
                        .HasColumnType("bit(1)");

                    b.Property<string>("RoleName")
                        .HasColumnName("role_name")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnName("update_time")
                        .HasColumnType("datetime");

                    b.Property<int?>("UpdateUserId")
                        .HasColumnName("update_user_id")
                        .HasColumnType("int(11)");

                    b.Property<short?>("UseYn")
                        .HasColumnName("use_yn")
                        .HasColumnType("bit(1)");

                    b.HasKey("RoleId");

                    b.HasIndex("AppId");

                    b.ToTable("tb_roles");
                });

            modelBuilder.Entity("UniversalAuthorityManagement.Models.DBEntities.TbSysUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("user_id")
                        .HasColumnType("int(11)");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnName("create_time")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreateUserId")
                        .HasColumnName("create_user_id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("varchar(100)");

                    b.Property<short?>("IsDelete")
                        .HasColumnName("is_delete")
                        .HasColumnType("bit(1)");

                    b.Property<long?>("Mobile")
                        .HasColumnName("mobile")
                        .HasColumnType("bigint(20)");

                    b.Property<string>("Password")
                        .HasColumnName("password")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Position")
                        .HasColumnName("position")
                        .HasColumnType("text");

                    b.Property<string>("SysUserName")
                        .HasColumnName("sys_user_name")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telephone")
                        .HasColumnName("telephone")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnName("update_time")
                        .HasColumnType("datetime");

                    b.Property<int?>("UpdateUserId")
                        .HasColumnName("update_user_id")
                        .HasColumnType("int(11)");

                    b.HasKey("UserId");

                    b.ToTable("tb_sys_user");
                });

            modelBuilder.Entity("UniversalAuthorityManagement.Models.DBEntities.TbUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnName("create_time")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreateUserId")
                        .HasColumnName("create_user_id")
                        .HasColumnType("int(11)");

                    b.Property<short?>("IsDelete")
                        .HasColumnName("is_delete")
                        .HasColumnType("bit(1)");

                    b.Property<int?>("RoleId")
                        .HasColumnName("role_id")
                        .HasColumnType("int(11)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnName("update_time")
                        .HasColumnType("datetime");

                    b.Property<int?>("UpdateUserId")
                        .HasColumnName("update_user_id")
                        .HasColumnType("int(11)");

                    b.Property<short?>("UseYn")
                        .HasColumnName("use_yn")
                        .HasColumnType("bit(1)");

                    b.Property<int?>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("int(11)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId")
                        .HasName("FK_Role_RoleUser");

                    b.HasIndex("UserId")
                        .HasName("FK_User_UserRole");

                    b.ToTable("tb_user_role");
                });

            modelBuilder.Entity("UniversalAuthorityManagement.Models.DBEntities.TbMenu", b =>
                {
                    b.HasOne("UniversalAuthorityManagement.Models.DBEntities.TbApplication", "Application")
                        .WithMany("TbMenu")
                        .HasForeignKey("AppId")
                        .HasConstraintName("FK_Application_Menu");
                });

            modelBuilder.Entity("UniversalAuthorityManagement.Models.DBEntities.TbPermission", b =>
                {
                    b.HasOne("UniversalAuthorityManagement.Models.DBEntities.TbMenu", "Menu")
                        .WithMany("TbPermission")
                        .HasForeignKey("MenuId")
                        .HasConstraintName("FK_Reference_23");
                });

            modelBuilder.Entity("UniversalAuthorityManagement.Models.DBEntities.TbRolePermission", b =>
                {
                    b.HasOne("UniversalAuthorityManagement.Models.DBEntities.TbPermission", "Permission")
                        .WithMany("TbRolePermission")
                        .HasForeignKey("PermissionId")
                        .HasConstraintName("FK_Permiss_RolePermiss");

                    b.HasOne("UniversalAuthorityManagement.Models.DBEntities.TbRoles", "Role")
                        .WithMany("TbRolePermission")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_Role_RolePermiss");
                });

            modelBuilder.Entity("UniversalAuthorityManagement.Models.DBEntities.TbRoles", b =>
                {
                    b.HasOne("UniversalAuthorityManagement.Models.DBEntities.TbApplication", "Application")
                        .WithMany("TbRoles")
                        .HasForeignKey("AppId")
                        .HasConstraintName("FK_Application_Roles");
                });

            modelBuilder.Entity("UniversalAuthorityManagement.Models.DBEntities.TbUserRole", b =>
                {
                    b.HasOne("UniversalAuthorityManagement.Models.DBEntities.TbRoles", "Role")
                        .WithMany("TbUserRole")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_Role_RoleUser");

                    b.HasOne("UniversalAuthorityManagement.Models.DBEntities.TbSysUser", "User")
                        .WithMany("TbUserRole")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_User_UserRole");
                });
#pragma warning restore 612, 618
        }
    }
}
