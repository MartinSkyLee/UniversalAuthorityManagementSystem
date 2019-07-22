using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversalAuthorityManagement.Models.Query
{
    public static class QueryParametersExtensions
    {
        public static double GetTotalPages(this QueryParameters queryParameters, int totalCount)
        {
            return Math.Ceiling(totalCount / (double)queryParameters.Rows);
        }

        public static bool IsDescending(this QueryParameters queryParameters)
        {
            if (!string.IsNullOrEmpty(queryParameters.OrderBy))
            {
                return queryParameters.OrderBy.Split(' ').Last().ToLowerInvariant().StartsWith("desc");
            }
            return false;
        }
    }
}
