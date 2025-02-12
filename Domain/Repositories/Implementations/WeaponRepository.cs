using Domain.Interfaces;
using Model.Configurations;
using Model.Entites;

namespace Domain.Repositories.Implementations;

public class WeaponRepository: ARepository<Weapon>
{
    public WeaponRepository(ItemContext context) : base(context)
    {
    }
}