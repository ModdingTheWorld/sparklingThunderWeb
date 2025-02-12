using Model.Configurations;
using Model.Entites;

namespace Domain.Repositories.Implementations;

public class ToolRepository: ARepository<Block>
{
    public ToolRepository(ItemContext context) : base(context)
    {
    }
}