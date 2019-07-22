using System.Collections.Generic;

namespace DHSurvey.Common.Helper
{
    public delegate bool CompareDelegate<T>(T x, T y);
    public class ListCompare<T> : IEqualityComparer<T>
    {
        private CompareDelegate<T> _compare;
        public ListCompare(CompareDelegate<T> d)
        {
            this._compare = d;
        }

        public bool Equals(T x, T y)
        {
            if (_compare != null)
            {
                return this._compare(x, y);
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(T obj)
        {
            return obj.ToString().GetHashCode();
        }
    }

}
