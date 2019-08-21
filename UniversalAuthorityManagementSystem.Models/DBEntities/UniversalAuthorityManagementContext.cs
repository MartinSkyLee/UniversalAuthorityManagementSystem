using Microsoft.EntityFrameworkCore;

namespace UniversalAuthorityManagement.Models.DBEntities
{
    public partial class UniversalAuthorityManagementContext : DbContext
    {
        public UniversalAuthorityManagementContext()
        {
        }

        public UniversalAuthorityManagementContext(DbContextOptions<UniversalAuthorityManagementContext> options)
            : base(options)
        {
        }
        
        public virtual DbSet<TbMenu> TbMenu { get; set; }
        public virtual DbSet<TbPermission> TbPermission { get; set; }
        public virtual DbSet<TbRolePermission> TbRolePermission { get; set; }
        public virtual DbSet<TbRoles> TbRoles { get; set; }
        public virtual DbSet<TbSysUser> TbSysUser { get; set; }
        public virtual DbSet<TbUserRole> TbUserRole { get; set; }
        public virtual DbSet<TbApplication> TbApplication { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.ToTable("tb_menu");

                entity.Property(e => e.MenuId)
                    .HasColumnName("menu_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("is_delete")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MenuName)
                    .HasColumnName("menu_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ParentMenuId)
                    .HasColumnName("parent_menu_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Icon)
                    .HasColumnName("icon")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("text");

                entity.Property(e => e.DeviceTypeId)
                    .HasColumnName("device_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MenuOrder)
                    .HasColumnName("menu_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AppId)
                    .HasColumnName("app_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.TbMenu)
                    .HasForeignKey(d => d.AppId)
                    .HasConstraintName("FK_Application_Menu");
            });

            modelBuilder.Entity<TbPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionId);

                entity.ToTable("tb_permission");

                entity.HasIndex(e => e.MenuId)
                    .HasName("FK_Reference_23");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("permission_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("is_delete")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.MenuId)
                    .HasColumnName("menu_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PermissionName)
                    .HasColumnName("permission_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PermissionType)
                    .HasColumnName("permission_type")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("text");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.TbPermission)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_Reference_23");
            });

            modelBuilder.Entity<TbRolePermission>(entity =>
            {
                entity.ToTable("tb_role_permission");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("FK_Permiss_RolePermiss");

                entity.HasIndex(e => e.RoleId)
                    .HasName("FK_Role_RolePermiss");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("is_delete")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("permission_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UseYn)
                    .HasColumnName("use_yn")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.TbRolePermission)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_Permiss_RolePermiss");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TbRolePermission)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_RolePermiss");
            });

            modelBuilder.Entity<TbRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("tb_roles");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("is_delete")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UseYn)
                    .HasColumnName("use_yn")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Description)
                   .HasColumnName("description")
                   .HasColumnType("text");

                entity.Property(e => e.AppId)
                    .HasColumnName("app_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsSuperAdministrator)
                    .HasColumnName("is_super_administrator")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.IsSystemAdmin)
                    .HasColumnName("is_system_admin")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.IsBuiltInRole)
                    .HasColumnName("is_built_in_role")
                    .HasColumnType("bit(1)");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.TbRoles)
                    .HasForeignKey(d => d.AppId)
                    .HasConstraintName("FK_Application_Roles");
            });

            modelBuilder.Entity<TbSysUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tb_sys_user");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("is_delete")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("text");

                entity.Property(e => e.SysUserName)
                    .HasColumnName("sys_user_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreateTime)
                   .HasColumnName("create_time")
                   .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TbUserRole>(entity =>
            {
                entity.ToTable("tb_user_role");

                entity.HasIndex(e => e.RoleId)
                    .HasName("FK_Role_RoleUser");

                entity.HasIndex(e => e.UserId)
                    .HasName("FK_User_UserRole");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("is_delete")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UseYn)
                    .HasColumnName("use_yn")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TbUserRole)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_RoleUser");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TbUserRole)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_User_UserRole");
            });

            modelBuilder.Entity<TbApplication>(entity =>
            {
                entity.HasKey(e => e.AppId);

                entity.ToTable("tb_application");

                entity.Property(e => e.AppId)
                    .HasColumnName("app_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("is_delete")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.AppName)
                    .HasColumnName("app_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                   .HasColumnName("description")
                   .HasColumnType("text");
            });
        }
    }
}
