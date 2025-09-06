using SubLight.Query;
using System.Linq.Expressions;

namespace SubLight;

public sealed class SubLightQueryProvider
    : ISubLightQueryProvider
{
    public IQueryable CreateQuery(Expression expression)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
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

    public TResult Translate<TResult>(Expression expression, IQueryTranslator<TResult> translator) where TResult : IQueryResult
    {
        throw new NotImplementedException();
    }
}