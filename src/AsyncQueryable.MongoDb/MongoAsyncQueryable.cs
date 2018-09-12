using MongoDB.Driver.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AsyncQueryable.MongoDb
{
    internal class MongoAsyncQueryable<T> : MongoAsyncQueryable, IAsyncQueryable<T>, IOrderedAsyncQueryable<T>
    {
        public MongoAsyncQueryable(IMongoQueryable<T> queryable) : base(queryable)
        {
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (base.queryable as IEnumerable<T>).GetEnumerator();
        }
    }

    internal class MongoAsyncQueryable : IAsyncQueryable, IOrderedAsyncQueryable
    {
        protected readonly IMongoQueryable queryable;

        public MongoAsyncQueryable(IMongoQueryable queryable)
        {
            this.queryable = queryable;
            this.Provider = new MongoAsyncQueryProvider(queryable.Provider);
        }
        public IAsyncQueryProvider Provider { get; }

        public Type ElementType => queryable.ElementType;

        public Expression Expression => queryable.Expression;

        IQueryProvider IQueryable.Provider => this.Provider;

        public IEnumerator GetEnumerator()
        {
            return queryable.GetEnumerator();
        }
    }
}
