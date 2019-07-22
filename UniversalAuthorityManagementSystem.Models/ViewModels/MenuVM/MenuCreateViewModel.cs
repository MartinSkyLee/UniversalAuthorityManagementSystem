using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.ViewModels.MenuVM
{
    public class MenuCreateViewModel
    {
        public string MenuName { get; set; }
        public string Url { get; set; }
        public int? Level { get; set; }
        public int? ParentMenuId { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int MenuOrder { get; set; }
        public int AppId { get; set; }
    }
}
