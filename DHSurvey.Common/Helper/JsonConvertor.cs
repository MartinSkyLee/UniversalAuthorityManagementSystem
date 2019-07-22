using Jil;
using System;
using System.Collections.Generic;
using System.Text;

namespace DHSurvey.Common.Helper
{
    /// <summary>
    /// Json转换帮助类
    /// </summary>
    public class JsonConvertor
    {
        /// <summary>
        /// 类型序列化成字符串
        /// </summary>
        /// <param name="source">类型</param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static string Serialize(object source, Jil.Options options = null)
        {
            return JSON.Serialize(source, options);
        }

        /// <summary>
        /// 实体类序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static string Serialize<T>(T source, Jil.Options options = null)
        {
            return JSON.Serialize(source, options);
        }

        /// <summary>
        /// 字符串发序列化为实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string source, Jil.Options options = null)
        {
            return JSON.Deserialize<T>(source, options);
        }

        /// <summary>
        /// 目标类型反序列化为实体
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destinationType"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static object Deserialize(string source, Type destinationType, Jil.Options options = null)
        {
            return JSON.Deserialize(source, destinationType, options);
        }

        /// <summary>
        /// 字符串反序列化为动态类型
        /// </summary>
        /// <param name="source"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static dynamic Deserialize(string source, Jil.Options options = null)
        {
            return JSON.DeserializeDynamic(source, options);
        }
    }
}
