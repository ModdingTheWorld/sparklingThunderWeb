using Model.Configurations;
using Model.Entites;

namespace Domain.Repositories.Implementations;

public class StructureRepository: ARepository<Structure>
{
    public StructureRepository(ItemContext context) : base(context)
    {
    }
}