using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Linq
{
    public static partial class AsyncQueryableExtensions
    {
        public static Task<List<TSource>> ToListAsync<TSource>(this IAsyncQueryable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ((IAsyncQueryProvider)source.Provider).ExecuteAsync<List<TSource>>(
                Expression.Call(
                    GetMethodInfo<IEnumerable<TSource>, List<TSource>>(Enumerable.ToList, source),
                    source.Expression),
                cancellationToken);
        }

    }
}
