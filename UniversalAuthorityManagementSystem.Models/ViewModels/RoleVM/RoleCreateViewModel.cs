using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.ViewModels.RoleVM
{
    public class RoleCreateViewModel
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
        public int AppId { get; set; }
    }
}
