using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DHSurvey.Common.Helper
{
    public class DataConvert
    {
        /// <summary>
        /// 转换为bool类型
        /// </summary>
        /// <param name="value">Object to convert</param>
        /// <returns></returns>
        public static bool ToBoolean(object value)
        {
            bool result = false;
            if (value != null)
            {
                string str = value.ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    bool.TryParse(str, out result);
                }
            }
            return result;
        }

        /// <summary>
        /// 转换为datetime类型
        /// </summary>
        /// <param name="value">Object to convert</param>
        /// <returns></returns>
        public static DateTime ToDateTime(object value)
        {
            DateTime result = DateTime.MinValue;
            if (value != null)
            {
                string str = value.ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    DateTime.TryParse(str, out result);
                }
            }
            return result;
        }

        /// <summary>
        /// 转换为国际时间
        /// </summary>
        /// <param name="value">Object to convert</param>
        /// <returns></returns>
        public static DateTime ToUtcTime(object value)
        {
            return ToDateTime(value).ToUniversalTime();
        }

        /// <summary>
        /// 转换为本地时间
        /// </summary>
        /// <param name="value">Object to convert</param>
        /// <returns></returns>
        public static DateTime ToLocalTime(object value)
        {
            return ToDateTime(value).ToLocalTime();
        }

        /// <summary>
        /// 转换为短整型
        /// </summary>
        /// <param name="value">Object to convert</param>
        /// <returns></returns>
        public static short ToInt16(object value)
        {
            short result = 0;
            if (value != null)
            {
                string str = value.ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    short.TryParse(str, out result);
                }
            }
            return result;
        }

        /// <summary>
        /// 转换为整型
        /// </summary>
        /// <param name="value">Object to convert</param>
        /// <returns></returns>
        public static int ToInt32(object value)
        {
            int result = 0;
            if (value != null)
            {
                string str = value.ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    int.TryParse(str, out result);
                }
            }
            return result;
        }

        /// <summary>
        /// 转换为长整型
        /// </summary>
        /// <param name="value">Object to convert</param>
        /// <returns></returns>
        public static long ToInt64(object value)
        {
            long result = 0;
            if (value != null)
            {
                string str = value.ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    long.TryParse(str, out result);
                }
            }
            return result;
        }

        /// <summary>
        /// 转换为decimal
        /// </summary>
        /// <param name="value">Object to convert</param>
        /// <returns></returns>
        public static decimal ToDecimal(object value)
        {
            decimal result = 0;
            if (value != null)
            {
                string str = value.ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    decimal.TryParse(str, out result);
                }
            }
            return result;
        }

        /// <summary>
        /// 转换为double
        /// </summary>
        /// <param name="value">Object to convert</param>
        /// <returns></returns>
        public static double ToDouble(object value)
        {
            double result = 0;
            if (value != null)
            {
                string str = value.ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    double.TryParse(str, out result);
                }
            }
            return result;
        }

        /// <summary>
        /// 转换成string或空
        /// </summary>
        /// <param name="value">Object to convert</param>
        /// <returns></returns>
        public static string ToString(object value)
        {
            return (value != null) ? value.ToString() : string.Empty;
        }

        /// <summary>
        /// SQL转换字符串处理
        /// </summary>
        /// <param name="paramStr"></param>
        /// <returns></returns>
        public static string ToSqlString(string paramStr)
        {
            return "'" + SafeFormat(paramStr) + "'";
        }
        /// <summary>
        /// SQL转换Like参数
        /// </summary>
        /// <param name="paramStr"></param>
        /// <returns></returns>
        public static string ToSqlLikeString(string paramStr)
        {
            return "'%" + SafeFormat(paramStr) + "%'";
        }
        /// <summary>
        /// SQL转换Like右模糊查询
        /// </summary>
        /// <param name="paramStr"></param>
        /// <returns></returns>
        public static string ToSqlLikeStringR(string paramStr)
        {
            return "'" + SafeFormat(paramStr) + "%'";
        }
        /// <summary>
        /// SQL转换左右模糊查询 使用SqlParameter时调用此方法
        /// </summary>
        /// <param name="paramStr"></param>
        /// <returns></returns>
        public static string ToSqlLikeStringForParamers(string paramStr)
        {
            return "%" + SafeFormat(paramStr) + "%";
        }
        /// <summary>
        /// SQL转换右模糊查询 使用SqlParameter时调用此方法
        /// </summary>
        /// <param name="paramStr"></param>
        /// <returns></returns>
        public static string ToSqlLikeStringRForParamers(string paramStr)
        {
            return SafeFormat(paramStr) + "%";
        }
        /// <summary>
        /// SQL转换In字符串 得到('A,B,...')
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string StrToSqlInString(ICollection list)
        {
            StringBuilder res = new StringBuilder();

            int i = 0;
            foreach (object o in list)
            {
                if (i != 0)
                    res.Append("','");

                res.Append(o.ToString());
                i++;
            }
            return "('" + res.ToString() + "')";
        }
        /// <summary>
        /// SQL转换In字符串 得到(2,3,4,..)
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string ToSqlInString(ICollection list)
        {
            StringBuilder res = new StringBuilder();

            int i = 0;
            foreach (object o in list)
            {
                if (i != 0)
                    res.Append(',');

                res.Append(o.ToString());
                i++;
            }
            return "(" + res.ToString() + ")";
        }
        /// <summary>
        /// SQL转换In字符串 得到('a','b','c','d')
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string ToSqlIn(ICollection list)
        {
            StringBuilder res = new StringBuilder();

            int i = 0;
            foreach (object o in list)
            {
                if (i != 0)
                    res.Append(',');

                res.Append("'").Append(o.ToString()).Append("'");
                i++;
            }
            return "(" + res.ToString().TrimEnd(',') + ")";
        }
        /// <summary>
        /// SQL转换日期字符串 参数为'yyyy-MM-dd',得到'yyyy-MM-dd 23:59:59'
        /// </summary>
        /// <param name="paramDate"></param>
        /// <returns></returns>
        public static string ToSqlEndDate(string paramDate)
        {
            return ToSqlString(paramDate + " 23:59:59");
        }
        /// <summary>
        /// SQL转换日期字符串 参数为'yyyy-MM-dd',得到'yyyy-MM-dd 00:00:00'
        /// </summary>
        /// <param name="paramDate"></param>
        /// <returns></returns>
        public static string ToSqlStartDate(string paramDate)
        {
            return ToSqlString(paramDate + " 00:00:00");
        }
        /// <summary>
        /// DateTime转字符串yyyy-MM-dd HH:mm:ss含左右逗号
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string ToSqlDateTimeStr(DateTime time)
        {
            return "'" + time.ToString("yyyy-MM-dd HH:mm:ss") + "'";
        }
        /// <summary>
        /// 对象转日期字符串 yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string DateTimeFormat(object obj, string format = "yyyy-MM-dd HH:mm:ss")
        {
            return (obj == null || obj == DBNull.Value)
                       ? string.Empty
                       : ToDateTime(obj).ToString(format);
        }
        /// <summary>
        /// 对象转布尔Boolean
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool TrimBoolNull(object obj)
        {
            if (obj is System.DBNull || obj == null || string.IsNullOrEmpty(obj.ToString()))
            {
                return false;
            }
            else
            {
                return Convert.ToBoolean(obj);
            }
        }
        /// <summary>
        /// 去空格
        /// </summary>
        /// <param name="obj">去空格的对象</param>
        /// <param name="IsClearTrim">是否去掉全部空格</param>
        public static string TrimNull(Object obj, bool IsClearTrim = false)
        {
            if (obj is System.DBNull || obj == null || string.IsNullOrEmpty(obj.ToString()))
            {
                return string.Empty;
            }
            else
            {
                if (IsClearTrim)
                {
                    return obj.ToString().Trim().Replace(" ", "");
                }
                else
                {
                    return obj.ToString().Trim();
                }
            }
        }

        /// <summary>
        /// 对象转Float
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static float TryFloat(Object obj, float defaultValue = 0)
        {

            float temp;
            var i = float.TryParse(obj + "", out temp) ? temp : defaultValue;
            return i;
        }
        /// <summary>
        /// 对象转Decimal
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static decimal TryDecimal(Object obj, decimal defaultValue = 0)
        {

            decimal temp;
            var i = decimal.TryParse(obj + "", out temp) ? temp : defaultValue;
            return i;
        }
        /// <summary>
        /// 对象转Bool
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static bool TryBool(Object obj, bool defaultValue = false)
        {

            bool temp;
            var i = bool.TryParse(obj + "", out temp) ? temp : defaultValue;
            return i;
        }
        /// <summary>
        /// 字符串转decimal 得到自定义小数位
        /// </summary>
        /// <param name="moneyStr"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static decimal ToMoney(string moneyStr, int type = 2) //type=4 采购价四位
        {
            return decimal.Round(decimal.Parse(moneyStr), type);
        }
        /// <summary>
        /// 字符串转decimal 得到小数位2位
        /// </summary>
        /// <param name="moneyStr"></param>
        /// <returns></returns>
        public static decimal ToMoney(string moneyStr)
        {
            return decimal.Round(decimal.Parse(moneyStr), 2);
        }
        /// <summary>
        /// decimal转decimal 得到小数位2位
        /// </summary>
        /// <param name="moneyStr"></param>
        /// <returns></returns>
        public static decimal ToMoney(decimal moneyValue)
        {
            return decimal.Round(moneyValue, 2);
        }
        /// <summary>
        /// decimal转decimal 得到自定义小数位
        /// </summary>
        /// <param name="moneyStr"></param>
        /// <returns></returns>
        public static decimal ToMoney(decimal moneyValue, int type = 2)
        {
            return decimal.Round(moneyValue, type);
        }
        /// <summary>
        /// 字符串转decimal 得到小数位4位
        /// </summary>
        /// <param name="moneyStr"></param>
        /// <returns></returns>
        public static decimal ToFourDigit(string moneyStr)
        {
            return decimal.Round(decimal.Parse(moneyStr), 4);
        }
        /// <summary>
        /// decimal转decimal 得到小数位4位
        /// </summary>
        /// <param name="moneyStr"></param>
        /// <returns></returns>
        public static decimal ToFourDigit(decimal moneyStr)
        {
            return decimal.Round(moneyStr, 4);
        }
        /// <summary>
        /// 舍去小数位 向下取整
        /// </summary>
        /// <param name="dec"></param>
        /// <returns></returns>
        public static int TruncDdecimal(decimal dec)
        {
            return Convert.ToInt32(Math.Floor(dec));
        }
        /// <summary>
        /// 取整进位 向上取整
        /// </summary>
        /// <param name="dec"></param>
        /// <returns></returns>
        public static int TruncDdecimalCell(decimal dec)
        {
            return Convert.ToInt32(Math.Ceiling(dec));
        }
        /// <summary>
        /// 舍去金额的分,直接舍去,然后加一毛钱    非四舍五入
        /// </summary>
        /// <param name="moneyValue"></param>
        /// <returns></returns>
        public static decimal TruncMoneyAddOneJiao(decimal moneyValue)
        {
            return (Math.Floor(moneyValue * 10) / 10) + 0.1m;
        }
        /// <summary>
        /// 舍去金额的分,直接舍去,非四舍五入
        /// </summary>
        /// <param name="moneyValue"></param>
        /// <returns></returns>
        public static decimal TruncMoney(decimal moneyValue)
        {
            return Math.Floor(moneyValue * 10) / 10;
        }

        /// <summary>
        /// decimal转int
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public static int DecimalToU_Int32(decimal argument)
        {
            object Int32Value;
            object UInt32Value;

            // Convert the argument to an int value.
            try
            {
                Int32Value = (int)argument;
            }
            catch (Exception ex)
            {
                Int32Value = GetExceptionType(ex);
            }

            // Convert the argument to a uint value.
            try
            {
                UInt32Value = (uint)argument;
            }
            catch (Exception ex)
            {
                UInt32Value = GetExceptionType(ex);
            }

            return Int32.Parse(UInt32Value.ToString());
        }
        /// <summary>
        /// 转百分比
        /// </summary>
        public static decimal ConvertPercent(decimal Value)
        {
            return Math.Round(Value * 100, 2, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// 字符串指定长度
        /// </summary>
        /// <param name="s"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string TrimString(string s, int len)
        {
            string _s;
            if (s.Length > len)
            {
                _s = s.Substring(0, len - 1) + "...";
            }
            else
            {
                _s = s;
            }

            return _s;
        }
        /// <summary>
        /// 判断一个时间是否在区间中
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime TrimDateTimeByHMS(string time)
        {
            string[] startStr = time.Split(':');
            DateTime dt = DateTime.MinValue;
            if (string.IsNullOrEmpty(time) || startStr.Length != 3)
            {
                return dt;
            }
            try
            {
                dt = new DateTime(1900, 1, 1, int.Parse(startStr[0]), int.Parse(startStr[1]), int.Parse(startStr[2]));
            }
            catch { }
            return dt;
        }
        //整理字符串到安全格式
        public static string SafeFormat(string strInput)
        {
            return strInput.Trim().Replace("'", "''");
        }

        /// <summary>
        /// 去除list中空对象
        /// </summary>
        /// <param name="param"></param>
        public static void RemoveNull(IList param)
        {
            if (param == null)
                return;
            while (param.Contains(null))
            {
                int index = 0;
                foreach (object t in param)
                {
                    if (t == null)
                    {
                        param.RemoveAt(index);
                        break;
                    }
                    index++;
                }
            }
        }
        /// <summary>
        /// 返回错误类型
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        private static string GetExceptionType(Exception ex)
        {
            string exceptionType = ex.GetType().ToString();
            return exceptionType.Substring(exceptionType.LastIndexOf('.') + 1);
        }

        /// <summary>
        /// 对象转Int
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int TryInt(Object obj, int defaultValue = -999999)
        {
            int temp;
            var i = int.TryParse(obj + "", out temp) ? temp : defaultValue;
            return i;
        }

        /// <summary>
        /// DateTime类型转为时间戳
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal ToTimestamp(DateTime value)
        {
            TimeSpan span = (value - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime());

            return (decimal)span.TotalMilliseconds;
        }
    }
}
