using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.ViewModels
{
    public class PageResult
    {
        /// <summary>
        /// 列表数据
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int CurrentPage { get; set; } = 1;

        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount { get; set; }
    }
}
