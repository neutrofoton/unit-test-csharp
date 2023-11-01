namespace NeurtoLab.Repository.Test.Async;
public class CustomAsyncEnumerator<T> : IAsyncEnumerator<T>
{
    private readonly IEnumerator<T> enumerator;
    public CustomAsyncEnumerator(IEnumerator<T> enumerator)
    {
        this.enumerator = enumerator;
    }
    public T Current => this.enumerator.Current;
    public ValueTask DisposeAsync()
    {
        return new ValueTask(Task.Run(() => this.enumerator.Dispose()));
    }
    public ValueTask<bool> MoveNextAsync()
    {
        return new ValueTask<bool>(this.enumerator.MoveNext());
    }
}
