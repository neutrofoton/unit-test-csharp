using Microsoft.EntityFrameworkCore.Query;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using IAsyncQueryProvider = Microsoft.EntityFrameworkCore.Query.IAsyncQueryProvider;

namespace NeurtoLab.Repository.Test.Async;
internal class CustomAsyncQueryProvider<TEntity> : IAsyncQueryProvider
{
    private readonly IQueryProvider innerQueryProvider;
    internal CustomAsyncQueryProvider(IQueryProvider innerQueryProvider)
    {
        this.innerQueryProvider = innerQueryProvider;
    }
    public IQueryable CreateQuery(Expression expression)
    {
        return new CustomAsyncEnumerable<TEntity>(expression);
    }
    public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
    {
        return new CustomAsyncEnumerable<TElement>(expression);
    }
    public object Execute(Expression expression)
    {
        return innerQueryProvider.Execute(expression);
    }

    public TResult Execute<TResult>(Expression expression)
    {
        return this.innerQueryProvider.Execute<TResult>(expression);
    }
    public TResult ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken = new CancellationToken())
    {
        var expectedResultType = typeof(TResult).GetGenericArguments()[0];
        var executionResult = ((IQueryProvider)this).Execute(expression);
        return (TResult)typeof(Task).GetMethod(nameof(Task.FromResult))
            .MakeGenericMethod(expectedResultType)
            .Invoke(null, new[] { executionResult });
    }

   
}