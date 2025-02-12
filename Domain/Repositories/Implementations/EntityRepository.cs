using Model.Configurations;
using Model.Entites;

namespace Domain.Repositories.Implementations;

public class EntityRepository: ARepository<Entity>
{
    public EntityRepository(ItemContext context) : base(context)
    {
    }
}