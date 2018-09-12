using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AsyncQueryable.Fakes
{
    internal class FakeAsyncQueryable<T> : FakeAsyncQueryable, IAsyncQueryable<T>, IOrderedAsyncQueryable<T>
    {
        public FakeAsyncQueryable(IQueryable<T> queryable) : base(queryable)
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (base.queryable as IQueryable<T>).GetEnumerator();
        }
    }
    internal class FakeAsyncQueryable : IAsyncQueryable, IOrderedAsyncQueryable
    {
        protected readonly IQueryable queryable;
        public FakeAsyncQueryable(IQueryable queryable)
        {
            this.queryable = queryable;
            this.Provider = new FakeAsyncQueryProvider(queryable.Provider);
        }
        public IAsyncQueryProvider Provider { get; }

        public Type ElementType => queryable.ElementType;

        public Expression Expression => queryable.Expression;

        IQueryProvider IQueryable.Provider => this.Provider;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return queryable.GetEnumerator();
        }
    }
}
