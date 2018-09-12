using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncQueryable.MongoDb
{
    internal class MongoAsyncQueryProvider : IAsyncQueryProvider
    {
        private readonly MethodInfo methodExecuteAsync;
        private readonly IQueryProvider queryProvider;

        public MongoAsyncQueryProvider(IQueryProvider queryProvider)
        {

            this.queryProvider = queryProvider;

            var interf = GetMethodExecuteAsync(queryProvider);
            this.methodExecuteAsync = GetMethodExecuteAsync(queryProvider);
        }

        private static MethodInfo GetMethodExecuteAsync(IQueryProvider queryProvider)
        {
            const string interfaceName = "IMongoQueryProvider";
            const string methodName = "ExecuteAsync";

            var type = queryProvider.GetType();
            var interf = type.GetInterface(interfaceName);
            if (interf == null)
                throw new ArgumentException($"The query provider must implement the interface {interfaceName}.", nameof(queryProvider));
            var method = interf.GetMethod(methodName);
            return method;
        }

        public IQueryable CreateQuery(Expression expression)
        {
            var query = queryProvider.CreateQuery(expression);
            if (query is IAsyncQueryable)
            {
                return query;
            }

            var result = (query as IMongoQueryable).AsAsync();
            return result;
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            var query = queryProvider.CreateQuery<TElement>(expression);
            if (query is IAsyncQueryable<TElement>)
            {
                return query;
            }

            var result = (query as IMongoQueryable<TElement>).AsAsync();
            return result;
        }

        public object Execute(Expression expression)
        {
            return this.queryProvider.Execute(expression);
        }

        public TResult Execute<TResult>(Expression expression)
        {
            return this.queryProvider.Execute<TResult>(expression);
        }

        public Task<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken = default(CancellationToken))
        {
            var genericMethod = methodExecuteAsync.MakeGenericMethod(new[] { typeof(TResult) });
            var result = genericMethod.Invoke(queryProvider, new object[] { expression, cancellationToken });
            var convertedResult = result as Task<TResult>;
            return convertedResult;
        }
    }
}
