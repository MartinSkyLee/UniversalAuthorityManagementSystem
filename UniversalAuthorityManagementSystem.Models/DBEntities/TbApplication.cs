using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.DBEntities
{
    public class TbApplication
    {
        public TbApplication()
        {
            TbRoles = new HashSet<TbRoles>();
            TbMenu = new HashSet<TbMenu>();
        }
        public int AppId { get; set; }
        public string AppName { get; set; }
        public string Description { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsDelete { get; set; }
        public ICollection<TbRoles> TbRoles { get; set; }
        public ICollection<TbMenu> TbMenu { get; set; }
    }
}
