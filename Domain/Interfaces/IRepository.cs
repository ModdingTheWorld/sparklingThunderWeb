using System.Linq.Expressions;

namespace Domain.Interfaces;

public interface IRepository<TEntity> where TEntity : class
{
    TEntity? Create(TEntity entity);
    List<TEntity>? CreateRange(List<TEntity> entities);
    void Update(TEntity entity);
    void UpdateRange(List<TEntity> entities);
    TEntity? Read(int id);
    List<TEntity>? Read(Expression<Func<TEntity, bool>> predicate);
    List<TEntity>? Read(int start, int count);
    List<TEntity>? ReadAll();
    void Delete(int id);
    void Delete(TEntity entity);
}