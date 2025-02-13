using Model.Configurations;
using Model.Entites;

namespace Domain.Repositories.Implementations;

public class ToolRepository: ARepository<Tool>
{
    public ToolRepository(ItemContext context) : base(context)
    {
    }
}