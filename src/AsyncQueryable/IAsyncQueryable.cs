using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Linq
{
    public interface IAsyncQueryable<T> : IQueryable<T>, IAsyncQueryable
    {
    }
    public interface IAsyncQueryable : IQueryable
    {
        new IAsyncQueryProvider Provider { get; }
    }
}
