using System.Linq.Expressions;

namespace SubLight;

public sealed class SubLightQueryBuilder
    : IQueryBuilder
{
    public IQueryBuilder Select<TEntity, TResult>(Expression<Func<TEntity, TResult>> selector) where TEntity : class
    {
        throw new NotImplementedException();
    }

    public string Translate(IQueryTranslator translator)
    {
        throw new NotImplementedException();
    }

    public IQueryBuilder Where<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
    {
        throw new NotImplementedException();
    }
}