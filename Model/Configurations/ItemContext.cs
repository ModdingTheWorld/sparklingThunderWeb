using Microsoft.EntityFrameworkCore;
using Model.Entites;

namespace Model.Configurations;

public class ItemContext: DbContext
{
    public ItemContext(DbContextOptions<ItemContext> options) : base(options) { }
    public DbSet<Item> Items { get; set; }
    public DbSet<Entity> Entities { get; set; }
    public DbSet<Block> Blocks { get; set; }
    public DbSet<Structure> Structures { get; set; }
    public DbSet<Tool> Tools { get; set; }
    public DbSet<Weapon> Weapons { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Block>().ToTable("BLOCKS");
        modelBuilder.Entity<Entity>().ToTable("ENTITIES");
        modelBuilder.Entity<Tool>().ToTable("TOOLS");
        modelBuilder.Entity<Weapon>().ToTable("WEAPONS");
        modelBuilder.Entity<Item>()
            .Property(e => e.Type)  // Ensure this property is mapped
            .HasConversion<string>();

    }
}

