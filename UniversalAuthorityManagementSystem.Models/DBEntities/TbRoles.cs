using System;
using System.Collections.Generic;

namespace UniversalAuthorityManagement.Models.DBEntities
{
    public partial class TbRoles
    {
        public TbRoles()
        {
            TbRolePermission = new HashSet<TbRolePermission>();
            TbUserRole = new HashSet<TbUserRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool? UseYn { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsDelete { get; set; }
        public string Description { get; set; }
        public int? AppId { get; set; }

        /// <summary>
        /// 是否是超级管理员(超级管理员拥有所有系统的所有权限)
        /// </summary>
        public bool IsSuperAdministrator { get; set; }

        /// <summary>
        /// 是否是某个系统的业务管理员(该管理员拥有该系统的所有权限)
        /// </summary>
        public bool IsSystemAdmin { get; set; }

        /// <summary>
        /// 是否是系统内置角色(系统内置角色不允许被删除和修改)
        /// </summary>
        public bool IsBuiltInRole { get; set; }

        public ICollection<TbRolePermission> TbRolePermission { get; set; }
        public ICollection<TbUserRole> TbUserRole { get; set; }
        public TbApplication Application { get; set; }
    }
}
