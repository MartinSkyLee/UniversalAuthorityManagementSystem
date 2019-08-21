using System;
using System.Collections.Generic;
using System.Text;
using UniversalAuthorityManagement.Models.DBEntities;

namespace UniversalAuthorityManagement.Models.ViewModels.RoleVM
{
    public class RoleAuthorizationTreeVM
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public int? Level { get; set; }
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public bool UseYn { get; set; }
        public int? ParentMenuId { get; set; }
        public object Permission { get; set; }
        public object Children { get; set; }

    }
}
