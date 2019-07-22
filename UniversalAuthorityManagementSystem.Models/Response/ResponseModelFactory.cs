using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.Response
{
    public class ResponseModelFactory
    {
        public static ResponseModel CreateInstance => new ResponseModel();


        public static ResponseResultModel CreateResultInstance => new ResponseResultModel();


        public static ResponseDataModel CreateDataInstance => new ResponseDataModel();
    }
}
