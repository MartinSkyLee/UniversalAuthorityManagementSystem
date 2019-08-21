using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.ViewModels
{
    public class LoginUserInfo
    {
        public string UserName { get; set; } = "";
        public string DisplayName { get; set; } = "";
        public int UserId { get; set; } = 0;
        public string Email { get; set; } = "";
        public List<int> RoleIds { get; set; } = new List<int>();
        public bool IsSuper { get; set; } = false;
    }
}
