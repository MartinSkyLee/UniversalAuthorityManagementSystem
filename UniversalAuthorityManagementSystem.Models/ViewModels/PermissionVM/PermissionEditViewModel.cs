using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.ViewModels.PermissionVM
{
    public class PermissionEditViewModel
    {
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public int? MenuId { get; set; }
        public string Description { get; set; }
    }
}
