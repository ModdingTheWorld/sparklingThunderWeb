using System.Linq.Expressions;
using Domain.Interfaces;

namespace Domain.Repositories.Implementations;

public abstract class ARepository<TEntity>: IRepository<TEntity> where TEntity : class{
    public TEntity? Create(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public List<TEntity>? CreateRange(List<TEntity> entities)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void UpdateRange(List<TEntity> entities)
    {
        throw new NotImplementedException();
    }

    public TEntity? Read(int id)
    {
        throw new NotImplementedException();
    }

    public List<TEntity>? Read(Expression<Func<TEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public List<TEntity>? Read(int start, int count)
    {
        throw new NotImplementedException();
    }

    public List<TEntity>? ReadAll()
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public void Delete(TEntity entity)
    {
        throw new NotImplementedException();
    }
}