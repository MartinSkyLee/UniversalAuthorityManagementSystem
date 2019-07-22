using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.ViewModels.RoleVM
{
    public class RolePermissionViewModel
    {
        public int RoleId { get; set; }
        public List<int> ButtonIds { get; set; }
    }
}
