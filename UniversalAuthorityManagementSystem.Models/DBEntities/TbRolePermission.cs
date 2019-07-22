using System;
using System.Collections.Generic;

namespace UniversalAuthorityManagement.Models.DBEntities
{
    public partial class TbRolePermission
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? PermissionId { get; set; }
        public bool? UseYn { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsDelete { get; set; }

        public TbPermission Permission { get; set; }
        public TbRoles Role { get; set; }
    }
}
