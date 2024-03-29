﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHSurvey.Common.Helper.ExcelIOHelper
{
    public class TemplateMode
    {
        /// <summary>
        /// 行号
        /// </summary>
        public int row { get; set; }
        /// <summary>
        /// 列号
        /// </summary>
        public int cell { get; set; }
        /// <summary>
        /// 数据值
        /// </summary>
        public string value { get; set; }
    }
}
