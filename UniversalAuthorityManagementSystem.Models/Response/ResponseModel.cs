using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.Response
{
    public class ResponseModel
    {
        public ResponseModel()
        {
            Status = ReturnStatus.Success;
            Code = 200;
            Message = "成功";
        }

        public ReturnStatus Status { get; set; }

        /// <summary>
        /// 响应状态码
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 响应消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 设置响应状态为成功
        /// </summary>
        /// <param name="message"></param>
        public void SetSuccess(string message = "成功")
        {
            Status = ReturnStatus.Success;
            Code = 200;
            Message = message;
        }

        /// <summary>
        /// 设置响应状态为新增成功
        /// </summary>
        /// <param name="message"></param>
        public void SetCreated(string message = "新增成功")
        {
            Status = ReturnStatus.Success;
            Code = 201;
            Message = message;
        }

        /// <summary>
        /// 设置响应状态为成功
        /// </summary>
        /// <param name="message"></param>
        public void SetNoContent(string message = "成功")
        {
            Status = ReturnStatus.Success;
            Code = 204;
            Message = message;
        }

        /// <summary>
        /// 设置响应状态为错误
        /// </summary>
        /// <param name="message"></param>
        public void SetError(string message = "服务器内部错误")
        {
            Status = ReturnStatus.Failed;
            Message = message;
            Code = 500;
        }
        
        /// <summary>
        /// 设置响应状态为请求无效
        /// </summary>
        /// <param name="message"></param>
        public void SetBadRequest(string message = "请求无效")
        {
            Status = ReturnStatus.Failed;
            Message = message;
            Code = 400;
        }


        /// <summary>
        /// 设置响应状态为无权限
        /// </summary>
        /// <param name="message"></param>
        public void SetNoPermission(string message = "无权限")
        {
            Status = ReturnStatus.Failed;
            Message = message;
            Code = 401;
        }


        /// <summary>
        /// 设置响应状态为未知资源
        /// </summary>
        /// <param name="message"></param>
        public void SetNotFound(string message = "未知资源")
        {
            Status = ReturnStatus.Failed;
            Message = message;
            Code = 404;
        }
    }

    public enum ReturnStatus
    {
        Success = 1,
        Failed = 0
    }
}
