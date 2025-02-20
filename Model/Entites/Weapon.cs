
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Model.Entites;


public class Weapon
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("WEAPON_ID")]
    public int WeaponId { get; set; }
    [Column("NAME"), MaxLength(20)] public string? Name { get; set; } = null;

}