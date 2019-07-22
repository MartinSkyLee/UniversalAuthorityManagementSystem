using AutoMapper;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.ViewModels.AppVM;
using UniversalAuthorityManagement.Models.ViewModels.MenuVM;
using UniversalAuthorityManagement.Models.ViewModels.PermissionVM;
using UniversalAuthorityManagement.Models.ViewModels.RoleVM;
using UniversalAuthorityManagement.Models.ViewModels.UserVM;

namespace UniversalAuthorityManagementSystem.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region 应用程序
            CreateMap<AppCreateViewModel, TbApplication>();
            CreateMap<AppEditViewModel, TbApplication>();
            #endregion

            #region 用户
            CreateMap<UserCreateViewModel, TbSysUser>();
            CreateMap<UserEditViewModel, TbSysUser>();
            #endregion

            #region 角色
            CreateMap<RoleCreateViewModel, TbRoles>();
            CreateMap<RoleEditViewModel, TbRoles>();
            #endregion

            #region 菜单
            CreateMap<MenuCreateViewModel, TbMenu>();
            CreateMap<MenuEditViewModel, TbMenu>();
            #endregion

            #region 权限
            CreateMap<PermissionCreateViewModel, TbPermission>();
            CreateMap<PermissionEditViewModel, TbPermission>();
            #endregion
        }
    }
}
