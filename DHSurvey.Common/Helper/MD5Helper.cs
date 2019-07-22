using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DHSurvey.Common.Helper
{
    public class MD5Helper
    {
        public static string MD5Encrypt32(string str)
        {
            MD5 md5 = MD5.Create();
            string md5_str = "";
            byte[] rlt = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            foreach (byte value in rlt)
            {
                md5_str += value.ToString("X");
            }

            return md5_str;
        }
    }
}
