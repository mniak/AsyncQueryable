using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncQueryable.Fakes
{
    internal class FakeAsyncQueryProvider : IAsyncQueryProvider
    {
        private readonly IQueryProvider queryProvider;

        public FakeAsyncQueryProvider(IQueryProvider queryProvider)
        {
            this.queryProvider = queryProvider;
        }
        public IQueryable CreateQuery(Expression expression)
        {
            var query = queryProvider.CreateQuery(expression);
            if (query is IAsyncQueryable)
            {
                return query;
            }

            var result = query.AsFakeAsync();
            return result;
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            var query = queryProvider.CreateQuery<TElement>(expression);
            if (query is IAsyncQueryable<TElement>)
            {
                return query;
            }

            var result = query.AsFakeAsync();
            return result;
        }

        public object Execute(Expression expression)
        {
            return queryProvider.Execute(expression);
        }

        public TResult Execute<TResult>(Expression expression)
        {
            return queryProvider.Execute<TResult>(expression);
        }

        public Task<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            var result = queryProvider.Execute<TResult>(expression);
            return Task.FromResult(result);
        }
    }
}
