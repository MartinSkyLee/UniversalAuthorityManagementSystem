using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.ViewModels.PermissionVM
{
    public class PermissionCreateViewModel
    {
        public string PermissionName { get; set; }
        public int? MenuId { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
