using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace System.Linq
{
    public static partial class AsyncQueryableExtensions
    {
        public static IAsyncQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
            return (IAsyncQueryable<IGrouping<TKey, TSource>>)Queryable.GroupBy(source, keySelector);
        }

        public static IAsyncQueryable<TResult> GroupBy<TSource, TKey, TResult>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector)
        {
            return (IAsyncQueryable<TResult>)Queryable.GroupBy(source, keySelector, resultSelector);
        }

        public static IAsyncQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IAsyncQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector)
        {
            return (IAsyncQueryable<TResult>)Queryable.GroupJoin(outer, inner, outerKeySelector, innerKeySelector, resultSelector);
        }

        public static IAsyncQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IAsyncQueryable<TOuter> outer, IAsyncQueryable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector)
        {
            return GroupJoin(outer, inner.AsQueryable(), outerKeySelector, innerKeySelector, resultSelector);
        }

        public static IAsyncQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(this IAsyncQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector)
        {
            return (IAsyncQueryable<TResult>)Queryable.Join(outer, inner.AsQueryable(), outerKeySelector, innerKeySelector, resultSelector);
        }

        public static IAsyncQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(this IAsyncQueryable<TOuter> outer, IAsyncQueryable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector)
        {
            return Join(outer, inner.AsQueryable(), outerKeySelector, innerKeySelector, resultSelector);
        }

        public static IOrderedAsyncQueryable<TSource> OrderBy<TSource, TKey>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
            return (IOrderedAsyncQueryable<TSource>)Queryable.OrderBy(source, keySelector);
        }

        public static IOrderedAsyncQueryable<TSource> OrderByDescending<TSource, TKey>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
            return (IOrderedAsyncQueryable<TSource>)Queryable.OrderByDescending(source, keySelector);
        }

        public static IOrderedAsyncQueryable<TSource> ThenBy<TSource, TKey>(this IOrderedAsyncQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
            return (IOrderedAsyncQueryable<TSource>)Queryable.ThenBy(source, keySelector);
        }

        public static IOrderedAsyncQueryable<TSource> ThenByDescending<TSource, TKey>(this IOrderedAsyncQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
            return (IOrderedAsyncQueryable<TSource>)Queryable.ThenByDescending(source, keySelector);
        }
    }

}
