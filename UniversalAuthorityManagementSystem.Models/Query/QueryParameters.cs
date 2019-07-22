using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UniversalAuthorityManagement.Models.Query
{
    public class QueryParameters
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// 单页面记录数
        /// </summary>
        public int Rows { get; set; } = 10;

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? StartTime { get; set; } = DateTime.MinValue;

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; } = DateTime.MinValue;

        /// <summary>
        /// 排序关键字
        /// </summary>
        [Required]
        public string Sidx { get; set; }

        /// <summary>
        /// 排序方式（asc或者desc）
        /// </summary>
        public string Sord { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        public string OrderBy => Sidx + " " + Sord;
    }
}
