using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.ViewModels.MenuVM
{
    public class MenuResource
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string Url { get; set; }
        public int? Level { get; set; }
        public int? ParentMenuId { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int MenuOrder { get; set; }
        public List<ChildrenMenus> Children { get; set; }
    }

    public class ChildrenMenus
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string Url { get; set; }
        public int? Level { get; set; }
        public int? ParentMenuId { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int MenuOrder { get; set; }
        public List<ChildrenButtons> Children { get; set; }
    }

    public class ChildrenButtons
    {
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public int? MenuId { get; set; }
        public string Description { get; set; }
    }
}
