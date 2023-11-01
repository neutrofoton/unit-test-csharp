using System.Linq.Expressions;

namespace NeurtoLab.Repository.Test.Async
{
    public class CustomAsyncEnumerable<T> : EnumerableQuery<T>, IAsyncEnumerable<T>, IQueryable<T>
    {
        public CustomAsyncEnumerable(IEnumerable<T> enumerable)
            : base(enumerable)
        { }
        public CustomAsyncEnumerable(Expression expression)
            : base(expression)
        { }
        IQueryProvider IQueryable.Provider => new CustomAsyncQueryProvider<T>(this);
        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken token)
        {
            return new CustomAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

    }
}