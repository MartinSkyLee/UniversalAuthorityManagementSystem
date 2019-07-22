using System;
using System.Collections.Generic;

namespace UniversalAuthorityManagement.Models.DBEntities
{
    public partial class TbMenu
    {
        public TbMenu()
        {
            TbPermission = new HashSet<TbPermission>();
        }

        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string Url { get; set; }
        public int? Level { get; set; }
        public int? ParentMenuId { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int DeviceTypeId { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsDelete { get; set; }
        public int MenuOrder { get; set; }
        public int? AppId { get; set; }

        public TbApplication Application { get; set; }
        public ICollection<TbPermission> TbPermission { get; set; }
    }
}
