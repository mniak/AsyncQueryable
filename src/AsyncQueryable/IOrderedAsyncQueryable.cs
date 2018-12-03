using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Linq
{
    public interface IOrderedAsyncQueryable<T> : IOrderedAsyncQueryable, IAsyncQueryable<T>, IOrderedQueryable<T>
    {
    
    }
    public interface IOrderedAsyncQueryable : IAsyncQueryable, IOrderedQueryable
    {
    }
}
