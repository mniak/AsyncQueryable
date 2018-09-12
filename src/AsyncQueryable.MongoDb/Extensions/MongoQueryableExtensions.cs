using AsyncQueryable.MongoDb;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace System.Linq
{
    public static class MongoQueryableExtensions
    {
        public static IAsyncQueryable<T> AsAsyncQueryable<T>(this IMongoCollection<T> queryable)
        {
            return queryable.AsQueryable().AsAsync();
        }
        public static IAsyncQueryable<T> AsAsync<T>(this IMongoQueryable<T> queryable)
        {
            return new MongoAsyncQueryable<T>(queryable);
        }
        public static IAsyncQueryable AsAsync(this IMongoQueryable queryable)
        {
            return new MongoAsyncQueryable(queryable);
        }
    }
}
