using System;
using System.Linq.Expressions;
using System.Reflection;

namespace ExpressionHelp
{
    public static class ExpressionExtensions
    {
        public static string ToPropertyName<TInterface, TProperty>(this Expression<Func<TInterface, TProperty>> accessor)
        {
            var member = accessor.Body as MemberExpression;
            if (member == null)
            {
                throw new ArgumentException(string.Format("Expression '{0}' refers to a method, not a property.", accessor));
            }

            var propInfo = member.Member as PropertyInfo;
            if (propInfo == null)
            {
                throw new ArgumentException(string.Format("Expression '{0}' refers to a field, not a property.", accessor));
            }

            return propInfo.Name;
        }
    }
}