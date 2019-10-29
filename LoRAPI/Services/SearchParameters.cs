using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LoRAPI.Services
{
    public abstract class SearchParameters<TClass> where TClass : class
    {
        /// <summary>
        /// Group of statements that compose this filter.
        /// </summary>
        public List<IFilterStatement> Statements { get; set; }
        /// <summary>
        /// Builds a LINQ expression based upon the statements included in this filter.
        /// </summary>
        /// <returns></returns>
        Expression<Func<TClass, bool>> BuildExpression()
        {
            //this is in case the list of statements is empty
            Expression finalExpression = Expression.Constant(true);
            var parameter = Expression.Parameter(typeof(TClass), "x");
            foreach (var statement in Statements)
            {
                var member = Expression.Property(parameter, statement.PropertyName);
                var constant = Expression.Constant(statement.Value);
                Expression expression = Expression.Or(member, constant);

                finalExpression = Expression.AndAlso(finalExpression, expression);
            }

            return finalExpression as Expression<Func<TClass, bool>>;
        }
    }

    /// <summary>
    /// Defines how a property should be filtered.
    /// </summary>
    public interface IFilterStatement
    {
        /// <summary>
        /// Name of the property.
        /// </summary>
        string PropertyName { get; set; }
        /// <summary>
        /// Express the interaction between the property and the constant value 
        /// defined in this filter statement.
        /// </summary>
        Operation Operation { get; set; }
        /// <summary>
        /// Constant value that will interact with the property defined in this filter statement.
        /// </summary>
        object Value { get; set; }
    }

    public enum Operation
    {
        EqualTo,
        Contains,
        StartsWith,
        EndsWith,
        NotEqualTo,
        GreaterThan,
        GreaterThanOrEqualTo,
        LessThan,
        LessThanOrEqualTo
    }

}
