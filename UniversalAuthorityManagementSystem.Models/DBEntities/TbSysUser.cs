using System;
using System.Collections.Generic;

namespace UniversalAuthorityManagement.Models.DBEntities
{
    public partial class TbSysUser
    {
        public TbSysUser()
        {
            TbUserRole = new HashSet<TbUserRole>();
        }

        public int UserId { get; set; }
        public string SysUserName { get; set; }
        public string Password { get; set; }
        public long? Mobile { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Telephone { get; set; }
        public bool? IsDelete { get; set; }

        public ICollection<TbUserRole> TbUserRole { get; set; }
    }
}
