using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace DHSurvey.Common.Helper
{
    /// <summary>
    /// Linq帮助类
    /// </summary>
    public static class LinqHelper
    {
        /// <summary>
        /// 判断list中是否存在某实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">实体list</param>
        /// <param name="predicate">单独实体</param>
        /// <returns></returns>
        public static bool Has<T>(this IEnumerable<T> list, Func<T, bool> predicate)
        {
            return list.FirstOrDefault(predicate) != null;
        }
        /// <summary>
        /// 排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">数据源</param>
        /// <param name="propertyName">属性名</param>
        /// <param name="ascending">排序</param>
        /// <returns></returns>
        public static IQueryable<T> OrderBy<T>(this IQueryable<T> source, string propertyName, bool ascending) where T : class
        {
            Type type = typeof(T);

            PropertyInfo property = type.GetProperty(propertyName);
            if (property == null)
                throw new ArgumentException("propertyName", "Not Exist");

            ParameterExpression param = Expression.Parameter(type, "p");
            Expression propertyAccessExpression = Expression.MakeMemberAccess(param, property);
            LambdaExpression orderByExpression = Expression.Lambda(propertyAccessExpression, param);

            string methodName = ascending ? "OrderBy" : "OrderByDescending";

            MethodCallExpression resultExp = Expression.Call(typeof(Queryable), methodName, new Type[] { type, property.PropertyType }, source.Expression, Expression.Quote(orderByExpression));

            return source.Provider.CreateQuery<T>(resultExp);
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">数据列表</param>
        /// <param name="orderby">排序字段</param>
        /// <param name="startPage">起始页</param>
        /// <param name="pageSize">每页记录数</param>
        /// <param name="where">条件</param>
        /// <param name="ascending">排序</param>
        /// <returns></returns>
        public static IEnumerable<T> GetPageList<T>(this IQueryable<T> list, string orderby, int startPage = 1, int pageSize = 10, Expression<Func<T, bool>> where = null, bool ascending = false) where T : class
        {
            if (list == null || list.Count() == 0)
                return list;

            if (where != null)
                list = list.Where(where);

            if (!string.IsNullOrEmpty(orderby))
                list = list.OrderBy<T>(orderby, ascending);

            return list.Skip((startPage - 1) * pageSize).Take(pageSize);
        }
        /// <summary>
        /// 根据offset排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="orderby"></param>
        /// <param name="offset"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public static IEnumerable<T> GetPageListByOffset<T>(this IQueryable<T> list, string orderby, int offset = 0, int pageSize = 10, Expression<Func<T, bool>> where = null, bool ascending = false) where T : class
        {
            if (list == null || list.Count() == 0)
                return list;

            if (where != null)
                list = list.Where(where);

            if (!string.IsNullOrEmpty(orderby))
                list = list.OrderBy<T>(orderby, ascending);

            return list.Skip(offset).Take(pageSize);
        }
    }
}
