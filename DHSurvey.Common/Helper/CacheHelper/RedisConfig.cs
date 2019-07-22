using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DHSurvey.Common.Helper
{
    public static class RedisConfig
    {
        public static string Connection { get; set; }
        public static int DefaultDatabase { get; set; }
        public static string InstanceName { get; set; }
    }
}
