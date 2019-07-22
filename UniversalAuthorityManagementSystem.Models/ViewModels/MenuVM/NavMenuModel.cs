using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.ViewModels.MenuVM
{
    public class NavMenuModel
    {
        public string FullName { get; set; }

        public string Icon { get; set; } = "";

        public List<ChildrenMenu> Children { get; set; }
    }

    public class ChildrenMenu
    {
        public int MenuId { get; set; }

        public string FullName { get; set; }

        public string Icon { get; set; } = "";

        public string Router { get; set; }

        public QueryParamsModel QueryParams { get; set; } = null;
    }

    public class QueryParamsModel
    {
        public int DeviceTypeId { get; set; }
    }
}
