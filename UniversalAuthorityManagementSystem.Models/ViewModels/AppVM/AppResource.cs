using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.ViewModels.AppVM
{
    public class AppResource
    {
        public int AppId { get; set; }
        public string AppName { get; set; }
        public string Description { get; set; }
        public string CreateUserName { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
