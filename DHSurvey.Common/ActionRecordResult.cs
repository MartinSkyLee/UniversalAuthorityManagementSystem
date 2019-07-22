using System;
using System.Collections.Generic;

namespace DHSurvey.Common
{
    /// <summary>
    /// 页面返回记录
    /// </summary>
    public class ActionRecordResult<T> where T : class
    {
        /// <summary>
        /// 总记录数
        /// </summary>
        public int TotalRecord { get; set; }

        /// <summary>
        /// 数据列表
        /// </summary>
        public List<T> List { get; set; } = new List<T>();


    }
}
