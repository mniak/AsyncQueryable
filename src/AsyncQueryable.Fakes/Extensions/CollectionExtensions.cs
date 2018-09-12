using AsyncQueryable.Fakes;
using System;
using System.Collections.Generic;
using System.Text;

namespace System.Linq
{
    public static class CollectionExtensions
    {
        public static IAsyncQueryable<T> AsFakeAsyncQueryable<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.AsQueryable().AsFakeAsync();
        }
        public static IAsyncQueryable<T> AsFakeAsync<T>(this IQueryable<T> queryable)
        {
            return new FakeAsyncQueryable<T>(queryable);
        }
        public static IAsyncQueryable AsFakeAsync(this IQueryable queryable)
        {
            return new FakeAsyncQueryable(queryable);
        }
    }
}
