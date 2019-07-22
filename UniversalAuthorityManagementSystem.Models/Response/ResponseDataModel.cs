using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.Response
{
    public class ResponseDataModel : ResponseModel
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        public object Data { get; set; }

        public void SetData(object data)
        {
            Data = data;
        }
    }
}
