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

        public ICollection<TbRolePermission> TbRolePermission { get; set; }
        public ICollection<TbUserRole> TbUserRole { get; set; }
        public TbApplication Application { get; set; }
    }
}
