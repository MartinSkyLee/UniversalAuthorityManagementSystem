using System;
using System.Collections.Generic;

namespace UniversalAuthorityManagement.Models.DBEntities
{
    public partial class TbUserRole
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public bool? UseYn { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateUserId { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsDelete { get; set; }

        public TbRoles Role { get; set; }
        public TbSysUser User { get; set; }
    }
}
