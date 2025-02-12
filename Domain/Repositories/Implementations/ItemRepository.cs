using Model.Configurations;
using Model.Entites;

namespace Domain.Repositories.Implementations;

public class ItemRepository: ARepository<Item>
{
    public ItemRepository(ItemContext context) : base(context)
    {
    }
}