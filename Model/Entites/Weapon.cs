using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites;

[Table("WEAPONS")]
public class Weapon
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("WEAPON_ID")]
    public int WeaponId { get; set; }
}