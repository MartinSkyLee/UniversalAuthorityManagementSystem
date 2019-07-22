using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.ViewModels.RoleVM
{
    public class RolePermissionTreeData
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public int? Level { get; set; }
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public bool UseYn { get; set; }
        public List<Menus> Children { get; set; }
    }

    public class Menus
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public int? Level { get; set; }
        public int? ParentMenuId { get; set; }
        public List<Buttons> Permission { get; set; }
    }

    public class Buttons
    {
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public bool UseYn { get; set; }
    }
}
