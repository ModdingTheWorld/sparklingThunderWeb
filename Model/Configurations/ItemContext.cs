using Microsoft.EntityFrameworkCore;
using Model.Entites;

namespace Model.Configurations;

public class ItemContext: DbContext
{
    public ItemContext(DbContextOptions<ItemContext> options) : base(options) { }
    public DbSet<Item> Items { get; set; }
}