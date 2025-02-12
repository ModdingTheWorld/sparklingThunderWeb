using Model.Configurations;
using Model.Entites;

namespace Domain.Repositories.Implementations;

public class BlockRepository: ARepository<Block>
{
    public BlockRepository(ItemContext context) : base(context)
    {
    }
}