using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.ViewModels.UserVM
{
    public class UserResource
    {
        public int UserId { get; set; }
        public string SysUserName { get; set; }
        public long? Mobile { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Telephone { get; set; }
        public List<int> RoleIds { get; set; }
    }
}
