using System.Linq.Expressions;

namespace SubLight;

public sealed class SubLightQueryProvider
    : ISubLighQueryProvider
{
    public IQueryable CreateQuery(Expression expression)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> CreateQuery<TEntity>(Expression expression)
    {
        throw new NotImplementedException();
    }

    public object? Execute(Expression expression)
    {
        throw new NotImplementedException();
    }

    public TResult Execute<TResult>(Expression expression)
    {
        throw new NotImplementedException();
    }

    public string Translate(IQueryTranslator translator)
    {
        throw new NotImplementedException();
    }
}