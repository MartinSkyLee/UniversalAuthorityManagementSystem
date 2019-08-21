using System.Collections.Generic;
using UniversalAuthorityManagement.Models.DBEntities;

namespace UniversalAuthorityManagement.Models.ViewModels.MenuVM
{
    public class MenuTreeVM
    {
        public int MenuId { get; set; }
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public string MenuName { get; set; }
        public string Url { get; set; }
        public int? Level { get; set; }
        public int? ParentMenuId { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int MenuOrder { get; set; }
        public object Children { get; set; }
    }
}
