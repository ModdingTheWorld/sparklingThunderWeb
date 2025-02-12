using System.Linq.Expressions;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;

namespace Domain.Repositories.Implementations;

public abstract class ARepository<TEntity>: IRepository<TEntity> where TEntity : class{
    protected readonly ItemContext Context;
    protected readonly DbSet<TEntity> Table;
    protected ARepository(ItemContext context) {
        Context = context;
        Table = context.Set<TEntity>();
    }
    public TEntity? Create(TEntity entity)
    {
        Table.Add(entity);
        Context.SaveChanges();
        return entity;
    }

    public List<TEntity>? CreateRange(List<TEntity> entities)
    {
        Table.AddRange(entities);
        Context.SaveChanges();
        return entities;
    }

    public void Update(TEntity entity)
    {
        Context.ChangeTracker.Clear();
        Table.Update(entity);
        Context.SaveChanges();
    }

    public void UpdateRange(List<TEntity> entities)
    {
        Table.UpdateRange(entities);
        Context.SaveChanges();
    }

    public TEntity? Read(int id)
    {
        return Table.Find(id);
    }

    public List<TEntity>? Read(Expression<Func<TEntity, bool>> predicate)
    {
        return Table.Where(predicate).ToList();
    }

    public List<TEntity>? Read(int start, int count)
    {
        return Table.Skip(start).Take(count).ToList();
    }

    public List<TEntity>? ReadAll()
    {
        return Table.ToList();
    }

    public void Delete(int id)
    {
        if (Table.Find(id) != null)
            Table.Remove(Table.Find(id)!);
    }

    public void Delete(TEntity entity)
    {
        Table.Remove(entity);
    }
}