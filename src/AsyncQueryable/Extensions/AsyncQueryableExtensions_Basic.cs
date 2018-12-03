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
        public static Task<bool> AnyAsync<TSource>(this IAsyncQueryable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<bool>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, bool>(Queryable.Any, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<bool> AnyAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<bool>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, bool>(Queryable.Any, source, predicate),
                    source.Expression,
                    Expression.Quote(predicate)),
                cancellationToken);
        }

        public static Task<decimal> AverageAsync(this IAsyncQueryable<decimal> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<decimal>(
                Expression.Call(
                    GetMethodInfo<IQueryable<decimal>, decimal>(Queryable.Average, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<decimal?> AverageAsync(this IAsyncQueryable<decimal?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<decimal?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<decimal?>, decimal?>(Queryable.Average, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<double> AverageAsync(this IAsyncQueryable<double> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double>(
                Expression.Call(
                    GetMethodInfo<IQueryable<double>, double>(Queryable.Average, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<double?> AverageAsync(this IAsyncQueryable<double?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<double?>, double?>(Queryable.Average, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<float> AverageAsync(this IAsyncQueryable<float> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<float>(
                Expression.Call(
                    GetMethodInfo<IQueryable<float>, float>(Queryable.Average, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<float?> AverageAsync(this IAsyncQueryable<float?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<float?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<float?>, float?>(Queryable.Average, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<double> AverageAsync(this IAsyncQueryable<int> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double>(
                Expression.Call(
                    GetMethodInfo<IQueryable<int>, double>(Queryable.Average, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<double?> AverageAsync(this IAsyncQueryable<int?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<int?>, double?>(Queryable.Average, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<double> AverageAsync(this IAsyncQueryable<long> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double>(
                Expression.Call(
                    GetMethodInfo<IQueryable<long>, double>(Queryable.Average, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<double?> AverageAsync(this IAsyncQueryable<long?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<long?>, double?>(Queryable.Average, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<decimal> AverageAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, decimal>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<decimal>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, decimal>>, decimal>(Queryable.Average, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<decimal?> AverageAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<decimal?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, decimal?>>, decimal?>(Queryable.Average, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<double> AverageAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, double>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, double>>, double>(Queryable.Average, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<double?> AverageAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, double?>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, double?>>, double?>(Queryable.Average, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<float> AverageAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, float>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<float>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, float>>, float>(Queryable.Average, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<float?> AverageAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, float?>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<float?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, float?>>, float?>(Queryable.Average, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<double> AverageAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, int>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, int>>, double>(Queryable.Average, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<double?> AverageAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, int?>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, int?>>, double?>(Queryable.Average, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<double> AverageAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, long>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, long>>, double>(Queryable.Average, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<double?> AverageAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, long?>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, long?>>, double?>(Queryable.Average, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<int> CountAsync<TSource>(this IAsyncQueryable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<int>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, int>(Queryable.Count, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<int> CountAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<int>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, int>(Queryable.Count, source, predicate),
                    source.Expression,
                    Expression.Quote(predicate)),
                cancellationToken);
        }

        public static IAsyncQueryable<TSource> Distinct<TSource>(this IAsyncQueryable<TSource> source)
        {
            return (IAsyncQueryable<TSource>)Queryable.Distinct(source);
        }

        public static Task<TSource> FirstAsync<TSource>(this IAsyncQueryable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<TSource>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, TSource>(Queryable.First, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<TSource> FirstAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<TSource>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(Queryable.First, source, predicate),
                    source.Expression,
                    Expression.Quote(predicate)),
                cancellationToken);
        }

        public static Task<TSource> FirstOrDefaultAsync<TSource>(this IAsyncQueryable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<TSource>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, TSource>(Queryable.FirstOrDefault, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<TSource> FirstOrDefaultAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<TSource>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(Queryable.FirstOrDefault, source, predicate),
                    source.Expression,
                    Expression.Quote(predicate)),
                cancellationToken);
        }

        public static Task<long> LongCountAsync<TSource>(this IAsyncQueryable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<long>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, long>(Queryable.LongCount, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<long> LongCountAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<long>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, long>(Queryable.LongCount, source, predicate),
                    source.Expression,
                    Expression.Quote(predicate)),
                cancellationToken);
        }

        public static Task<TSource> MaxAsync<TSource>(this IAsyncQueryable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<TSource>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, TSource>(Queryable.Max, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<TResult> MaxAsync<TSource, TResult>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, TResult>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<TResult>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TResult>>, TResult>(Queryable.Max, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<TSource> MinAsync<TSource>(this IAsyncQueryable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<TSource>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, TSource>(Queryable.Min, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<TResult> MinAsync<TSource, TResult>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, TResult>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<TResult>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TResult>>, TResult>(Queryable.Min, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static IAsyncQueryable<TResult> OfType<TResult>(this IAsyncQueryable source)
        {
            return (IAsyncQueryable<TResult>)Queryable.OfType<TResult>(source);
        }

        public static IAsyncQueryable<TResult> Select<TSource, TResult>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
            return (IAsyncQueryable<TResult>)Queryable.Select(source, selector);
        }

        public static IAsyncQueryable<TResult> SelectMany<TSource, TResult>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, IEnumerable<TResult>>> selector)
        {
            return (IAsyncQueryable<TResult>)Queryable.SelectMany(source, selector);
        }

        public static IAsyncQueryable<TResult> SelectMany<TSource, TCollection, TResult>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector)
        {
            return (IAsyncQueryable<TResult>)Queryable.SelectMany(source, collectionSelector, resultSelector);
        }

        public static Task<TSource> SingleAsync<TSource>(this IAsyncQueryable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<TSource>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, TSource>(Queryable.Single, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<TSource> SingleAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<TSource>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(Queryable.Single, source, predicate),
                    source.Expression,
                    Expression.Quote(predicate)),
                cancellationToken);
        }

        public static Task<TSource> SingleOrDefaultAsync<TSource>(this IAsyncQueryable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<TSource>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, TSource>(Queryable.SingleOrDefault, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<TSource> SingleOrDefaultAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<TSource>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(Queryable.SingleOrDefault, source, predicate),
                    source.Expression,
                    Expression.Quote(predicate)),
                cancellationToken);
        }

        public static IAsyncQueryable<TSource> Skip<TSource>(this IAsyncQueryable<TSource> source, int count)
        {
            return (IAsyncQueryable<TSource>)Queryable.Skip(source, count);
        }

        public static Task<IQueryable<TSource>> SkipAsync<TSource>(this IAsyncQueryable<TSource> source, int count, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<IQueryable<TSource>>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, int, IQueryable<TSource>>(Queryable.Skip, source, count),
                    source.Expression,
                    Expression.Constant(count)),
                cancellationToken);
        }

        public static Task<decimal> SumAsync(this IAsyncQueryable<decimal> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<decimal>(
                Expression.Call(
                    GetMethodInfo<IQueryable<decimal>, decimal>(Queryable.Sum, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<decimal?> SumAsync(this IAsyncQueryable<decimal?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<decimal?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<decimal?>, decimal?>(Queryable.Sum, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<double> SumAsync(this IAsyncQueryable<double> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double>(
                Expression.Call(
                    GetMethodInfo<IQueryable<double>, double>(Queryable.Sum, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<double?> SumAsync(this IAsyncQueryable<double?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<double?>, double?>(Queryable.Sum, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<float> SumAsync(this IAsyncQueryable<float> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<float>(
                Expression.Call(
                    GetMethodInfo<IQueryable<float>, float>(Queryable.Sum, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<float?> SumAsync(this IAsyncQueryable<float?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<float?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<float?>, float?>(Queryable.Sum, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<int> SumAsync(this IAsyncQueryable<int> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<int>(
                Expression.Call(
                    GetMethodInfo<IQueryable<int>, int>(Queryable.Sum, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<int?> SumAsync(this IAsyncQueryable<int?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<int?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<int?>, int?>(Queryable.Sum, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<long> SumAsync(this IAsyncQueryable<long> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<long>(
                Expression.Call(
                    GetMethodInfo<IQueryable<long>, long>(Queryable.Sum, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<long?> SumAsync(this IAsyncQueryable<long?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<long?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<long?>, long?>(Queryable.Sum, source),
                    source.Expression),
                cancellationToken);
        }

        public static Task<decimal> SumAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, decimal>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<decimal>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, decimal>>, decimal>(Queryable.Sum, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<decimal?> SumAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<decimal?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, decimal?>>, decimal?>(Queryable.Sum, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<double> SumAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, double>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, double>>, double>(Queryable.Sum, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<double?> SumAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, double?>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<double?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, double?>>, double?>(Queryable.Sum, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<float> SumAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, float>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<float>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, float>>, float>(Queryable.Sum, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<float?> SumAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, float?>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<float?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, float?>>, float?>(Queryable.Sum, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<int> SumAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, int>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<int>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, int>>, int>(Queryable.Sum, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<int?> SumAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, int?>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<int?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, int?>>, int?>(Queryable.Sum, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<long> SumAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, long>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<long>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, long>>, long>(Queryable.Sum, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static Task<long?> SumAsync<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, long?>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<long?>(
                Expression.Call(
                    GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, long?>>, long?>(Queryable.Sum, source, selector),
                    source.Expression,
                    Expression.Quote(selector)),
                cancellationToken);
        }

        public static IAsyncQueryable<TSource> Take<TSource>(this IAsyncQueryable<TSource> source, int count)
        {
            return (IAsyncQueryable<TSource>)Queryable.Take(source, count);
        }

        public static IAsyncQueryable<TSource> Where<TSource>(this IAsyncQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return (IAsyncQueryable<TSource>)Queryable.Where(source, predicate);
        }

        private static MethodInfo GetMethodInfo<T1, T2>(Func<T1, T2> f, T1 unused)
        {
            return f.GetMethodInfo();
        }

        private static MethodInfo GetMethodInfo<T1, T2, T3>(Func<T1, T2, T3> f, T1 unused1, T2 unused2)
        {
            return f.GetMethodInfo();
        }
    }

}
