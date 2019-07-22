using System;
using System.Collections.Generic;

namespace UniversalAuthorityManagement.Models.DBEntities
{
    public partial class TbPermission
    {
        public TbPermission()
        {
            TbRolePermission = new HashSet<TbRolePermission>();
        }

        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public int? MenuId { get; set; }
        public string PermissionType { get; set; }
        public string Description { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsDelete { get; set; }
        public string Url { get; set; }

        public TbMenu Menu { get; set; }
        public ICollection<TbRolePermission> TbRolePermission { get; set; }
    }
}
