using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace ExpressionHelp
{
    public class Filter<TEntity>
    {
        public Expression<Func<TEntity, bool>> Predicate { get; protected set; }

        public Expression<Func<TEntity, bool>> GeneratorEqualityTest<TProperty>(Expression<Func<TEntity, TProperty>> accessor, int expectedValue)
        {
            // Help
            var argument = Expression.Parameter(typeof(TEntity));
            var accessorArgument = Expression.Property(argument, accessor.ToPropertyName());
            // Help

            try
            {
                Predicate = Expression.Lambda<Func<TEntity, bool>>(Expression.Equal(accessorArgument, Expression.Constant(expectedValue)), argument);
                Debug.WriteLine("Case " + expectedValue + " worked.");
            }
            catch (Exception exc)
            {
                Debug.WriteLine("Case " + expectedValue + "failed: " + exc.Message);
            }

            return Predicate;
        }
    }
}