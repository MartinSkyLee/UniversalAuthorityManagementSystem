using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.ViewModels.PermissionVM
{
    public class PermissionResource
    {
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public int? MenuId { get; set; }
        public string Description { get; set; }
        public bool? IsDelete { get; set; }
    }
}
