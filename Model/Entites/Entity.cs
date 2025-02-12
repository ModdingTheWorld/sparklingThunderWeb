using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites;

[Table("ENTITIES")]
public class Entity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ENTITY_ID")]
    public int EntityId { get; set; }
}