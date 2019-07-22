using System;
using System.Collections.Generic;
using System.Text;
using UniversalAuthorityManagement.Models.ViewModels;

namespace UniversalAuthorityManagement.Models.Response
{
    public class ResponseResultModel : ResponseModel
    {
        /// <summary>
        /// 返回的结果
        /// </summary>
        public PageResult PageResult { get; set; }

        public void SetData(PageResult pageResult)
        {
            PageResult = pageResult;
        }
    }
}
