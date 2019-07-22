namespace DHSurvey.Common.Helper
{
    public class CommonManager
    {
        private static readonly object lockobj = new object();
        private static volatile Cache _cache = null;
        /// <summary>
        /// Cache
        /// </summary>
        public static Cache CacheObj
        {
            get
            {
                if (_cache == null)
                {
                    lock (lockobj)
                    {
                        if (_cache == null)
                            _cache = new Cache();
                    }
                }
                return _cache;
            }
        }
    }
}
